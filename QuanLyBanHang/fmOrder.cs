using Database.EF.DAO;
using Database.EF.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class fmOrder : MetroFramework.Forms.MetroForm
    {
        BindingSource OrderBinding = new BindingSource();

        public fmOrder()
        {
            InitializeComponent();
        }
        #region Method
        public void LoadComponent()
        {
            LoadGridView();
            CustomCB();
            AddBinding();
        }
        public void LoadGridView()
        {
            OrderBinding.DataSource = OrderDAO.Instance.ListOrderByStatus();
            CustomGridView();
        }
        public void CustomGridView() // Config Gridview
        {
            dgvOrder.DataSource = OrderBinding;
            dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvOrder.Columns[1].HeaderText = "Tên KH";
            dgvOrder.Columns[2].HeaderText = "Địa chỉ";
            dgvOrder.Columns[3].HeaderText = "SĐT";
            dgvOrder.Columns[4].HeaderText = "Email";
            dgvOrder.Columns[5].HeaderText = "Thành tiền";
            dgvOrder.Columns[6].HeaderText = "Ngày tạo";
            dgvOrder.Columns[7].HeaderText = "Ngày cập nhật";
            dgvOrder.Columns[8].HeaderText = "Trạng thái";

            dgvOrder.Columns[0].Width = 40;
            dgvOrder.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvOrder.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvOrder.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvOrder.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvOrder.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvOrder.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvOrder.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvOrder.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            if (dgvOrder.Rows.Count > 0)
            {
                dgvOrder.Rows[0].Selected = true;
            }
        }

        public void CustomCB() // Load dữ liệu combobox trạng thái
        {
            ShopDbContext db = new ShopDbContext();

            cbStatus.DataSource = db.Status.Where(x => x.ID == 6 || x.ID == 7).Select(x => x.Status1).ToList();
            cbStatus.DisplayMember = "Status";
        }

        public bool CheckForm() // Validate form
        {
            errorProvider.Clear();
            if (String.IsNullOrWhiteSpace(txbCusName.Text))
            {
                errorProvider.SetError(txbCusName, "Tên khách hàng không được để trống.");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txbAddress.Text))
            {
                errorProvider.SetError(txbAddress, "Địa chỉ không được để trống.");
            }

            if (String.IsNullOrEmpty(cbStatus.Text))
            {
                errorProvider.SetError(cbStatus, "Hãy chọn trạng thái.");
                return false;
            }

            if (!String.IsNullOrWhiteSpace(txbPhone.Text))
            {
                if (Regex.Match(txbPhone.Text, @"^(\+[0-9]{9})$").Success)
                {
                    errorProvider.SetError(txbPhone, "Số điện thoại không đúng định dạng.");
                    return false;
                }
                
            }

            if (!String.IsNullOrWhiteSpace(txbEmail.Text))
            {
                var checkEmail = new EmailAddressAttribute();
                if (!checkEmail.IsValid(txbEmail.Text))
                {
                    errorProvider.SetError(txbEmail, "Email không đúng định dạng.");
                    return false;
                }
            }


            return true;
        }
        public void LoadOrderByStatus() // Load dữ liệu theo trạng thái đang xử lý
        {
            OrderBinding.DataSource = OrderDAO.Instance.ListOrderByStatus();
        }

        public void AddBinding() // Binding dữ liệu
        {
            txbID.DataBindings.Add(new Binding("Text", dgvOrder.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbCusName.DataBindings.Add(new Binding("Text", dgvOrder.DataSource, "CustomerName", true, DataSourceUpdateMode.Never));
            txbAddress.DataBindings.Add(new Binding("Text", dgvOrder.DataSource, "CustomerAddress", true, DataSourceUpdateMode.Never));
            txbPhone.DataBindings.Add(new Binding("Text", dgvOrder.DataSource, "CustomerPhone", true, DataSourceUpdateMode.Never));
            txbEmail.DataBindings.Add(new Binding("Text", dgvOrder.DataSource, "CustomerEmail", true, DataSourceUpdateMode.Never));
            txbTotal.DataBindings.Add(new Binding("Text", dgvOrder.DataSource, "TotalPrice", true, DataSourceUpdateMode.Never));
            cbStatus.DataBindings.Add(new Binding("Text", dgvOrder.DataSource, "Status", true, DataSourceUpdateMode.Never));
        }

        #endregion

        #region Event
        private void fmOrder_Load(object sender, EventArgs e) // Event load form
        {
            LoadComponent();
        }
        private void fmOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }// event form đóng

        private const string find = "Từ khóa tìm kiếm";

        private void txbProductFind_GotFocus(object sender, EventArgs e) // event text box tìm kiếm
        {
            txbOrderFind.Text = txbOrderFind.Text == find ? string.Empty : txbOrderFind.Text;
        }

        private void txbProductFind_LostFocus(object sender, EventArgs e)
        {
            txbOrderFind.Text = txbOrderFind.Text == string.Empty ? find : txbOrderFind.Text;
        }

        private void dgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e) // Event mở chi tiết hóa đơn khi double click
        {
            Order order = OrderBinding.Current as Order;
            if (order != null)
            {
                using (fmOrderDetail fm = new fmOrderDetail(order))
                {
                    fm.ShowDialog();
                }
            }
        }

        private void txbTotal_TextChanged(object sender, EventArgs e) // Event cho textbox thành tiền + display format
        {
            ShopDbContext db = new ShopDbContext();
            long id = long.Parse(txbID.Text);
            var price = db.Orders.Where(x => x.ID == id).Select(x => x.TotalPrice).SingleOrDefault();

            txbTotal.Text = String.Format("{0:#,###0}", price);
        }
        private void dgvOrder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) // Format display cho cột thành tiền
        {
            if (dgvOrder.Columns[e.ColumnIndex].HeaderText == "Thành tiền")
            {
                if (e.Value != null)
                {
                    e.CellStyle.Format = "#,###";
                }
            }
        }


        #endregion

        #region Button
        private void btnOrderAdd_Click(object sender, EventArgs e) // Nút thêm
        {

            if (CheckForm())
            {
                Order order = new Order();

                order.CustomerName = txbCusName.Text;
                order.CustomerAddress = txbAddress.Text;
                order.CustomerEmail = txbEmail.Text;
                order.CustomerPhone = txbPhone.Text;
                order.CreatedDate = DateTime.Now;
                order.Status = cbStatus.Text;

                OrderDAO.Instance.AddOrder(order);

                MessageBox.Show("Thêm hóa đơn thành công.");

            }
            else
            {
                MessageBox.Show("Thêm hóa đơn không thành công.");
            }

            LoadOrderByStatus();
        }

        private void btnOrderUpdate_Click(object sender, EventArgs e) // Nút cập nhật
        {
            if (CheckForm())
            {
                var order = OrderDAO.Instance.GetOrderById(long.Parse(txbID.Text));

                order.CustomerName = txbCusName.Text;
                order.CustomerAddress = txbAddress.Text;
                order.CustomerEmail = txbEmail.Text;
                order.CustomerPhone = txbPhone.Text;
                order.Status = cbStatus.Text;
                order.ModifiedDate = DateTime.Now;

                var result = OrderDAO.Instance.UpdateOrder(order);
                if (result)
                {
                    MessageBox.Show("Cập nhật thành công.");
                }
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công.");
            }

            LoadOrderByStatus();
        }

        private void btnOrderDelete_Click(object sender, EventArgs e) // Nút xóa
        {
            DialogResult Delete = MessageBox.Show("Xác nhận Xóa", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Delete == DialogResult.OK)
            {
                var result = OrderDAO.Instance.DeleteOrder(long.Parse(txbID.Text));
                if (result)
                {
                    MessageBox.Show("Xóa thành công.");
                }
                LoadOrderByStatus();
            }
            else
            {
                return;
            }
        }
        private void btnOrderLoad_Click(object sender, EventArgs e) // Nút xem
        {
            ShopDbContext db = new ShopDbContext();

            OrderBinding.DataSource = db.Orders.ToList();
        }

        private void btnOrderFind_Click(object sender, EventArgs e) // Nút tìm kiếm
        {
            var list = OrderDAO.Instance.SearchOrder(txbOrderFind.Text);
            OrderBinding.DataSource = list;
        }
        #endregion

    }
}
