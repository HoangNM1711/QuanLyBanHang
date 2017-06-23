using Database.EF.DAO;
using Database.EF.DTO;
using QuanLyBanHang.Common;
using System;
using System.ComponentModel.DataAnnotations;
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
        #region Method

        public bool CheckForm() // Validate Form
        {
            errorProvider.Clear();

            if (String.IsNullOrWhiteSpace(txbRegName.Text))
            {
                errorProvider.SetError(txbRegName, "Tên đăng nhập không được để trống.");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txbRegPassword.Text))
            {
                errorProvider.SetError(txbRegPassword, "Mật khẩu không được để trống.");
                return false;
            }

            if (txbRegEmail.Text != null)
            {
                var checkEmail = new EmailAddressAttribute();
                if (!checkEmail.IsValid(txbRegEmail.Text))
                {
                    errorProvider.SetError(txbRegEmail, "Email không đúng định dạng.");
                    return false;
                }
            }

            return true;
        }
        #endregion
        private void btnReg_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                User user = new User();
                var result = UserDAO.Instance.CheckUsername(txbRegUsername.Text);
                if (result == 1)
                {
                    if (txbRegPassword.Text != txbRegPassword2.Text)
                    {
                        MessageBox.Show("Mật khẩu không trùng nhau hãy nhập lại.");
                    }
                    else
                    {
                        user.Username = txbRegUsername.Text;
                        user.Password = Encryptor.EncryptorPassword(txbRegPassword.Text);
                        user.Name = txbRegName.Text;
                        user.Address = txbRegAddress.Text;
                        user.Email = txbRegEmail.Text;
                        user.Phone = txbRegPhone.Text;
                        UserDAO.Instance.Register(user);
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
}
