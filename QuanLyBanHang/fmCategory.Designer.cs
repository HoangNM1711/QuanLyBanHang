﻿namespace QuanLyBanHang
{
    partial class fmCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.txbID = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbStatus = new MetroFramework.Controls.MetroComboBox();
            this.txbCategoryFind = new System.Windows.Forms.TextBox();
            this.numberSold = new System.Windows.Forms.NumericUpDown();
            this.numberStock = new System.Windows.Forms.NumericUpDown();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txbCategoryName = new System.Windows.Forms.TextBox();
            this.CategoryPName = new MetroFramework.Controls.MetroLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.btnCategoryFind = new MetroFramework.Controls.MetroButton();
            this.btnCategoryUpdate = new MetroFramework.Controls.MetroButton();
            this.btnCategoryDelete = new MetroFramework.Controls.MetroButton();
            this.btnCategoryAdd = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.CategoryGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroPanel1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberSold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberStock)).BeginInit();
            this.panel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
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
            this.metroPanel1.Location = new System.Drawing.Point(30, 88);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(568, 244);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BackColor = System.Drawing.Color.White;
            this.metroPanel3.Controls.Add(this.btnLoad);
            this.metroPanel3.Controls.Add(this.btnCategoryDelete);
            this.metroPanel3.Controls.Add(this.txbID);
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.Controls.Add(this.btnCategoryUpdate);
            this.metroPanel3.Controls.Add(this.btnCategoryAdd);
            this.metroPanel3.Controls.Add(this.cbStatus);
            this.metroPanel3.Controls.Add(this.btnCategoryFind);
            this.metroPanel3.Controls.Add(this.txbCategoryFind);
            this.metroPanel3.Controls.Add(this.numberSold);
            this.metroPanel3.Controls.Add(this.numberStock);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.Controls.Add(this.metroLabel2);
            this.metroPanel3.Controls.Add(this.metroLabel1);
            this.metroPanel3.Controls.Add(this.txbCategoryName);
            this.metroPanel3.Controls.Add(this.CategoryPName);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(566, 243);
            this.metroPanel3.TabIndex = 3;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(173, 31);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(200, 26);
            this.txbID.TabIndex = 2;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel4.Location = new System.Drawing.Point(136, 38);
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
            this.cbStatus.Location = new System.Drawing.Point(173, 164);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(198, 29);
            this.cbStatus.TabIndex = 10;
            this.cbStatus.UseSelectable = true;
            // 
            // txbCategoryFind
            // 
            this.txbCategoryFind.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCategoryFind.Location = new System.Drawing.Point(22, 198);
            this.txbCategoryFind.Name = "txbCategoryFind";
            this.txbCategoryFind.Size = new System.Drawing.Size(349, 22);
            this.txbCategoryFind.TabIndex = 14;
            this.txbCategoryFind.Text = "Từ khóa tìm kiếm";
            this.txbCategoryFind.Enter += new System.EventHandler(this.txbCategoryFind_GotFocus);
            this.txbCategoryFind.Leave += new System.EventHandler(this.txbCategoryFind_LostFocus);
            // 
            // numberSold
            // 
            this.numberSold.Location = new System.Drawing.Point(173, 131);
            this.numberSold.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numberSold.Name = "numberSold";
            this.numberSold.Size = new System.Drawing.Size(198, 26);
            this.numberSold.TabIndex = 8;
            // 
            // numberStock
            // 
            this.numberStock.Location = new System.Drawing.Point(173, 98);
            this.numberStock.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numberStock.Name = "numberStock";
            this.numberStock.Size = new System.Drawing.Size(199, 26);
            this.numberStock.TabIndex = 6;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel3.Location = new System.Drawing.Point(82, 167);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(85, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Trạng thái :";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel2.Location = new System.Drawing.Point(106, 133);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "SL bán :";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel1.Location = new System.Drawing.Point(80, 102);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "SL tồn kho :";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbCategoryName
            // 
            this.txbCategoryName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCategoryName.Location = new System.Drawing.Point(173, 65);
            this.txbCategoryName.Name = "txbCategoryName";
            this.txbCategoryName.Size = new System.Drawing.Size(199, 26);
            this.txbCategoryName.TabIndex = 4;
            // 
            // CategoryPName
            // 
            this.CategoryPName.AutoSize = true;
            this.CategoryPName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.CategoryPName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CategoryPName.Location = new System.Drawing.Point(54, 64);
            this.CategoryPName.Name = "CategoryPName";
            this.CategoryPName.Size = new System.Drawing.Size(113, 19);
            this.CategoryPName.TabIndex = 3;
            this.CategoryPName.Text = "Loại sản phẩm :";
            this.CategoryPName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, -14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 26);
            this.textBox1.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLoad.Location = new System.Drawing.Point(423, 150);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(101, 39);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "Xem";
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCategoryFind
            // 
            this.btnCategoryFind.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCategoryFind.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCategoryFind.Location = new System.Drawing.Point(423, 195);
            this.btnCategoryFind.Name = "btnCategoryFind";
            this.btnCategoryFind.Size = new System.Drawing.Size(101, 42);
            this.btnCategoryFind.TabIndex = 15;
            this.btnCategoryFind.Text = "Tìm kiếm";
            this.btnCategoryFind.UseSelectable = true;
            this.btnCategoryFind.Click += new System.EventHandler(this.btnCategoryFind_Click);
            // 
            // btnCategoryUpdate
            // 
            this.btnCategoryUpdate.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCategoryUpdate.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCategoryUpdate.Location = new System.Drawing.Point(423, 63);
            this.btnCategoryUpdate.Name = "btnCategoryUpdate";
            this.btnCategoryUpdate.Size = new System.Drawing.Size(101, 39);
            this.btnCategoryUpdate.TabIndex = 12;
            this.btnCategoryUpdate.Text = "Sửa";
            this.btnCategoryUpdate.UseSelectable = true;
            this.btnCategoryUpdate.Click += new System.EventHandler(this.btnCategoryUpdate_Click);
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCategoryDelete.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCategoryDelete.Location = new System.Drawing.Point(423, 106);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(101, 39);
            this.btnCategoryDelete.TabIndex = 13;
            this.btnCategoryDelete.Text = "Xóa";
            this.btnCategoryDelete.UseSelectable = true;
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCategoryAdd.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCategoryAdd.Location = new System.Drawing.Point(423, 18);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(101, 39);
            this.btnCategoryAdd.TabIndex = 11;
            this.btnCategoryAdd.Text = "Thêm";
            this.btnCategoryAdd.UseSelectable = true;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(202, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 40);
            this.panel1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(23, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 25);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Loại Sản Phẩm";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.CategoryGridView);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(30, 332);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(568, 299);
            this.metroPanel2.TabIndex = 4;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // CategoryGridView
            // 
            this.CategoryGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CategoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoryGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.CategoryGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.CategoryGridView.Location = new System.Drawing.Point(0, 0);
            this.CategoryGridView.Name = "CategoryGridView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.CategoryGridView.Size = new System.Drawing.Size(568, 292);
            this.CategoryGridView.TabIndex = 2;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // fmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 635);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmCategory";
            this.Padding = new System.Windows.Forms.Padding(30, 88, 30, 29);
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmCategory_FormClosed);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberSold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberStock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.DataGridView CategoryGridView;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txbCategoryName;
        private MetroFramework.Controls.MetroLabel CategoryPName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.NumericUpDown numberSold;
        private System.Windows.Forms.NumericUpDown numberStock;
        private MetroFramework.Controls.MetroButton btnCategoryAdd;
        private MetroFramework.Controls.MetroButton btnCategoryDelete;
        private MetroFramework.Controls.MetroButton btnCategoryFind;
        private System.Windows.Forms.TextBox txbCategoryFind;
        private MetroFramework.Controls.MetroButton btnCategoryUpdate;
        private MetroFramework.Controls.MetroComboBox cbStatus;
        private System.Windows.Forms.TextBox txbID;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnLoad;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}