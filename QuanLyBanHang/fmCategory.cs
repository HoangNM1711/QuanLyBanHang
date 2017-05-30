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
        BindingSource CategoryList = new BindingSource();
        public fmCategory()
        {
            InitializeComponent();
            LoadComponent();
        }

        #region method

        void LoadComponent()
        {
            LoadListCategory();
            CategoryBinding();
        }
        void LoadListCategory()
        {
            CategoryGridView.DataSource = CategoryList;
            CategoryList.DataSource = CategoryDAO.Instance.ListAllCategory();
            CategoryGridView.Columns[1].HeaderText = "Loại SP";
            CategoryGridView.Columns[2].HeaderText = "SL Tồn Kho";
            CategoryGridView.Columns[3].HeaderText = "SL Bán";
            CategoryGridView.Columns[4].HeaderText = "Ngày Tạo";
            CategoryGridView.Columns[5].HeaderText = "Ngày Sửa";
            CategoryGridView.Columns[6].HeaderText = "Trạng Thái";
        }

        void CategoryBinding()
        {
            txbID.DataBindings.Add(new Binding("Text", CategoryGridView.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbCategoryName.DataBindings.Add(new Binding("Text", CategoryGridView.DataSource, "Name", true, DataSourceUpdateMode.Never));
            numberStock.DataBindings.Add(new Binding("Value", CategoryGridView.DataSource, "Stock", true, DataSourceUpdateMode.Never));
            numberSold.DataBindings.Add(new Binding("Value", CategoryGridView.DataSource, "Sold", true, DataSourceUpdateMode.Never));
            cbStatus.DataBindings.Add(new Binding("Text", CategoryGridView.DataSource, "Status", true, DataSourceUpdateMode.Never));
        }

        #endregion

        #region event
        private void fmCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private const string txbcategoryfind = "Từ khóa tìm kiếm";
        private void txbCategoryFind_GotFocus(object sender, EventArgs e)
        {
            txbCategoryFind.Text = txbCategoryFind.Text == txbcategoryfind ? string.Empty : txbCategoryFind.Text;
        }

        private void txbCategoryFind_LostFocus(object sender, EventArgs e)
        {
            txbCategoryFind.Text = txbCategoryFind.Text == string.Empty ? txbcategoryfind : txbCategoryFind.Text;
        }
        #endregion

        #region button
        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            Category cate = new Category();

            var result = CategoryDAO.Instance.CheckCategory(txbCategoryName.Text);
            if (result == 1)
            {
                cate.Name = txbCategoryName.Text;
                cate.Stock = (int)numberStock.Value;
                cate.Sold = (int)numberSold.Value;
                cate.CreatedDate = DateTime.Now;
                cate.Status = cbStatus.Text;
                CategoryDAO.Instance.AddCategory(cate);

                MessageBox.Show("Thêm loại sản phẩm thành công.");
            }
            else
            {
                MessageBox.Show("Loại sản phẩm đã tồn tại.");
            }
            LoadListCategory();
        }


        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            var category = CategoryDAO.Instance.GetCategoryById(long.Parse(txbID.Text));
            category.Stock = (int)numberStock.Value;
            category.Sold = (int)numberSold.Value;
            category.ModifiedDate = DateTime.Now;
            category.Status = cbStatus.Text;

            var result = CategoryDAO.Instance.UpdateCategory(category);
            if (result)
            {
                MessageBox.Show("Cập nhật thành công.");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công.");
            }

            LoadListCategory();
        }
        private void btnCategoryDelete_Click(object sender, EventArgs e)
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
                LoadListCategory();
            }

            else
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }
        }
        private void btnCategoryFind_Click(object sender, EventArgs e)
        {
            var list = CategoryDAO.Instance.SearchCategory(txbCategoryFind.Text);
            CategoryList.DataSource = list;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            CategoryGridView.DataSource = CategoryDAO.Instance.ListAllCategory();
        }
        #endregion
    }
}
