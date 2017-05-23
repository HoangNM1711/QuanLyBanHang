using Database.EF.DAO;
using Database.EF.DTO;
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
    public partial class fmRegister : MetroFramework.Forms.MetroForm
    {
        public fmRegister()
        {
            InitializeComponent();
        }

        private void btnRegLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            var dao = new UserDAO();
            User user = new User();
            var result = dao.CheckUsername(txbRegUsername.Text);
            if (result == 1)
            {
                if (txbRegPassword.Text != txbRegPassword2.Text)
                {
                    MessageBox.Show("Mật khẩu không trùng nhau hãy nhập lại.");
                }
                else
                {
                    user.Username = txbRegUsername.Text;
                    user.Password = Encryptor.MD5Hash(txbRegPassword.Text);
                    user.Name = txbRegName.Text;
                    user.Address = txbRegAddress.Text;
                    user.Email = txbRegEmail.Text;
                    user.Phone = txbRegPhone.Text;
                    dao.Register(user);
                    MessageBox.Show("Đăng ký thành công hãy đăng nhập để sử dụng.");
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại.");
            }
        }

    }
}
