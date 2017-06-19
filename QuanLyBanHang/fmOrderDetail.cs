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
    public partial class fmOrderDetail : MetroFramework.Forms.MetroForm
    {
        BindingSource ODBinding = new BindingSource();
        public Order order { get; set; }

        public fmOrderDetail()
        {
            InitializeComponent();
        }
        public fmOrderDetail(Order od)
        {
            InitializeComponent();
            order = od;
        }
        #region Method
        public void LoadComponent()
        {
            LoadGridView();
            CBProductID();
            AddBinding();
        }
        public void LoadGridView()
        {
          
            LoadOrderDetailById();
            CustomGridView();
        }

        public void CustomGridView()
        {
            dgvOrderDetail.DataSource = ODBinding;

            dgvOrderDetail.Columns[1].HeaderText = "Mã SP";
            dgvOrderDetail.Columns[2].HeaderText = "Tên SP";
            dgvOrderDetail.Columns[3].HeaderText = "Mã đơn hàng";
            dgvOrderDetail.Columns[4].HeaderText = "Số lượng";
            dgvOrderDetail.Columns[5].HeaderText = "Thành tiền";
            dgvOrderDetail.Columns[6].HeaderText = "Ngày tạo";
            dgvOrderDetail.Columns[7].HeaderText = "Ngày cập nhật";

            if (dgvOrderDetail.Rows.Count > 0)
            {
                dgvOrderDetail.Rows[0].Selected = true;
            }
        }

        public void CBProductID()
        {
            cbProductID.DataSource = ProductDAO.Instance.ListProductByStatus();
            cbProductID.DisplayMember = "Name";
            cbProductID.ValueMember = "ID";
        }

        public void AddBinding()
        {
            txbID.DataBindings.Add("Text", dgvOrderDetail.DataSource, "ID", true, DataSourceUpdateMode.Never);           
            cbProductID.DataBindings.Add("SelectedValue", dgvOrderDetail.DataSource, "ProductID", true, DataSourceUpdateMode.Never);
            numQuantity.DataBindings.Add("Value", dgvOrderDetail.DataSource, "Quantity", true, DataSourceUpdateMode.Never);
            txbTotalPrice.DataBindings.Add("Text", dgvOrderDetail.DataSource, "Price", true, DataSourceUpdateMode.Never);
        }
        public bool CheckForm()
        {
            errorProvider.Clear();
            if (String.IsNullOrWhiteSpace(cbProductID.Text))
            {
                errorProvider.SetError(cbProductID, "Hãy chọn sản phẩm.");
                return false;
            }

            try
            {
                int Quantity = int.Parse(numQuantity.Value.ToString());
                if (Quantity < 0)
                {
                    errorProvider.SetError(numQuantity, "Số lượng phải lớn hơn 0.");
                    return false;
                }
                else
                {
                    errorProvider.Clear();
                }
                
            }
            catch(Exception e)
            {
                errorProvider.SetError(numQuantity, e.Message);
                return false;
            }
            return true;
        }

        public void LoadOrderDetailById()
        {
            ShopDbContext db = new ShopDbContext();

            var query = from a in db.Products
                        join b in db.OrderDetails
                        on a.ID equals b.ProductID
                        select new
                        {
                            ID = b.ID,
                            ProductID = b.ProductID,
                            TenSP = a.Name,
                            OrderID = b.OrderID,
                            Quantity = b.Quantity,
                            Price = b.Price,
                            CreatedDate = b.CreatedDate,
                            ModifiedDate = b.ModifiedDate,
                        };

            ODBinding.DataSource = query.Where(x => x.OrderID == order.ID).ToList();
        }
        public void TotalPrice()
        {
            ShopDbContext db = new ShopDbContext();

            var total = db.OrderDetails.Where(x => x.OrderID == order.ID).Select(x => x.Price).Sum();

            var od = OrderDAO.Instance.GetOrderById(order.ID);
            od.TotalPrice = decimal.Parse(total.ToString());

            OrderDAO.Instance.UpdatePrice(od);
        }

        #endregion

        #region Event
        private void fmOrderDetail_Load(object sender, EventArgs e)
        {
            LoadComponent();

            txbOrderId.Text = order.ID.ToString();
        }
        private void cbProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShopDbContext db = new ShopDbContext();

            var price = db.Products.Where(x => x.Name == cbProductID.Text).Select(x => x.Price).SingleOrDefault();

            txbPrice.Text = String.Format("{0:#,###0}", price);
        }      
        #endregion

        #region Button
        private void btnOrderAdd_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                OrderDetail od = new OrderDetail();
                od.OrderID = order.ID;
                od.ProductID = long.Parse(cbProductID.SelectedValue.ToString());
                od.Quantity = (int)numQuantity.Value;
                od.Price = Convert.ToDecimal(txbPrice.Text) * numQuantity.Value;
                od.CreatedDate = DateTime.Now;

                OrderDetailDAO.Instance.AddOrderDetail(od);

                MessageBox.Show("Thêm sản phẩm vào hóa đơn thành công.");
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm vào hóa đơn không thành công.");
            }
            TotalPrice();
            LoadOrderDetailById();
        }

        private void btnOrderUpdate_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                var OD = OrderDetailDAO.Instance.GetOrderDetailById(long.Parse(txbID.Text));

                OD.ProductID = long.Parse(cbProductID.SelectedValue.ToString());
                OD.Quantity = (int)numQuantity.Value;
                OD.Price = Convert.ToDecimal(txbPrice.Text) * numQuantity.Value;
                OD.ModifiedDate = DateTime.Now;

                var result = OrderDetailDAO.Instance.UpdateOrderDetail(OD);

                if (result)
                {
                    MessageBox.Show("Cập nhật thành công.");
                }
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công.");
            }

            TotalPrice();
            LoadOrderDetailById();
        }
        private void btnOrderDelete_Click(object sender, EventArgs e)
        {
            DialogResult Delete = MessageBox.Show("Xác nhận Xóa", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Delete == DialogResult.OK)
            {
                var result = OrderDetailDAO.Instance.DeleteOrderDetail(long.Parse(txbID.Text));
                if (result)
                {
                    MessageBox.Show("Xóa thành công.");
                }
                TotalPrice();
                LoadOrderDetailById();
            }
            else
            {
                return;
            }
        }
        private void btnOrderLoad_Click(object sender, EventArgs e)
        {
            ODBinding.DataSource = OrderDetailDAO.Instance.ListProductByOrderId(order.ID);
        }

        #endregion
    }
}
