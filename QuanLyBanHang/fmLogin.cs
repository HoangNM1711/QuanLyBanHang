using Database.EF.DAO;
using QuanLyBanHang.Common;
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
    public partial class fmLogin : MetroFramework.Forms.MetroForm
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        #region Event
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
            PasswordTxb.UseSystemPasswordChar = true;
            PasswordTxb.Text = PasswordTxb.Text == passwordtxb ? string.Empty : PasswordTxb.Text;
        }

        private void PasswordTxb_LostFocus(object sender, EventArgs e)
        {
            PasswordTxb.Text = PasswordTxb.Text == string.Empty ? passwordtxb : PasswordTxb.Text;
        }

        private void fmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Button
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var result = UserDAO.Instance.Login(UsernameTxb.Text, Encryptor.MD5Hash(PasswordTxb.Text));
            if (result == 1)
            {
                fmMain main = new fmMain();
                this.Hide();
                main.ShowDialog();
            }
            else if (result == 0)
            {
                MessageBox.Show("Tài khoản không tồn tại.");
            }
            else
            {
                MessageBox.Show("Sai mật khẩu");
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            fmRegister fm = new fmRegister();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }
        #endregion


    }
}
