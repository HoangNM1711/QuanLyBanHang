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
    public partial class fmClean : MetroFramework.Forms.MetroForm
    {
        public fmClean()
        {
            InitializeComponent();
        }
        ShopDbContext db = new ShopDbContext();

        private void btnDCategory_Click(object sender, EventArgs e)
        {
            List<Category> list = db.Categories.Where(x => x.Status == "Ngưng bán").ToList();

            DialogResult Delete = MessageBox.Show("Xác nhận làm sạch Danh mục ngưng bán.", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Delete == DialogResult.OK)
            {
                foreach (var item in list)
                {
                    db.Categories.Remove(item);
                }

                db.SaveChanges();

                MessageBox.Show("Làm sạch hoàn tất.");
            }
            else
            {
                return;
            }
        }

        private void btnDSupplier_Click(object sender, EventArgs e)
        {
            List<Supplier> list = db.Suppliers.Where(x => x.Status == "Ngưng bán").ToList();

            DialogResult Delete = MessageBox.Show("Xác nhận làm sạch Nhà SX ngưng bán", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Delete == DialogResult.OK)
            {
                foreach (var item in list)
                {
                    db.Suppliers.Remove(item);
                }

                db.SaveChanges();

                MessageBox.Show("Làm sạch hoàn tất.");
            }
            else
            {
                return;
            }
        }

        private void btnDProduct_Click(object sender, EventArgs e)
        {
            List<Product> list = db.Products.Where(x => x.Status == "Ngưng bán").ToList();

            DialogResult Delete = MessageBox.Show("Xác nhận làm sạch Sản phẩm ngưng bán.", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Delete == DialogResult.OK)
            {
                foreach (var item in list)
                {
                    db.Products.Remove(item);
                }

                db.SaveChanges();

                MessageBox.Show("Làm sạch hoàn tất.");
            }
            else
            {
                return;
            }
        }

        private void btnDOrder_Click(object sender, EventArgs e)
        {
            List<OrderDetail> listOD = (from a in db.Orders
                                     join b in db.OrderDetails
                                     on a.ID equals b.OrderID
                                     where a.Status == "Hoàn tất"
                                     select b).ToList();

            List<Order> listOrder = db.Orders.Where(x => x.Status == "Hoàn tất").ToList();

            DialogResult Delete = MessageBox.Show("Xác nhận làm sạch Hóa đơn đã hoàn tất.", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Delete == DialogResult.OK)
            {
                foreach (Order order in listOrder)
                {
                    foreach (OrderDetail od in listOD)
                    {
                        db.OrderDetails.Remove(od);
                    }

                    db.Orders.Remove(order);
                }

                db.SaveChanges();

                MessageBox.Show("Làm sạch hoàn tất.");
            }
            else
            {
                return;
            }
        }
    }
}
