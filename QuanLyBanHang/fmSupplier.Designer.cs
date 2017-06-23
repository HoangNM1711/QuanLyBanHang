namespace QuanLyBanHang
{
    partial class fmSupplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.txbID = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbStatus = new MetroFramework.Controls.MetroComboBox();
            this.btnSupplierFind = new MetroFramework.Controls.MetroButton();
            this.txbFindSupplier = new System.Windows.Forms.TextBox();
            this.btnSupplierUpdate = new MetroFramework.Controls.MetroButton();
            this.btnDeleteDelete = new MetroFramework.Controls.MetroButton();
            this.btnSupplierAdd = new MetroFramework.Controls.MetroButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txbSupplierName = new System.Windows.Forms.TextBox();
            this.CategoryPName = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.txbSold = new System.Windows.Forms.TextBox();
            this.txbStock = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnLoad
            // 
            this.btnLoad.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLoad.Location = new System.Drawing.Point(390, 147);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(101, 39);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "Xem";
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(140, 28);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(200, 26);
            this.txbID.TabIndex = 1;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel4.Location = new System.Drawing.Point(103, 35);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(31, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "ID :";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.ItemHeight = 23;
            this.cbStatus.Location = new System.Drawing.Point(140, 163);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(200, 29);
            this.cbStatus.TabIndex = 5;
            this.cbStatus.UseSelectable = true;
            // 
            // btnSupplierFind
            // 
            this.btnSupplierFind.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSupplierFind.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSupplierFind.Location = new System.Drawing.Point(390, 192);
            this.btnSupplierFind.Name = "btnSupplierFind";
            this.btnSupplierFind.Size = new System.Drawing.Size(101, 42);
            this.btnSupplierFind.TabIndex = 15;
            this.btnSupplierFind.Text = "Tìm kiếm";
            this.btnSupplierFind.UseSelectable = true;
            this.btnSupplierFind.Click += new System.EventHandler(this.btnSupplierFind_Click);
            // 
            // txbFindSupplier
            // 
            this.txbFindSupplier.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFindSupplier.Location = new System.Drawing.Point(22, 198);
            this.txbFindSupplier.Name = "txbFindSupplier";
            this.txbFindSupplier.Size = new System.Drawing.Size(318, 22);
            this.txbFindSupplier.TabIndex = 6;
            this.txbFindSupplier.Text = "Từ khóa tìm kiếm";
            this.txbFindSupplier.GotFocus += new System.EventHandler(this.txbFindSupplier_GotFocus);
            this.txbFindSupplier.LostFocus += new System.EventHandler(this.txbFindSupplier_LostFocus);
            // 
            // btnSupplierUpdate
            // 
            this.btnSupplierUpdate.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSupplierUpdate.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSupplierUpdate.Location = new System.Drawing.Point(390, 57);
            this.btnSupplierUpdate.Name = "btnSupplierUpdate";
            this.btnSupplierUpdate.Size = new System.Drawing.Size(101, 39);
            this.btnSupplierUpdate.TabIndex = 12;
            this.btnSupplierUpdate.Text = "Cập nhật";
            this.btnSupplierUpdate.UseSelectable = true;
            this.btnSupplierUpdate.Click += new System.EventHandler(this.btnSupplierUpdate_Click);
            // 
            // btnDeleteDelete
            // 
            this.btnDeleteDelete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDeleteDelete.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDeleteDelete.Location = new System.Drawing.Point(390, 102);
            this.btnDeleteDelete.Name = "btnDeleteDelete";
            this.btnDeleteDelete.Size = new System.Drawing.Size(101, 39);
            this.btnDeleteDelete.TabIndex = 13;
            this.btnDeleteDelete.Text = "Xóa";
            this.btnDeleteDelete.UseSelectable = true;
            this.btnDeleteDelete.Click += new System.EventHandler(this.btnDeleteDelete_Click);
            // 
            // btnSupplierAdd
            // 
            this.btnSupplierAdd.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSupplierAdd.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSupplierAdd.Location = new System.Drawing.Point(390, 12);
            this.btnSupplierAdd.Name = "btnSupplierAdd";
            this.btnSupplierAdd.Size = new System.Drawing.Size(101, 39);
            this.btnSupplierAdd.TabIndex = 11;
            this.btnSupplierAdd.Text = "Thêm";
            this.btnSupplierAdd.UseSelectable = true;
            this.btnSupplierAdd.Click += new System.EventHandler(this.btnSupplierAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, -14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 2;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel3.Location = new System.Drawing.Point(50, 166);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(85, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Trạng thái :";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel1.Location = new System.Drawing.Point(75, 106);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "SL còn :";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbSupplierName
            // 
            this.txbSupplierName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSupplierName.Location = new System.Drawing.Point(141, 64);
            this.txbSupplierName.Name = "txbSupplierName";
            this.txbSupplierName.Size = new System.Drawing.Size(199, 26);
            this.txbSupplierName.TabIndex = 2;
            // 
            // CategoryPName
            // 
            this.CategoryPName.AutoSize = true;
            this.CategoryPName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.CategoryPName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CategoryPName.Location = new System.Drawing.Point(36, 71);
            this.CategoryPName.Name = "CategoryPName";
            this.CategoryPName.Size = new System.Drawing.Size(99, 19);
            this.CategoryPName.TabIndex = 3;
            this.CategoryPName.Text = "Tên hãng SX :";
            this.CategoryPName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BackColor = System.Drawing.Color.White;
            this.metroPanel3.Controls.Add(this.txbSold);
            this.metroPanel3.Controls.Add(this.txbStock);
            this.metroPanel3.Controls.Add(this.btnLoad);
            this.metroPanel3.Controls.Add(this.txbID);
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.Controls.Add(this.cbStatus);
            this.metroPanel3.Controls.Add(this.btnSupplierFind);
            this.metroPanel3.Controls.Add(this.txbFindSupplier);
            this.metroPanel3.Controls.Add(this.btnSupplierUpdate);
            this.metroPanel3.Controls.Add(this.btnDeleteDelete);
            this.metroPanel3.Controls.Add(this.btnSupplierAdd);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.Controls.Add(this.metroLabel2);
            this.metroPanel3.Controls.Add(this.metroLabel1);
            this.metroPanel3.Controls.Add(this.txbSupplierName);
            this.metroPanel3.Controls.Add(this.CategoryPName);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(551, 261);
            this.metroPanel3.TabIndex = 3;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // txbSold
            // 
            this.txbSold.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSold.Location = new System.Drawing.Point(140, 131);
            this.txbSold.Name = "txbSold";
            this.txbSold.ReadOnly = true;
            this.txbSold.Size = new System.Drawing.Size(200, 26);
            this.txbSold.TabIndex = 18;
            // 
            // txbStock
            // 
            this.txbStock.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStock.Location = new System.Drawing.Point(141, 102);
            this.txbStock.Name = "txbStock";
            this.txbStock.ReadOnly = true;
            this.txbStock.Size = new System.Drawing.Size(200, 26);
            this.txbStock.TabIndex = 17;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel2.Location = new System.Drawing.Point(74, 133);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "SL bán :";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.White;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroPanel3);
            this.metroPanel1.Controls.Add(this.textBox1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(553, 262);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(172, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 40);
            this.panel1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(17, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 25);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Hãng sản xuất";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupplier.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvSupplier.Location = new System.Drawing.Point(0, 0);
            this.dgvSupplier.Name = "dgvSupplier";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplier.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSupplier.Size = new System.Drawing.Size(553, 292);
            this.dgvSupplier.TabIndex = 7;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.dgvSupplier);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 322);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(553, 298);
            this.metroPanel2.TabIndex = 7;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // fmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 625);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "fmSupplier";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmSupplier_FormClosed);
            this.Load += new System.EventHandler(this.fmSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton btnLoad;
        private System.Windows.Forms.TextBox txbID;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cbStatus;
        private MetroFramework.Controls.MetroButton btnSupplierFind;
        private System.Windows.Forms.TextBox txbFindSupplier;
        private MetroFramework.Controls.MetroButton btnSupplierUpdate;
        private MetroFramework.Controls.MetroButton btnDeleteDelete;
        private MetroFramework.Controls.MetroButton btnSupplierAdd;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txbSupplierName;
        private MetroFramework.Controls.MetroLabel CategoryPName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txbSold;
        private System.Windows.Forms.TextBox txbStock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.DataGridView dgvSupplier;
    }
}