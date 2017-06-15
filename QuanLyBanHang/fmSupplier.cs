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
            LoadComponent();
        }

        #region  method
        public void LoadComponent()
        {
            LoadGridView();
            AddBinding();
            CustomCB();
        }
        public void LoadGridView()
        {
            SupplierBinding.DataSource = SupplierDAO.Instance.ListSupplierByStatus();
            CustomGridView();
        }

        public void CustomGridView()
        {
            SupplierGridView.DataSource = SupplierBinding;

            SupplierGridView.Columns[1].HeaderText = "Tên hãng SX";
            SupplierGridView.Columns[2].HeaderText = "SL Tồn Kho";
            SupplierGridView.Columns[3].HeaderText = "SL Bán";
            SupplierGridView.Columns[4].HeaderText = "Ngày Tạo";
            SupplierGridView.Columns[5].HeaderText = "Ngày Sửa";
            SupplierGridView.Columns[6].HeaderText = "Trạng Thái";
        }

        public void CustomCB()
        {
            cbStatus.Items.Add("Đang hoạt động");
            cbStatus.Items.Add("Ngưng hoạt động");
        }
        public bool CheckForm()
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
        void AddBinding ()
        {
            txbID.DataBindings.Add(new Binding("Text", SupplierGridView.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbSupplierName.DataBindings.Add(new Binding("Text", SupplierGridView.DataSource, "Name", true, DataSourceUpdateMode.Never));
            numberStock.DataBindings.Add(new Binding("Value", SupplierGridView.DataSource, "Stock", true, DataSourceUpdateMode.Never));
            numberSold.DataBindings.Add(new Binding("Value", SupplierGridView.DataSource, "Sold", true, DataSourceUpdateMode.Never));
            cbStatus.DataBindings.Add(new Binding("Text", SupplierGridView.DataSource, "Status", true, DataSourceUpdateMode.Never));
        }
        public void LoadSupplierByStatus()
        {
            SupplierBinding.DataSource = SupplierDAO.Instance.ListSupplierByStatus();
        }
        #endregion


        #region event

        private const string find = "Từ khóa tìm kiếm";
        private void fmSupplier_FormClosed(object sender, FormClosedEventArgs e)
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
                    supplier.Stock = (int)numberStock.Value;
                    supplier.Sold = (int)numberSold.Value;
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
                    supplier.Stock = (int)numberStock.Value;
                    supplier.Sold = (int)numberSold.Value;
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
                    supplier.Stock = (int)numberStock.Value;
                    supplier.Sold = (int)numberSold.Value;
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
                var supplier = SupplierDAO.Instance.GetSupplierById(long.Parse(txbID.Text));
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
