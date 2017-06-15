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
    public partial class fmCategory : MetroFramework.Forms.MetroForm
    {
        BindingSource CategoryBinding = new BindingSource();
        public fmCategory()
        {
            InitializeComponent();
            LoadComponent();
        }

        #region method

        void LoadComponent()
        {
            LoadGridView();
            AddBinding();
            CustomCB();
        }
        public void CustomGridView() // Thiết lập GridView
        {
            CategoryGridView.DataSource = CategoryBinding;

            CategoryGridView.Columns[1].HeaderText = "Loại SP";
            CategoryGridView.Columns[2].HeaderText = "SL Tồn Kho";
            CategoryGridView.Columns[3].HeaderText = "SL Bán";
            CategoryGridView.Columns[4].HeaderText = "Ngày Tạo";
            CategoryGridView.Columns[5].HeaderText = "Ngày Sửa";
            CategoryGridView.Columns[6].HeaderText = "Trạng Thái";
        }
        public void LoadGridView() // Thiết lập dữ liệu GridView
        {
            CategoryBinding.DataSource = CategoryDAO.Instance.ListCategoryByStatus();
            CustomGridView();
        }        
        public void CustomCB() // Tạo Value cho combobox status
        {
            cbStatus.Items.Add("Đang bán");
            cbStatus.Items.Add("Ngưng bán");
        }
        public void AddBinding() // Binding Data
        {
            txbID.DataBindings.Add(new Binding("Text", CategoryGridView.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbCategoryName.DataBindings.Add(new Binding("Text", CategoryGridView.DataSource, "Name", true, DataSourceUpdateMode.Never));
            numberStock.DataBindings.Add(new Binding("Value", CategoryGridView.DataSource, "Stock", true, DataSourceUpdateMode.Never));
            numberSold.DataBindings.Add(new Binding("Value", CategoryGridView.DataSource, "Sold", true, DataSourceUpdateMode.Never));
            cbStatus.DataBindings.Add(new Binding("Text", CategoryGridView.DataSource, "Status", true, DataSourceUpdateMode.Never));
        }

        public bool CheckForm () // Validate Form
        {
            errorProvider.Clear();
            if (String.IsNullOrWhiteSpace(txbCategoryName.Text))
            {
                errorProvider.SetError(txbCategoryName, "Loại sản phẩm không được để trống");
                return false;
            }

            return true;
        }

        public void LoadListByStatus() // Làm mới danh sách theo Status
        {
            CategoryBinding.DataSource = CategoryDAO.Instance.ListCategoryByStatus();
        }
        #endregion

        #region event
        private void fmCategory_FormClosed(object sender, FormClosedEventArgs e) // Đóng form
        {
            this.Hide();
        }

        private const string find = "Từ khóa tìm kiếm" ; // Event cho textbox tìm kiếm
        private void txbCategoryFind_GotFocus(object sender, EventArgs e)
        {
            txbCategoryFind.Text = txbCategoryFind.Text == find ? string.Empty : txbCategoryFind.Text;
        }

        private void txbCategoryFind_LostFocus(object sender, EventArgs e)
        {
            txbCategoryFind.Text = txbCategoryFind.Text == string.Empty ? find : txbCategoryFind.Text;
        }
        #endregion

        #region button
        private void btnCategoryAdd_Click(object sender, EventArgs e) // Nút thêm
        {
            if (CheckForm())
            {
                Category cate = new Category();
                var result = CategoryDAO.Instance.CheckCategory(txbCategoryName.Text);
                if (result == 1)
                {
                    cate.Name = txbCategoryName.Text;
                    cate.Stock = (int)numberStock.Value;
                    cate.Sold = (int)numberSold.Value;
                    cate.CreatedDate = DateTime.Now;
                    if ((int)numberStock.Value == 0)
                    {
                        cate.Status = "Hết hàng";
                    }
                    else
                    {
                        cate.Status = cbStatus.Text;
                    }
                    CategoryDAO.Instance.AddCategory(cate);

                    MessageBox.Show("Thêm loại sản phẩm thành công.");
                }
                else
                {
                    MessageBox.Show("Loại sản phẩm đã tồn tại.");
                }
            }           
            else
            {
                MessageBox.Show("Thêm sản phẩm không thành công");
            }
            LoadListByStatus();
        }


        private void btnCategoryUpdate_Click(object sender, EventArgs e) // Nút Cập nhật
        {
            if (CheckForm())
            {
                var category = CategoryDAO.Instance.GetCategoryById(long.Parse(txbID.Text));
                if (CategoryDAO.Instance.CheckCategory(txbCategoryName.Text) == 1)
                {
                    category.Name = txbCategoryName.Text;
                    category.Stock = (int)numberStock.Value;
                    category.Sold = (int)numberSold.Value;
                    category.Status = cbStatus.Text;
                    category.ModifiedDate = DateTime.Now;

                    var result = CategoryDAO.Instance.UpdateCategory(category);
                    if (result)
                    {
                        MessageBox.Show("Cập nhật thành công.");
                    }
                }
                else
                {
                    category.Stock = (int)numberStock.Value;
                    category.Sold = (int)numberSold.Value;
                    category.Status = cbStatus.Text;
                    category.ModifiedDate = DateTime.Now;

                    var result = CategoryDAO.Instance.UpdateCategory(category);
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

            LoadListByStatus();
        }
        private void btnCategoryDelete_Click(object sender, EventArgs e) // Nút Xóa
        {
            DialogResult Delete = MessageBox.Show("Xác nhận Xóa", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Delete == DialogResult.OK)
            {
                var category = CategoryDAO.Instance.GetCategoryById(long.Parse(txbID.Text));
                var result = CategoryDAO.Instance.DeleteCategory(category.ID);
                if (result)
                {
                    MessageBox.Show("Xóa thành công.");
                }
                LoadListByStatus();
            }
            else
            {
                return;
            }
        }
        private void btnCategoryFind_Click(object sender, EventArgs e) // Nút tìm kiếm
        {
            var list = CategoryDAO.Instance.SearchCategory(txbCategoryFind.Text);
            CategoryBinding.DataSource = list;
        }

        private void btnLoad_Click(object sender, EventArgs e) // Refresh dữ liệu
        {
            ShopDbContext db = new ShopDbContext();
            CategoryBinding.DataSource = db.Categories.ToList();
        }
        #endregion
    }
}
