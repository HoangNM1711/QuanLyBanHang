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
    public partial class fmProduct : MetroFramework.Forms.MetroForm
    {
        public fmProduct()
        {
            InitializeComponent();
        }

        #region method
        #endregion

        #region event
        private void fmProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        #endregion

        #region button
        private void btnAdd_Click(object sender, EventArgs e)
        {
             Product product = new Product();

            var result = ProductDAO.Instance.CheckProduct(txbProductName.Text);
            if (result == 1)
            {
                product.Name = txbProductName.Text;
                product.Quantity = (int)numberStock.Value;
                product.Sold = (int)numberSold.Value;
                product.CategoryID = long.Parse(cbProductId.Text);
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

        #endregion
    }
}
