using Database.EF.DAO;
using Database.EF.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyBanHang
{
    public partial class fmProduct : MetroFramework.Forms.MetroForm
    {
        BindingSource ProductBinding = new BindingSource();
        public fmProduct()
        {
            InitializeComponent();
            LoadComponent();
        }
        #region method


        public void LoadComponent()
        {
            LoadGridView();
            LoadCB();
            AddBinding();
        }
        public void LoadGridView()
        {
            ProductBinding.DataSource = ProductDAO.Instance.ListProductByStatus();
            CustomGridView();
        }

        public void CustomGridView()
        {
            dgvProduct.DataSource = ProductBinding;

            dgvProduct.Columns[1].HeaderText = "Tên SP";
            dgvProduct.Columns[2].HeaderText = "Giá";
            dgvProduct.Columns[3].HeaderText = "SL Tồn kho";
            dgvProduct.Columns[4].HeaderText = "SL bán";
            dgvProduct.Columns[5].HeaderText = "Mã loại SP";
            dgvProduct.Columns[6].HeaderText = "Mã nhà SX";
            dgvProduct.Columns[7].HeaderText = "Ngày tạo";
            dgvProduct.Columns[8].HeaderText = "Ngày cập nhật";
            dgvProduct.Columns[9].HeaderText = "Trạng thái";
        }
        public void AddBinding()
        {
            txbID.DataBindings.Add(new Binding("Text", dgvProduct.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbProductName.DataBindings.Add(new Binding("Text", dgvProduct.DataSource, "Name", true, DataSourceUpdateMode.Never));
            numberStock.DataBindings.Add(new Binding("Value", dgvProduct.DataSource, "Stock", true, DataSourceUpdateMode.Never));
            numberSold.DataBindings.Add(new Binding("Value", dgvProduct.DataSource, "Sold", true, DataSourceUpdateMode.Never));
            cbCateID.DataBindings.Add(new Binding("SelectedValue", dgvProduct.DataSource, "CategoryID", true, DataSourceUpdateMode.Never));
            cbSupplierId.DataBindings.Add(new Binding("SelectedValue", dgvProduct.DataSource, "SupplierID", true, DataSourceUpdateMode.Never));
            cbStatus.DataBindings.Add(new Binding("Text", dgvProduct.DataSource, "Status", true, DataSourceUpdateMode.Never));
        }
        public void LoadProductByStatus()
        {
            ProductBinding.DataSource = ProductDAO.Instance.ListProductByStatus();
        }

        public void LoadCB()
        {
            // cb Trạng thái
            cbStatus.Items.Add("Đang bán");
            cbStatus.Items.Add("Ngưng bán");
            cbStatus.Items.Add("Hết hàng");

            CBCategoryID(); // Combo box category id

            CBSupplierID(); // Combo box Supplier id

            nbPrice.ThousandsSeparator = true;
        }

        public void CBCategoryID()
        {
            ShopDbContext db = new ShopDbContext();

            cbCateID.DataSource = CategoryDAO.Instance.ListCategoryByStatus();
            cbCateID.DisplayMember = "Name";
            cbCateID.ValueMember = "ID";
        }

        public void CBSupplierID()
        {
            ShopDbContext db = new ShopDbContext();

            cbSupplierId.DataSource = SupplierDAO.Instance.ListSupplierByStatus();
            cbSupplierId.DisplayMember = "Name";
            cbSupplierId.ValueMember = "ID";
        }

        public bool CheckForm()
        {
            errorProvider.Clear();
            if (String.IsNullOrWhiteSpace(txbProductName.Text))
            {
                errorProvider.SetError(txbProductName, "Loại sản phẩm không được để trống");
                return false;
            }

            if (String.IsNullOrEmpty(cbStatus.Text))
            {
                errorProvider.SetError(cbStatus, "Hãy chọn trạng thái");
                return false;
            }

            if (String.IsNullOrEmpty(cbCateID.Text))
            {
                errorProvider.SetError(cbCateID, "Hãy chọn mã loại SP");
                return false;
            }

            if (String.IsNullOrEmpty(cbSupplierId.Text))
            {
                errorProvider.SetError(cbSupplierId, "Hãy mã nhà SX");
                return false;
            }
            return true;
        }
        #endregion

        #region event
        private void fmProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        #endregion

        #region button
        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {

                Product product = new Product();

                var result = ProductDAO.Instance.CheckProduct(txbProductName.Text);
                if (result == 1)
                {
                    product.Name = txbProductName.Text;
                    product.Stock = (int)numberStock.Value;
                    product.Sold = (int)numberSold.Value;
                    product.Price = nbPrice.Value;
                    product.CategoryID = long.Parse(cbCateID.Text);
                    product.SupplierID = long.Parse(cbSupplierId.Text);
                    product.CreatedDate = DateTime.Now;
                    if ((int)numberStock.Value == 0)
                    {
                        product.Status = "Hết hàng";
                    }
                    else
                    {
                        product.Status = cbStatus.Text;
                    }
                    ProductDAO.Instance.AddProduct(product);

                    MessageBox.Show("Thêm loại sản phẩm thành công.");
                }
                else
                {
                    MessageBox.Show("Loại sản phẩm đã tồn tại.");
                }
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm không thành công.");
            }
            LoadProductByStatus();
        }
        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            if(CheckForm())
            {
                var product = ProductDAO.Instance.GetProductById(long.Parse(txbID.Text));
                if (ProductDAO.Instance.CheckProduct(txbProductName.Text) == 1)
                {
                    product.Name = txbProductName.Text;
                    product.Stock = (int)numberStock.Value;
                    product.Sold = (int)numberSold.Value;
                    product.Price = nbPrice.Value;
                    product.CategoryID = long.Parse(cbCateID.SelectedValue.ToString());
                    product.SupplierID = long.Parse(cbSupplierId.SelectedValue.ToString());
                    product.Status = cbStatus.Text;
                    product.ModifiedDate = DateTime.Now;

                    var result = ProductDAO.Instance.UpdateProduct(product);
                    if (result)
                    {
                        MessageBox.Show("Cập nhật thành công.");
                    }
                }
                else
                {
                    product.Stock = (int)numberStock.Value;
                    product.Sold = (int)numberSold.Value;
                    product.Status = cbStatus.Text;
                    product.ModifiedDate = DateTime.Now;

                    var result = ProductDAO.Instance.UpdateProduct(product);
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

            LoadProductByStatus();
        }
        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            DialogResult Delete = MessageBox.Show("Xác nhận Xóa", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Delete == DialogResult.OK)
            {
                var product = ProductDAO.Instance.GetProductById(long.Parse(txbID.Text));
                var result = ProductDAO.Instance.DeleteProduct(long.Parse(txbID.Text));
                if (result)
                {
                    MessageBox.Show("Xóa thành công.");
                }
                LoadProductByStatus();
            }
            else
            {
                return;
            }
        }
        private void btnLoadProduct_Click(object sender, EventArgs e)
        {
            ShopDbContext db = new ShopDbContext();

            ProductBinding.DataSource = db.Products.ToList();
        }


        #endregion


    }
}
