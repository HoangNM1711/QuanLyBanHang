namespace QuanLyBanHang
{
    partial class fmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmLogin));
            this.mLoginPanel = new MetroFramework.Controls.MetroPanel();
            this.btnForget = new MetroFramework.Controls.MetroButton();
            this.PasswordTxb = new System.Windows.Forms.TextBox();
            this.UsernameTxb = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new MetroFramework.Controls.MetroButton();
            this.LoginBtn = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UsernameBox = new System.Windows.Forms.PictureBox();
            this.mLoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mLoginPanel
            // 
            this.mLoginPanel.BackColor = System.Drawing.Color.White;
            this.mLoginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mLoginPanel.Controls.Add(this.btnForget);
            this.mLoginPanel.Controls.Add(this.PasswordTxb);
            this.mLoginPanel.Controls.Add(this.UsernameTxb);
            this.mLoginPanel.Controls.Add(this.RegisterBtn);
            this.mLoginPanel.Controls.Add(this.LoginBtn);
            this.mLoginPanel.Controls.Add(this.pictureBox1);
            this.mLoginPanel.Controls.Add(this.UsernameBox);
            this.mLoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mLoginPanel.HorizontalScrollbarBarColor = true;
            this.mLoginPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mLoginPanel.HorizontalScrollbarSize = 10;
            this.mLoginPanel.Location = new System.Drawing.Point(20, 65);
            this.mLoginPanel.Name = "mLoginPanel";
            this.mLoginPanel.Size = new System.Drawing.Size(434, 227);
            this.mLoginPanel.TabIndex = 1;
            this.mLoginPanel.VerticalScrollbarBarColor = true;
            this.mLoginPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mLoginPanel.VerticalScrollbarSize = 10;
            // 
            // btnForget
            // 
            this.btnForget.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnForget.Location = new System.Drawing.Point(274, 138);
            this.btnForget.Name = "btnForget";
            this.btnForget.Size = new System.Drawing.Size(91, 37);
            this.btnForget.TabIndex = 8;
            this.btnForget.Text = "Quên MK";
            this.btnForget.UseSelectable = true;
            this.btnForget.Click += new System.EventHandler(this.btnForget_Click);
            // 
            // PasswordTxb
            // 
            this.PasswordTxb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxb.Location = new System.Drawing.Point(119, 93);
            this.PasswordTxb.Name = "PasswordTxb";
            this.PasswordTxb.Size = new System.Drawing.Size(246, 29);
            this.PasswordTxb.TabIndex = 2;
            this.PasswordTxb.Text = "123";
            this.PasswordTxb.Enter += new System.EventHandler(this.PasswordTxb_GotFocus);
            this.PasswordTxb.Leave += new System.EventHandler(this.PasswordTxb_LostFocus);
            // 
            // UsernameTxb
            // 
            this.UsernameTxb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxb.Location = new System.Drawing.Point(119, 43);
            this.UsernameTxb.Name = "UsernameTxb";
            this.UsernameTxb.Size = new System.Drawing.Size(246, 29);
            this.UsernameTxb.TabIndex = 1;
            this.UsernameTxb.Text = "admin";
            this.UsernameTxb.Enter += new System.EventHandler(this.UsernameTxb_GotFocus);
            this.UsernameTxb.Leave += new System.EventHandler(this.UsernameTxb_LostFocus);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.RegisterBtn.Location = new System.Drawing.Point(168, 138);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(100, 37);
            this.RegisterBtn.TabIndex = 7;
            this.RegisterBtn.Text = "Đăng Ký";
            this.RegisterBtn.UseSelectable = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.LoginBtn.Location = new System.Drawing.Point(71, 138);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(91, 37);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Đăng Nhập";
            this.LoginBtn.UseSelectable = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Image = ((System.Drawing.Image)(resources.GetObject("UsernameBox.Image")));
            this.UsernameBox.Location = new System.Drawing.Point(71, 43);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(27, 29);
            this.UsernameBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UsernameBox.TabIndex = 2;
            this.UsernameBox.TabStop = false;
            // 
            // fmLogin
            // 
            this.AcceptButton = this.LoginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 314);
            this.Controls.Add(this.mLoginPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fmLogin";
            this.Padding = new System.Windows.Forms.Padding(20, 65, 20, 22);
            this.Text = "Đăng nhập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmLogin_FormClosed);
            this.mLoginPanel.ResumeLayout(false);
            this.mLoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mLoginPanel;
        private System.Windows.Forms.PictureBox UsernameBox;
        private MetroFramework.Controls.MetroButton RegisterBtn;
        private MetroFramework.Controls.MetroButton LoginBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox PasswordTxb;
        private System.Windows.Forms.TextBox UsernameTxb;
        private MetroFramework.Controls.MetroButton btnForget;
    }
}