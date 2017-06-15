using Database.EF.DAO;
using Database.EF.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            LoadComponent();

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
        public void CustomGridView()
        {
            dgvOrder.DataSource = OrderBinding;

            dgvOrder.Columns[1].HeaderText = "Tên KH";
            dgvOrder.Columns[2].HeaderText = "Địa chỉ";
            dgvOrder.Columns[3].HeaderText = "SĐT";
            dgvOrder.Columns[4].HeaderText = "Email";
            dgvOrder.Columns[5].HeaderText = "Ngày tạo";
            dgvOrder.Columns[6].HeaderText = "Ngày cập nhật";
            dgvOrder.Columns[7].HeaderText = "Trạng thái";
        }

        public void CustomCB()
        {
            cbStatus.Items.Add("Đang xử lý");
            cbStatus.Items.Add("Hoàn tất");
        }

        public bool CheckForm()
        {
            errorProvider.Clear();
            if (String.IsNullOrWhiteSpace(txbCusName.Text))
            {
                errorProvider.SetError(txbCusName, "Tên khách hàng không được để trống");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txbAddress.Text))
            {
                errorProvider.SetError(txbAddress, "Địa chỉ không được để trống");
            }

            if (String.IsNullOrEmpty(cbStatus.Text))
            {
                errorProvider.SetError(cbStatus, "Hãy chọn trạng thái");
                return false;
            }

            return true;
        }
        public void LoadOrderByStatus()
        {
            OrderBinding.DataSource = OrderDAO.Instance.ListOrderByStatus();
        }

        public void AddBinding()
        {
            txbID.DataBindings.Add(new Binding("Text", dgvOrder.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbCusName.DataBindings.Add(new Binding("Text", dgvOrder.DataSource, "CustomerName", true, DataSourceUpdateMode.Never));
            txbAddress.DataBindings.Add(new Binding("Text", dgvOrder.DataSource, "CustomerAddress", true, DataSourceUpdateMode.Never));
            txbPhone.DataBindings.Add(new Binding("Text", dgvOrder.DataSource, "CustomerPhone", true, DataSourceUpdateMode.Never));
            txbEmail.DataBindings.Add(new Binding("Text", dgvOrder.DataSource, "CustomerEmail", true, DataSourceUpdateMode.Never));
            cbStatus.DataBindings.Add(new Binding("Text", dgvOrder.DataSource, "Status", true, DataSourceUpdateMode.Never));
        }
        #endregion

        #region Button
        private void btnOrderAdd_Click(object sender, EventArgs e)
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

                MessageBox.Show("Thêm hãng sản xuất thành công.");

            }
            else
            {
                MessageBox.Show("Thêm hãng sản xuất không thành công.");
            }

            LoadOrderByStatus();
        }

        private void btnOrderUpdate_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                var order = OrderDAO.Instance.GetOrderById(long.Parse(txbID.Text));

                order.CustomerName = txbCusName.Text;
                order.CustomerAddress = txbAddress.Text;
                order.CustomerEmail = txbEmail.Text;
                order.CustomerPhone = txbPhone.Text;
                order.Status = cbStatus.Text;

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
        }

        private void btnOrderDelete_Click(object sender, EventArgs e)
        {
            DialogResult Delete = MessageBox.Show("Xác nhận Xóa", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Delete == DialogResult.OK)
            {
                var order = OrderDAO.Instance.GetOrderById(long.Parse(txbID.Text));
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
        private void btnOrderLoad_Click(object sender, EventArgs e)
        {
            ShopDbContext db = new ShopDbContext();

            OrderBinding.DataSource = db.Orders.ToList();
        }
        #endregion

    }
}
