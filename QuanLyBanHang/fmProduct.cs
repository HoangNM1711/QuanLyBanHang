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

        }
        #region method

        public void LoadComponent()
        {
            LoadGridView();
            LoadCB();
            AddBinding();
            CategoryStockSold();
            SupplierStockSold();
        }
        public void LoadGridView() // Config dữ liệu cho Gridview
        {
            
            ShopDbContext db = new ShopDbContext();

            var query = from a in db.Categories
                        join b in db.Products
                        on a.ID equals b.CategoryID
                        join c in db.Suppliers
                        on b.SupplierID equals c.ID
                        select new
                        {
                            ID = b.ID,
                            Name = b.Name,
                            Price = b.Price,
                            Stock = b.Stock,
                            Sold = b.Sold,
                            CateName = a.Name,
                            SuppName = c.Name,
                            CreatedDate = b.CreatedDate,
                            ModifiedDate = b.ModifiedDate,
                            Status = b.Status
                        };

            ProductBinding.DataSource = query.Where(x => x.Status == "Đang bán").ToList();

            CustomGridView();
        }

        public void CustomGridView() // Config griddview
        {
            dgvProduct.DataSource = ProductBinding;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvProduct.Columns[1].HeaderText = "Tên SP";
            dgvProduct.Columns[2].HeaderText = "Giá";
            dgvProduct.Columns[3].HeaderText = "SL còn";
            dgvProduct.Columns[4].HeaderText = "SL bán";
            dgvProduct.Columns[5].HeaderText = "Danh mục";
            dgvProduct.Columns[6].HeaderText = "Nhà SX";
            dgvProduct.Columns[7].HeaderText = "Ngày tạo";
            dgvProduct.Columns[8].HeaderText = "Ngày cập nhật";
            dgvProduct.Columns[9].HeaderText = "Trạng thái";

            dgvProduct.Columns[0].Width = 40;
            dgvProduct.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProduct.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProduct.Columns[3].Width = 50;
            dgvProduct.Columns[4].Width = 50;
            dgvProduct.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProduct.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProduct.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProduct.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProduct.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            if (dgvProduct.Rows.Count > 0)
            {
                dgvProduct.Rows[0].Selected = true;
            }
        }
        public void AddBinding() // Binding dữ liệu
        {
            txbID.DataBindings.Add(new Binding("Text", dgvProduct.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbProductName.DataBindings.Add(new Binding("Text", dgvProduct.DataSource, "Name", true, DataSourceUpdateMode.Never));
            numberStock.DataBindings.Add(new Binding("Value", dgvProduct.DataSource, "Stock", true, DataSourceUpdateMode.Never));
            numberSold.DataBindings.Add(new Binding("Value", dgvProduct.DataSource, "Sold", true, DataSourceUpdateMode.Never));
            nbPrice.DataBindings.Add(new Binding("Value", dgvProduct.DataSource, "Price", true, DataSourceUpdateMode.Never));
            cbStatus.DataBindings.Add(new Binding("Text", dgvProduct.DataSource, "Status", true, DataSourceUpdateMode.Never));
        }
        public void LoadProductByStatus() // Load dữ liệu theo trạng thái đang bán
        {
            ProductBinding.DataSource = ProductDAO.Instance.ListProductByStatus();
        }

        public void LoadCB() // Load dữ liệu cho các combo box
        {
            // cb Trạng thái
            ShopDbContext db = new ShopDbContext();

            cbStatus.DataSource = db.Status.Where(x => x.ID == 1 || x.ID == 2).Select(x => x.Status1).ToList();
            cbStatus.DisplayMember = "Status";

            CBCategoryID(); // Combo box category id

            CBSupplierID(); // Combo box Supplier id

            nbPrice.ThousandsSeparator = true;
        }

        public void CBCategoryID() // Load dữ liệu combobox danh mục
        {
            cbCateID.DataSource = CategoryDAO.Instance.ListCategoryByStatus();
            cbCateID.DisplayMember = "Name";
            cbCateID.ValueMember = "ID";

            cbCateID.DropDownHeight = cbCateID.ItemHeight * 5;
        }

        public void CBSupplierID() // Load dữ liệu combobox nhà sản xuất
        {
            cbSupplierId.DataSource = SupplierDAO.Instance.ListSupplierByStatus();
            cbSupplierId.DisplayMember = "Name";
            cbSupplierId.ValueMember = "ID";

            cbSupplierId.DropDownHeight = cbSupplierId.ItemHeight * 5;
        }

        public bool CheckForm() // validate form
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

        public void SupplierStockSold() // Tự động cập nhật hàng còn và hàng bán của table Supplier
        {
            if (dgvProduct.Rows.Count > 0)
            {
                ShopDbContext db = new ShopDbContext();

                foreach (DataGridViewRow row in dgvProduct.Rows)
                {
                    long id = long.Parse(row.Cells[0].Value.ToString());
                    Product pro = ProductDAO.Instance.GetProductById(id);
                    Supplier supp = SupplierDAO.Instance.GetSupplierById(pro.SupplierID);

                    var stock = db.Products.Where(x => x.SupplierID == supp.ID).Select(x => x.Stock).Sum();

                    var sold = db.Products.Where(x => x.SupplierID == supp.ID).Select(x => x.Sold).Sum();

                    supp.Stock = stock;
                    supp.Sold = sold;
                    supp.ModifiedDate = DateTime.Now;

                    SupplierDAO.Instance.UpdateStockSold(supp);
                }
            }            
        }

        public void CategoryStockSold() // Tự động cập nhật hàng còn và hàng bán của table Category
        {
            if (dgvProduct.Rows.Count > 0)
            {
                ShopDbContext db = new ShopDbContext();

                foreach (DataGridViewRow row in dgvProduct.Rows)
                {

                    long id = long.Parse(row.Cells[0].Value.ToString());
                    Product pro = ProductDAO.Instance.GetProductById(id);
                    Category cate = CategoryDAO.Instance.GetCategoryById(pro.CategoryID);

                    var stock = db.Products.Where(x => x.CategoryID == cate.ID).Select(x => x.Stock).Sum();

                    var sold = db.Products.Where(x => x.CategoryID == cate.ID).Select(x => x.Sold).Sum();

                    cate.Stock = stock;
                    cate.Sold = sold;
                    cate.ModifiedDate = DateTime.Now;

                    CategoryDAO.Instance.UpdateCateStockSold(cate);
                }
            }
        }
        #endregion

        #region event
        private void fmProduct_Load(object sender, EventArgs e) // event load form
        {
            LoadComponent();
        }
        private void fmProduct_FormClosed(object sender, FormClosedEventArgs e)// event đóng form
        {
            this.Hide();
        }

        private const string find = "Từ khóa tìm kiếm";
        private void txbProductFind_GotFocus(object sender, EventArgs e) // event textbox tìm kiếm
        {
            txbProductFind.Text = txbProductFind.Text == find ? string.Empty : txbProductFind.Text;
        }

        private void txbProductFind_LostFocus(object sender, EventArgs e)
        {
            txbProductFind.Text = txbProductFind.Text == string.Empty ? find : txbProductFind.Text;
        }
        private void dgvProduct_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) // Display format cho cột Giá
        {
            if (dgvProduct.Columns[e.ColumnIndex].HeaderText == "Giá")
            {
                if (e.Value != null)
                {
                    e.CellStyle.Format = "#,###";
                }
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e) // Binding dữ liệu cho combobox nhà sản xuất và danh mục
        {
            if (dgvProduct.Rows.Count > 0)
            {
                ShopDbContext db = new ShopDbContext();
                long id = long.Parse(txbID.Text);

                Product pro = ProductDAO.Instance.GetProductById(id);

                string CateName = db.Categories.Where(x => x.ID == pro.CategoryID).Select(x => x.Name).SingleOrDefault();

                cbCateID.SelectedIndex = cbCateID.FindStringExact(CateName);

                string SuppName = db.Suppliers.Where(x => x.ID == pro.SupplierID).Select(x => x.Name).SingleOrDefault();

                cbSupplierId.SelectedIndex = cbSupplierId.FindStringExact(SuppName);
            }          
        }
        #endregion

        #region button
        private void btnProductAdd_Click(object sender, EventArgs e) // Nút thêm
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
                    product.CategoryID = long.Parse(cbCateID.SelectedValue.ToString());
                    product.SupplierID = long.Parse(cbSupplierId.SelectedValue.ToString());
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
            LoadGridView();
            SupplierStockSold();
            CategoryStockSold();
        }
        private void btnProductUpdate_Click(object sender, EventArgs e)// Nút cập nhật
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
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công.");
            }

            LoadGridView();
            SupplierStockSold();
            CategoryStockSold();
        }
        private void btnProductDelete_Click(object sender, EventArgs e)// Nút xóa
        {
            DialogResult Delete = MessageBox.Show("Xác nhận Xóa", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Delete == DialogResult.OK)
            {
                var result = ProductDAO.Instance.DeleteProduct(long.Parse(txbID.Text));
                if (result)
                {
                    MessageBox.Show("Xóa thành công.");
                }
                LoadGridView();
                SupplierStockSold();
                CategoryStockSold();
            }
            else
            {
                return;
            }
        }
        private void btnLoadProduct_Click(object sender, EventArgs e) // Nút xem
        {
            ShopDbContext db = new ShopDbContext();

            var query = from a in db.Categories
                        join b in db.Products
                        on a.ID equals b.CategoryID
                        join c in db.Suppliers
                        on b.SupplierID equals c.ID
                        select new
                        {
                            ID = b.ID,
                            Name = b.Name,
                            Price = b.Price,
                            Stock = b.Stock,
                            Sold = b.Sold,
                            CateName = a.Name,
                            SuppName = c.Name,
                            CreatedDate = b.CreatedDate,
                            ModifiedDate = b.ModifiedDate,
                            Status = b.Status
                        };

            ProductBinding.DataSource = query.ToList();

            CustomGridView();
        }

        private void btnProductFind_Click(object sender, EventArgs e)// Nút tìm kiếm
        {
            var list = ProductDAO.Instance.SearchProduct(txbProductFind.Text);
            ProductBinding.DataSource = list;
        }

        #endregion
    }
}
