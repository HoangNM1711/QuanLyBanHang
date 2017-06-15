using CheckConnectWCF;
using QuanLyBanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckConnectWCF
{
    public partial class fmWaiting : MetroFramework.Forms.MetroForm
    {
        public fmWaiting()
        {
            InitializeComponent();
        }

        public static bool checkConnection = true;

        #region Method
        public void CheckConn()
        {
            QuanLyBanHang.WaitingService.ConnectionClient Client = new QuanLyBanHang.WaitingService.ConnectionClient();

            checkConnection = Client.IsAlive();
        }
        #endregion

        #region Event
        private void fmWaiting_Load(object sender, EventArgs e)
        {
            timerChecking.Start();

            backgroundWorking.RunWorkerAsync();
        }

        private void backgroundWorking_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pgbWaiting.Value = pgbWaiting.Maximum;
        }
        private void backgroundWorking_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                CheckConn();
            }
            catch(Exception ex)
            {
                timerChecking.Stop();
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void timerChecking_Tick(object sender, EventArgs e)
        {
            if (checkConnection == false)
            {
                if (pgbWaiting.Value == 100)
                {
                    timerChecking.Stop();
                    backgroundWorking.WorkerSupportsCancellation = true;
                    backgroundWorking.CancelAsync();
                    MessageBox.Show("Kết nối với máy chủ không thành công");
                    this.Close();
                }
                else
                {
                    pgbWaiting.Increment(10);
                }
            }
            else
            {
                fmLogin fm = new fmLogin();
                fm.Show();
                this.Hide();
                timerChecking.Stop();
                MessageBox.Show("Chào mừng đến với phần mềm Quản lý bán hàng");
            }
        }


        #endregion


    }
}
