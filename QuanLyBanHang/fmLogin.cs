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

        private void fmMain_Load(object sender, EventArgs e)
        {

        }

        private const string usernametxb = "Tên đăng nhập";
        private void UsernameTxb_GotFocus(object sender, EventArgs e)
        {
            UsernameTxb.Text = UsernameTxb.Text == usernametxb ? string.Empty : UsernameTxb.Text;
        }

        private void UsernameTxb_LostFocus(object sender, EventArgs e)
        {
            UsernameTxb.Text = UsernameTxb.Text == string.Empty ? usernametxb : UsernameTxb.Text;
        }


        private const string passwordtxb = "Mật khẩu";
        private void PasswordTxb_GotFocus(object sender, EventArgs e)
        {
            PasswordTxb.Text = PasswordTxb.Text == passwordtxb ? string.Empty : PasswordTxb.Text;
        }

        private void PasswordTxb_LostFocus(object sender, EventArgs e)
        {
            PasswordTxb.Text = PasswordTxb.Text == string.Empty ? passwordtxb : PasswordTxb.Text;
            PasswordTxb.UseSystemPasswordChar = true;
        }
    }
}
