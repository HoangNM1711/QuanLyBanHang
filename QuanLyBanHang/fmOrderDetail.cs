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
using Excel = Microsoft.Office.Interop.Excel;
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
            CBCategory();
            AddBinding();
        }
        public void LoadGridView()
        {

            LoadOrderDetailById();
            CustomGridView();
        }

        public void CustomGridView() // config datagridview
        {
            dgvOrderDetail.DataSource = ODBinding;
            dgvOrderDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvOrderDetail.Columns[1].HeaderText = "Mã SP";
            dgvOrderDetail.Columns[2].HeaderText = "Tên SP";
            dgvOrderDetail.Columns[3].HeaderText = "Mã ĐH";
            dgvOrderDetail.Columns[4].HeaderText = "Số lượng";
            dgvOrderDetail.Columns[5].HeaderText = "Giá";
            dgvOrderDetail.Columns[6].HeaderText = "Thành tiền";
            dgvOrderDetail.Columns[7].HeaderText = "Ngày tạo";
            dgvOrderDetail.Columns[8].HeaderText = "Ngày cập nhật";

            dgvOrderDetail.Columns[0].Width = 40;
            dgvOrderDetail.Columns[1].Width = 60;
            dgvOrderDetail.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvOrderDetail.Columns[3].Width = 80;
            dgvOrderDetail.Columns[4].Width = 80;
            dgvOrderDetail.Columns[5].Width = 100;
            dgvOrderDetail.Columns[6].Width = 100;
            dgvOrderDetail.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvOrderDetail.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            if (dgvOrderDetail.Rows.Count > 0)
            {
                dgvOrderDetail.Rows[0].Selected = true;
            }
        }

        public void CBCategory() //Load combobox Danh mục
        {
            cbCategory.DataSource = CategoryDAO.Instance.ListCategoryByStatus();
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "ID";

            cbCategory.DropDownHeight = cbCategory.ItemHeight * 5;
        }

        public void AddBinding() // Binding dữ liệu
        {
            txbID.DataBindings.Add(new Binding("Text", dgvOrderDetail.DataSource, "ID", true, DataSourceUpdateMode.Never));
            cbProductID.DataBindings.Add(new Binding("SelectedValue", dgvOrderDetail.DataSource, "ProductID", true, DataSourceUpdateMode.Never));
            numQuantity.DataBindings.Add(new Binding("Value", dgvOrderDetail.DataSource, "Quantity", true, DataSourceUpdateMode.Never));
            txbTotalPrice.DataBindings.Add(new Binding("Text", dgvOrderDetail.DataSource, "Price", true, DataSourceUpdateMode.Never));
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
                var Quantity = numQuantity.Value;
                if (Quantity <= 0)
                {
                    errorProvider.SetError(numQuantity, "Số lượng phải lớn hơn 0.");
                    return false;
                }
                else
                {
                    errorProvider.Clear();
                }

            }
            catch (Exception e)
            {
                errorProvider.SetError(numQuantity, e.Message);
                return false;
            }
            return true;
        } // Validate Form

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
                            Price = a.Price,
                            TotalPrice = b.Price,
                            CreatedDate = b.CreatedDate,
                            ModifiedDate = b.ModifiedDate,
                        };

            ODBinding.DataSource = query.Where(x => x.OrderID == order.ID).ToList();
        } //Load OrderDetail
        public void TotalPrice() // Cập nhật thành tiền bên Order
        {
            ShopDbContext db = new ShopDbContext();

            var total = db.OrderDetails.Where(x => x.OrderID == order.ID).Select(x => x.Price);
            if (total.Sum() == null)
            {
                var od = OrderDAO.Instance.GetOrderById(order.ID);
                od.TotalPrice = 0;
                od.ModifiedDate = DateTime.Now;

                OrderDAO.Instance.UpdatePrice(od);
            }
            else
            {
                var od = OrderDAO.Instance.GetOrderById(order.ID);
                od.TotalPrice = decimal.Parse(total.Sum().ToString());
                od.ModifiedDate = DateTime.Now;

                OrderDAO.Instance.UpdatePrice(od);
            }
        }

        public bool QuantityChangeAdd() // Cập nhật số lượng tồn kho và bán bên Product khi thêm
        {
            long productID = long.Parse(cbProductID.SelectedValue.ToString());
            Product pro = ProductDAO.Instance.GetProductById(productID);


            if (pro.Stock > numQuantity.Value)
            {
                pro.Stock = pro.Stock - (int)numQuantity.Value;
                pro.Sold = pro.Sold + (int)numQuantity.Value;
                pro.ModifiedDate = DateTime.Now;

                ProductDAO.Instance.UpdateQuantity(pro);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool QuantityChangeUpdate() // Cập nhật số lượng tồn kho và bán bên Product khi cập nhật
        {

            decimal quantityChange = 0;
            long id = long.Parse(txbID.Text);
            long productID = long.Parse(cbProductID.SelectedValue.ToString());

            ShopDbContext db = new ShopDbContext();
            Product pro = ProductDAO.Instance.GetProductById(productID);
            OrderDetail orderdetail = OrderDetailDAO.Instance.GetOrderDetailById(id);

            if (orderdetail.Quantity < numQuantity.Value)
            {
                quantityChange = numQuantity.Value - orderdetail.Quantity;
                if (pro.Stock > quantityChange)
                {
                    pro.Stock = pro.Stock - int.Parse(quantityChange.ToString());
                    pro.Sold = pro.Sold + int.Parse(quantityChange.ToString());
                    pro.ModifiedDate = DateTime.Now;
                }
                else
                    return false;

                ProductDAO.Instance.UpdateQuantity(pro);

                return true;
            }

            if (orderdetail.Quantity > numQuantity.Value)
            {
                quantityChange = orderdetail.Quantity - numQuantity.Value;

                pro.Stock = pro.Stock + int.Parse(quantityChange.ToString());
                pro.Sold = pro.Sold - int.Parse(quantityChange.ToString());
                pro.ModifiedDate = DateTime.Now;

                ProductDAO.Instance.UpdateQuantity(pro);

                return true;
            }
            return true;
        }


        public void QuantityChangeDelete() // Cập nhật số lượng tồn kho và bán bên Product khi xóa
        {
            long productID = long.Parse(cbProductID.SelectedValue.ToString());
            long id = long.Parse(txbID.Text);

            Product pro = ProductDAO.Instance.GetProductById(productID);
            OrderDetail od = OrderDetailDAO.Instance.GetOrderDetailById(id);

            pro.Stock = pro.Stock + od.Quantity;
            pro.Sold = pro.Sold - od.Quantity;
            pro.ModifiedDate = DateTime.Now;

            ProductDAO.Instance.UpdateQuantity(pro);
        }

        public void ExportExcel()
        {
            ShopDbContext db = new ShopDbContext();
            // Khởi tạo Excel
            Excel.Application app = new Excel.Application();
            // Khởi tạo WorkBook
            Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            // Khởi tạo WorkSheet
            Excel.Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            // Export dữ liệu
            worksheet.Cells[1, 1] = "Bảng chi tiết hóa đơn";
            worksheet.Cells[3, 2] = "Hóa đơn số: " + txbOrderId.Text;
            worksheet.Cells[4, 2] = "Tên khách hàng: " + order.CustomerName;
            worksheet.Cells[5, 2] = "Địa chỉ: " + order.CustomerAddress;
            worksheet.Cells[6, 2] = "SĐT: " + order.CustomerPhone;
            worksheet.Cells[7, 2] = "Email: " + order.CustomerEmail;
            worksheet.Cells[8, 2] = "Ngày tạo: " + order.CreatedDate;

            worksheet.Cells[10, 1] = "STT";
            worksheet.Cells[10, 2] = "Mã SP";
            worksheet.Cells[10, 3] = "Tên SP";
            worksheet.Cells[10, 4] = "Mã HĐ";
            worksheet.Cells[10, 5] = "SL";
            worksheet.Cells[10, 6] = "Giá";
            worksheet.Cells[10, 7] = "Thành tiền";

            var Total = 0;
            int row = dgvOrderDetail.RowCount;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    worksheet.Cells[i + 11, 1] = i + 1;
                    worksheet.Cells[i + 11, j + 2] = dgvOrderDetail.Rows[i].Cells[j + 1].Value;
                }
                Total += Convert.ToInt32(dgvOrderDetail.Rows[i].Cells[6].Value);
            }

            worksheet.Cells[row + 11, 1] = "Tổng số tiền cần thanh toán: ";
            worksheet.Cells[row + 11, 7] = Total;

            // Đinh dạng trang
            worksheet.PageSetup.Orientation = Excel.XlPageOrientation.xlPortrait;
            worksheet.PageSetup.PaperSize = Excel.XlPaperSize.xlPaperA4;
            worksheet.PageSetup.LeftMargin = 0;
            worksheet.PageSetup.RightMargin = 0;
            worksheet.PageSetup.TopMargin = 0;
            worksheet.PageSetup.BottomMargin = 0;
            //Định dạng cột
            worksheet.Range["A1"].ColumnWidth = 5.29;
            worksheet.Range["B1"].ColumnWidth = 7.43;
            worksheet.Range["C1"].EntireColumn.AutoFit();
            worksheet.Range["D1"].ColumnWidth = 9.43;
            worksheet.Range["E1"].ColumnWidth = 3.71;
            worksheet.Range["F1"].EntireColumn.AutoFit();
            worksheet.Range["G1"].EntireColumn.AutoFit();
            // Font chữ
            worksheet.Range["A1", "G40"].Font.Name = "Times New Roman";
            worksheet.Range["A1", "G40"].Font.Size = 14;
            worksheet.Range["A1", "G1"].MergeCells = true;
            worksheet.Range["A1", "G1"].Font.Bold = true;
            worksheet.Range["A1", "G1"].Font.Size = 16;
            worksheet.Range["A10", "G10"].Font.Bold = true;
            worksheet.Range["A" + (row + 11), "F" + (row + 11)].MergeCells = true;
            worksheet.Range["A" + (row + 11), "F" + (row + 11)].Font.Bold = true;
            worksheet.Range["A" + (row + 11), "F" + (row + 11)].Font.Size = 16;
            //Border
            worksheet.Range["A10", "G" + (row + 11)].Borders.LineStyle = 1;
            //Align Text
            worksheet.Range["A1", "G1"].HorizontalAlignment = 3;
            worksheet.Range["A10", "G10"].HorizontalAlignment = 3;
            worksheet.Range["A1", "A" + (row + 10)].HorizontalAlignment = 3;
            worksheet.Range["B10", "B" + (row + 10)].HorizontalAlignment = 3;
            worksheet.Range["D1", "D" + (row + 10)].HorizontalAlignment = 3;
            worksheet.Range["E1", "E" + (row + 10)].HorizontalAlignment = 3;
            worksheet.Range["A" + (row + 11), "F" + (row + 11)].HorizontalAlignment = 3;

            worksheet.Range["F11", "F" + (row + 10)].NumberFormat = "#,###";
            worksheet.Range["G11", "F" + (row + 11)].NumberFormat = "#,###";
        } // Xuất file Exel
        #endregion

        #region Event
        private void fmOrderDetail_Load(object sender, EventArgs e) // Event load form
        {
            LoadComponent();

            txbOrderId.Text = order.ID.ToString();
        }

        private const string find = "Từ khóa tìm kiếm"; // event txb tìm kiếm
        private void txbODFind_GotFocus(object sender, EventArgs e)
        {
            txbODFind.Text = txbODFind.Text == find ? string.Empty : txbODFind.Text;
        }

        private void txbODFind_LostFocus(object sender, EventArgs e)
        {
            txbODFind.Text = txbODFind.Text == string.Empty ? find : txbODFind.Text;
        }

        private void cbProductID_SelectedIndexChanged(object sender, EventArgs e) // Load giá tiền sản phẩm lên textbox
        {
            ShopDbContext db = new ShopDbContext();

            var price = db.Products.Where(x => x.Name == cbProductID.Text).Select(x => x.Price).SingleOrDefault();

            txbPrice.Text = String.Format("{0:#,###0}", price);
        }

        private void dgvOrderDetail_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) // Set display format cho cột thành tiền
        {
            if (dgvOrderDetail.Columns[e.ColumnIndex].HeaderText == "Thành tiền" || dgvOrderDetail.Columns[e.ColumnIndex].HeaderText == "Giá")
            {
                if (e.Value != null)
                {
                    e.CellStyle.Format = "#,###";
                }
            }
        }
        private void txbTotalPrice_TextChanged(object sender, EventArgs e) // format cho textbox thành tiền
        {
            if (!String.IsNullOrEmpty(txbID.Text))
            {
                ShopDbContext db = new ShopDbContext();

                long id = long.Parse(txbID.Text);
                var price = db.OrderDetails.Where(x => x.ID == id).Select(x => x.Price).SingleOrDefault();

                txbTotalPrice.Text = String.Format("{0:#,###0}", price);
            }
        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e) // Load sản phẩm theo danh mục
        {

            ShopDbContext db = new ShopDbContext();

            var query = from a in db.Products
                        join b in db.Categories
                        on a.CategoryID equals b.ID
                        where b.Name == cbCategory.Text
                        select new
                        {
                            ID = a.ID,
                            Name = a.Name
                        };

            cbProductID.DataSource = query.ToList();
            cbProductID.DisplayMember = "Name";
            cbProductID.ValueMember = "ID";

            cbProductID.DropDownHeight = cbProductID.ItemHeight * 5;
        }

        private void dgvOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)  // Binding sản phẩm theo danh mục
        {
            if (dgvOrderDetail.Rows.Count > 0)
            {

                ShopDbContext db = new ShopDbContext();

                long id = long.Parse(txbID.Text);
                var od = OrderDetailDAO.Instance.GetOrderDetailById(id);

                string name = (from a in db.Products
                               join b in db.Categories
                               on a.CategoryID equals b.ID
                               where a.ID == od.ProductID
                               select b.Name).SingleOrDefault();

                cbCategory.SelectedIndex = cbCategory.FindStringExact(name);
            }
        }
        #endregion

        #region Button
        private void btnOrderAdd_Click(object sender, EventArgs e) // Nút thêm
        {
            if (CheckForm())
            {
                if (QuantityChangeAdd())

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
                    MessageBox.Show("Số lượng tồn kho không đủ.");
                }
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm vào hóa đơn không thành công.");
            }
            TotalPrice();
            LoadOrderDetailById();
        }

        private void btnOrderUpdate_Click(object sender, EventArgs e) // Nút cập nhật
        {
            if (CheckForm())
            {
                if (QuantityChangeUpdate())
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
                    MessageBox.Show("Số lượng tồn kho không đủ.");
                }
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công.");
            }

            TotalPrice();
            LoadOrderDetailById();
        }
        private void btnOrderDelete_Click(object sender, EventArgs e) // Nút Xóa
        {
            DialogResult Delete = MessageBox.Show("Xác nhận Xóa", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Delete == DialogResult.OK)
            {
                QuantityChangeDelete();
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
        private void btnOrderLoad_Click(object sender, EventArgs e) // Nút Xem
        {
            ODBinding.DataSource = OrderDetailDAO.Instance.ListProductByOrderId(order.ID);
        }
        private void btnODFind_Click(object sender, EventArgs e) // Nút tìm kiếm
        {
            var list = ProductDAO.Instance.SearchProduct(txbODFind.Text);
            ODBinding.DataSource = list;
        }
        private void btnExport_Click(object sender, EventArgs e) // Xuất file Excel
        {
            ExportExcel();
        }
        #endregion

    }
}
