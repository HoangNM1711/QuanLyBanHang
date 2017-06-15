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

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fmMain_FormClosed(object sender, FormClosedEventArgs e)
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

        private void chiTiếtĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmOrderDetail fm = new fmOrderDetail();
            fm.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmLogin fm = new fmLogin();
            fm.Show();
        }
    }
}
