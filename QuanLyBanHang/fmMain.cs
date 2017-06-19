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
    public partial class fmMain : MetroFramework.Forms.MetroForm
    {
        public fmMain()
        {
            InitializeComponent();
        }
        #region Method
        private string DayExchange(string Day) // Hiện ngày hiện tại
        {
            string day = "";
            switch (Day)
            {
                case "Monday":
                    day = "Thứ hai";
                    break;
                case "Tuesday":
                    day = "Thứ ba";
                    break;
                case "Wednesday":
                    day = "Thứ tư";
                    break;
                case "Thursday":
                    day = "Thứ năm";
                    break;
                case "Friday":
                    day = "Thứ sáu";
                    break;
                case "Saturday":
                    day = "Thứ bảy";
                    break;
                default:
                    day = "Chủ nhật";
                    break;
                
            }
            return day;
        }

        private void Time_Tick(object sender, EventArgs e) // Hiện giờ hiện tại
        {
            lblTime.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
        }
        #endregion

        #region Event
        private void fmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void fmMain_Load(object sender, EventArgs e)
        {
            lblDay.Text = DayExchange(DateTime.Now.DayOfWeek.ToString()) + ", " + DateTime.Now.Day.ToString() + "/" 
                                        + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
        }
        #endregion

        #region Button
        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmCategory fm = new fmCategory();
            fm.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmProduct fm = new fmProduct();
            fm.Show();
        }
        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmSupplier fm = new fmSupplier();
            fm.Show();
        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmOrder fm = new fmOrder();
            fm.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmLogin fm = new fmLogin();
            fm.Show();
        }


        #endregion


    }
}
