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
    public partial class fmReport : MetroFramework.Forms.MetroForm
    {
        public fmReport()
        {
            InitializeComponent();
        }

        private void fmReport_Load(object sender, EventArgs e) 
        {
            ShopDbContext db = new ShopDbContext();

            var fromday = db.Orders.Where(x => x.Status == "Hoàn tất").OrderBy(x => x.ModifiedDate).Select(x => x.ModifiedDate).First();
            // set FromDay là ngày mà đơn hàng đầu tiên hoàn tất.
            dtpFromDay.Value = fromday.Value;
            dtpToDay.Value = DateTime.Now;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.OrderTableAdapter.Fill(this.ReportDataSet.Order, dtpFromDay.Value, dtpToDay.Value);
            this.rvReport.RefreshReport();
        }
    }
}
