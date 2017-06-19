namespace QuanLyBanHang
{
    partial class fmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.MainPanel = new MetroFramework.Controls.MetroPanel();
            this.lblTime = new MetroFramework.Controls.MetroLabel();
            this.lblDay = new MetroFramework.Controls.MetroLabel();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.thoatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDữLiệuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiSảnPhẩmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nhàCungCấpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sảnPhẩmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.đơnHàngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhSốToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmTraHàngTồnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.MainPanel.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainPanel.Controls.Add(this.lblTime);
            this.MainPanel.Controls.Add(this.lblDay);
            this.MainPanel.Controls.Add(this.MainMenuStrip);
            this.MainPanel.HorizontalScrollbarBarColor = true;
            this.MainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.MainPanel.HorizontalScrollbarSize = 13;
            this.MainPanel.Location = new System.Drawing.Point(0, 4);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(875, 581);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.VerticalScrollbarBarColor = true;
            this.MainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.MainPanel.VerticalScrollbarSize = 13;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTime.ForeColor = System.Drawing.Color.Transparent;
            this.lblTime.Location = new System.Drawing.Point(129, 552);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(38, 19);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time";
            // 
            // lblDay
            // 
            this.lblDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.Transparent;
            this.lblDay.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDay.ForeColor = System.Drawing.Color.Transparent;
            this.lblDay.Location = new System.Drawing.Point(5, 552);
            this.lblDay.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(33, 19);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "Day";
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.MainMenuStrip.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem1,
            this.quảnLýDữLiệuToolStripMenuItem1,
            this.doanhSốToolStripMenuItem1,
            this.kiểmTraHàngTồnToolStripMenuItem1});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.MainMenuStrip.Size = new System.Drawing.Size(875, 29);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem1
            // 
            this.hệThốngToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem1,
            this.đăngXuấtToolStripMenuItem,
            this.toolStripSeparator1,
            this.thoatToolStripMenuItem1});
            this.hệThốngToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hệThốngToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.hệThốngToolStripMenuItem1.Name = "hệThốngToolStripMenuItem1";
            this.hệThốngToolStripMenuItem1.Size = new System.Drawing.Size(87, 23);
            this.hệThốngToolStripMenuItem1.Text = "Hệ Thống";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem1
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.thôngTinTàiKhoảnToolStripMenuItem1.Name = "thôngTinTàiKhoảnToolStripMenuItem1";
            this.thôngTinTàiKhoảnToolStripMenuItem1.Size = new System.Drawing.Size(220, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem1.Text = "Thông Tin Tài Khoản";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
            // 
            // thoatToolStripMenuItem1
            // 
            this.thoatToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.thoatToolStripMenuItem1.Name = "thoatToolStripMenuItem1";
            this.thoatToolStripMenuItem1.Size = new System.Drawing.Size(220, 24);
            this.thoatToolStripMenuItem1.Text = "Thoát";
            this.thoatToolStripMenuItem1.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // quảnLýDữLiệuToolStripMenuItem1
            // 
            this.quảnLýDữLiệuToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loạiSảnPhẩmToolStripMenuItem1,
            this.toolStripSeparator2,
            this.nhàCungCấpToolStripMenuItem1,
            this.toolStripSeparator3,
            this.sảnPhẩmToolStripMenuItem1,
            this.toolStripSeparator5,
            this.đơnHàngToolStripMenuItem1});
            this.quảnLýDữLiệuToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýDữLiệuToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.quảnLýDữLiệuToolStripMenuItem1.Name = "quảnLýDữLiệuToolStripMenuItem1";
            this.quảnLýDữLiệuToolStripMenuItem1.Size = new System.Drawing.Size(139, 23);
            this.quảnLýDữLiệuToolStripMenuItem1.Text = "Quản Lý Dữ Liệu";
            // 
            // loạiSảnPhẩmToolStripMenuItem1
            // 
            this.loạiSảnPhẩmToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.loạiSảnPhẩmToolStripMenuItem1.Name = "loạiSảnPhẩmToolStripMenuItem1";
            this.loạiSảnPhẩmToolStripMenuItem1.Size = new System.Drawing.Size(179, 24);
            this.loạiSảnPhẩmToolStripMenuItem1.Text = "Loại Sản Phẩm";
            this.loạiSảnPhẩmToolStripMenuItem1.Click += new System.EventHandler(this.loạiSảnPhẩmToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(176, 6);
            // 
            // nhàCungCấpToolStripMenuItem1
            // 
            this.nhàCungCấpToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.nhàCungCấpToolStripMenuItem1.Name = "nhàCungCấpToolStripMenuItem1";
            this.nhàCungCấpToolStripMenuItem1.Size = new System.Drawing.Size(179, 24);
            this.nhàCungCấpToolStripMenuItem1.Text = "Hãng Sản Xuất";
            this.nhàCungCấpToolStripMenuItem1.Click += new System.EventHandler(this.nhàCungCấpToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(176, 6);
            // 
            // sảnPhẩmToolStripMenuItem1
            // 
            this.sảnPhẩmToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.sảnPhẩmToolStripMenuItem1.Name = "sảnPhẩmToolStripMenuItem1";
            this.sảnPhẩmToolStripMenuItem1.Size = new System.Drawing.Size(179, 24);
            this.sảnPhẩmToolStripMenuItem1.Text = "Sản Phẩm";
            this.sảnPhẩmToolStripMenuItem1.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(176, 6);
            // 
            // đơnHàngToolStripMenuItem1
            // 
            this.đơnHàngToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.đơnHàngToolStripMenuItem1.Name = "đơnHàngToolStripMenuItem1";
            this.đơnHàngToolStripMenuItem1.Size = new System.Drawing.Size(179, 24);
            this.đơnHàngToolStripMenuItem1.Text = "Đơn Hàng";
            this.đơnHàngToolStripMenuItem1.Click += new System.EventHandler(this.đơnHàngToolStripMenuItem_Click);
            // 
            // doanhSốToolStripMenuItem1
            // 
            this.doanhSốToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doanhSốToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.doanhSốToolStripMenuItem1.Name = "doanhSốToolStripMenuItem1";
            this.doanhSốToolStripMenuItem1.Size = new System.Drawing.Size(86, 23);
            this.doanhSốToolStripMenuItem1.Text = "Doanh Số";
            // 
            // kiểmTraHàngTồnToolStripMenuItem1
            // 
            this.kiểmTraHàngTồnToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kiểmTraHàngTồnToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.kiểmTraHàngTồnToolStripMenuItem1.Name = "kiểmTraHàngTồnToolStripMenuItem1";
            this.kiểmTraHàngTồnToolStripMenuItem1.Size = new System.Drawing.Size(154, 23);
            this.kiểmTraHàngTồnToolStripMenuItem1.Text = "Kiểm Tra Hàng Tồn";
            // 
            // Time
            // 
            this.Time.Enabled = true;
            this.Time.Interval = 1000;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 579);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmMain";
            this.Padding = new System.Windows.Forms.Padding(30, 87, 30, 29);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmMain_FormClosed);
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel MainPanel;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đơnHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtĐơnHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhSốToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểmTraHàngTồnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDữLiệuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loạiSảnPhẩmToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đơnHàngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem doanhSốToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kiểmTraHàngTồnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel lblDay;
        private MetroFramework.Controls.MetroLabel lblTime;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}