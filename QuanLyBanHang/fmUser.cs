using Database.EF.DAO;
using Database.EF.DTO;
using QuanLyBanHang.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class fmUser : MetroFramework.Forms.MetroForm
    {
        public User user { get; set; }
        public fmUser()
        {
            InitializeComponent();
        }

        public fmUser(User us)
        {
            InitializeComponent();
            user = us;
        }

        #region Method
        public bool CheckForm() // Validate Form
        {
            errorProvider.Clear();

            if (String.IsNullOrWhiteSpace(txbUsername.Text))
            {
                errorProvider.SetError(txbUsername, "Tên đăng nhập không được để trống.");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txbPassword.Text))
            {
                errorProvider.SetError(txbPassword, "Mật khẩu không được để trống.");
                return false;
            }

            if (txbEmail.Text != null)
            {
                var checkEmail = new EmailAddressAttribute();
                if (!checkEmail.IsValid(txbEmail.Text))
                {
                    errorProvider.SetError(txbEmail, "Email không đúng định dạng.");
                    return false;
                }
            }

            return true;
        }

        #endregion

        #region Event
        private void fmUser_Load(object sender, EventArgs e)
        {
            txbUsername.Text = user.Username;
            txbPassword.Text =Encryptor.DecryptorPassword (user.Password);
            txbName.Text = user.Name;
            txbAddress.Text = user.Address;
            txbPhone.Text = user.Phone;
            txbEmail.Text = user.Email;

        }
        #endregion

        #region Button
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                user.Password = Encryptor.EncryptorPassword(txbPassword.Text);
                user.Name = txbName.Text;
                user.Address = txbAddress.Text;
                user.Phone = txbPhone.Text;
                user.Email = txbEmail.Text;

                UserDAO.Instance.UpdateUser(user);

                MessageBox.Show("Cập nhật thông tin thành công.");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin không thành công.");
            }
        }
        #endregion
    }
}
