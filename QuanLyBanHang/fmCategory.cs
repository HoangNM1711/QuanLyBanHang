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
        }

        #region method

        void LoadComponent()
        {
            LoadGridView();
            AddBinding();
            CBStatus();
        }
        public void CustomGridView() // Thiết lập GridView
        {
            dgvCategory.DataSource = CategoryBinding;

            dgvCategory.Columns[1].HeaderText = "Loại SP";
            dgvCategory.Columns[2].HeaderText = "SL còn";
            dgvCategory.Columns[3].HeaderText = "SL bán";
            dgvCategory.Columns[4].HeaderText = "Ngày tạo";
            dgvCategory.Columns[5].HeaderText = "Ngày cập nhật";
            dgvCategory.Columns[6].HeaderText = "Trạng thái";

            dgvCategory.Columns[0].Width = 40;
            dgvCategory.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCategory.Columns[2].Width = 50;
            dgvCategory.Columns[3].Width = 50;
            dgvCategory.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCategory.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCategory.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            if (dgvCategory.Rows.Count > 0)
            {
                dgvCategory.Rows[0].Selected = true;
            }
        }
        public void LoadGridView() // Thiết lập dữ liệu GridView
        {
            CategoryBinding.DataSource = CategoryDAO.Instance.ListCategoryByStatus();
            CustomGridView();
        }
        public void CBStatus() // load dữ liệu cho combobox status
        {
            ShopDbContext db = new ShopDbContext();

            cbStatus.DataSource = db.Status.Where(x => x.ID == 1 || x.ID == 2 || x.ID == 3).Select(x => x.Status1).ToList();
            cbStatus.DisplayMember = "Status";
        }
        public void AddBinding() // Binding Data
        {
            txbID.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbCategoryName.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbStock.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "Stock", true, DataSourceUpdateMode.Never));
            txbSold.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "Sold", true, DataSourceUpdateMode.Never));
            cbStatus.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "Status", true, DataSourceUpdateMode.Never));
        }

        public bool CheckForm() // Validate Form
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
        private void fmCategory_Load(object sender, EventArgs e)
        {
            LoadComponent();
        }
        private void fmCategory_FormClosed(object sender, FormClosedEventArgs e) // Đóng form
        {
            this.Hide();
        }

        private const string find = "Từ khóa tìm kiếm"; // Event cho textbox tìm kiếm
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
                    cate.Stock = 0;
                    cate.Sold = 0;
                    cate.CreatedDate = DateTime.Now;
                    cate.Status = cbStatus.Text;

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
