
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebService
{
    public partial class fmSplash : MetroFramework.Forms.MetroForm
    {
        public fmSplash()
        {
            InitializeComponent();
        }

        public static bool checkConnection = false;

        private void fmSplash_Load(object sender, EventArgs e)
        {
            timerCheck.Start();

            backgroundWorking.RunWorkerAsync();
        }

        public void CheckConnection()
        {
            WebService.IWaiting connection = new WebService.Waiting();
            checkConnection = connection.IsConnected;
        }
    }
}
