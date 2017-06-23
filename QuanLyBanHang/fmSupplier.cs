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
    public partial class fmSupplier : MetroFramework.Forms.MetroForm
    {
        BindingSource SupplierBinding = new BindingSource();
        public fmSupplier()
        {
            InitializeComponent();
        }

        #region  method
        public void LoadComponent()
        {
            LoadGridView();
            AddBinding();
            CBStatus();
        }
        public void LoadGridView()
        {
            SupplierBinding.DataSource = SupplierDAO.Instance.ListSupplierByStatus();
            CustomGridView();
        }

        public void CustomGridView() // config gridview
        {
            dgvSupplier.DataSource = SupplierBinding;

            dgvSupplier.Columns[1].HeaderText = "Tên hãng SX";
            dgvSupplier.Columns[2].HeaderText = "SL còn";
            dgvSupplier.Columns[3].HeaderText = "SL bán";
            dgvSupplier.Columns[4].HeaderText = "Ngày tạo";
            dgvSupplier.Columns[5].HeaderText = "Ngày cập nhật";
            dgvSupplier.Columns[6].HeaderText = "Trạng thái";

            dgvSupplier.Columns[0].Width = 40;
            dgvSupplier.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSupplier.Columns[2].Width = 50;
            dgvSupplier.Columns[3].Width = 50;
            dgvSupplier.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSupplier.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSupplier.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void CBStatus() // load diệu liệu combobox trạng thái
        {
            ShopDbContext db = new ShopDbContext();

            cbStatus.DataSource = db.Status.Where(x => x.ID == 1 || x.ID == 2).Select(x => x.Status1).ToList();
            cbStatus.DisplayMember = "Status";
        }
        public bool CheckForm() // validate form
        {
            errorProvider.Clear();
            if (String.IsNullOrWhiteSpace(txbSupplierName.Text))
            {
                errorProvider.SetError(txbSupplierName, "Loại sản phẩm không được để trống");
                return false;
            }

            if (String.IsNullOrEmpty(cbStatus.Text))
            {
                errorProvider.SetError(cbStatus, "Hãy chọn trạng thái");
                return false;
            }
            return true;
        }
        void AddBinding() // Binding dữ liệu
        {
            txbID.DataBindings.Add(new Binding("Text", dgvSupplier.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbSupplierName.DataBindings.Add(new Binding("Text", dgvSupplier.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbStock.DataBindings.Add(new Binding("Text", dgvSupplier.DataSource, "Stock", true, DataSourceUpdateMode.Never));
            txbSold.DataBindings.Add(new Binding("Text", dgvSupplier.DataSource, "Sold", true, DataSourceUpdateMode.Never));
            cbStatus.DataBindings.Add(new Binding("Text", dgvSupplier.DataSource, "Status", true, DataSourceUpdateMode.Never));
        }
        public void LoadSupplierByStatus() // Load dữ liệu theo trạng thái đang bán
        {
            SupplierBinding.DataSource = SupplierDAO.Instance.ListSupplierByStatus();
        }

     
        #endregion

        #region event
        private void fmSupplier_Load(object sender, EventArgs e) // event load form
        {
            LoadComponent();
        }
        private const string find = "Từ khóa tìm kiếm";
        private void fmSupplier_FormClosed(object sender, FormClosedEventArgs e) // event textbox tìm kiếm
        {
            this.Hide();
        }


        private void txbFindSupplier_GotFocus(object sender, EventArgs e)
        {
            txbFindSupplier.Text = txbFindSupplier.Text == find ? string.Empty : txbFindSupplier.Text;
        }

        private void txbFindSupplier_LostFocus(object sender, EventArgs e)
        {
            txbFindSupplier.Text = txbFindSupplier.Text == string.Empty ? find : txbFindSupplier.Text;
        }

        #endregion

        #region button

        private void btnSupplierAdd_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Supplier supplier = new Supplier();
                var result = SupplierDAO.Instance.CheckSupplier(txbSupplierName.Text);
                if (result == 1)
                {
                    supplier.Name = txbSupplierName.Text;
                    supplier.Stock = 0;
                    supplier.Sold = 0;
                    supplier.CreatedDate = DateTime.Now;
                    supplier.Status = cbStatus.Text;

                    SupplierDAO.Instance.AddSupplier(supplier);

                    MessageBox.Show("Thêm hãng sản xuất thành công.");

                }
                else
                {
                    MessageBox.Show("Hãng sản xuất đã tồn tại.");
                }
            }
            else
            {
                MessageBox.Show("Thêm hãng sản xuất không thành công.");
            }
            LoadSupplierByStatus();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ShopDbContext db = new ShopDbContext();

            SupplierBinding.DataSource = db.Suppliers.ToList();
        }

        private void btnSupplierUpdate_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                var supplier = SupplierDAO.Instance.GetSupplierById(long.Parse(txbID.Text));
                if (SupplierDAO.Instance.CheckSupplier(txbSupplierName.Text) == 1)
                {
                    supplier.Name = txbSupplierName.Text;
                    supplier.Status = cbStatus.Text;
                    supplier.ModifiedDate = DateTime.Now;

                    var result = SupplierDAO.Instance.UpdateSupplier(supplier);
                    if (result)
                    {
                        MessageBox.Show("Cập nhật thành công.");
                    }
                }
                else
                {
                    supplier.Status = cbStatus.Text;
                    supplier.ModifiedDate = DateTime.Now;

                    var result = SupplierDAO.Instance.UpdateSupplier(supplier);
                    if (result)
                    {
                        MessageBox.Show("Cập nhật thành công.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công.");
            }

            LoadSupplierByStatus();
        }
        private void btnDeleteDelete_Click(object sender, EventArgs e)
        {
            DialogResult Delete = MessageBox.Show("Xác nhận Xóa", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Delete == DialogResult.OK)
            {
                var result = SupplierDAO.Instance.DeleteSupplier(long.Parse(txbID.Text));
                if (result)
                {
                    MessageBox.Show("Xóa thành công.");
                }
                LoadSupplierByStatus();
            }
            else
            {
                return;
            }
        }

        private void btnSupplierFind_Click(object sender, EventArgs e)
        {
            var list = SupplierDAO.Instance.SearchSupplier(txbFindSupplier.Text);
            SupplierBinding.DataSource = list;
        }

        #endregion


    }
}
