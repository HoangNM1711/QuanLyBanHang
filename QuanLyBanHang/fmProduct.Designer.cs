namespace QuanLyBanHang
{
    partial class fmProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnLoadProduct = new MetroFramework.Controls.MetroButton();
            this.txbID = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbStatus = new MetroFramework.Controls.MetroComboBox();
            this.btnProductFind = new MetroFramework.Controls.MetroButton();
            this.txbProductFind = new System.Windows.Forms.TextBox();
            this.btnProductUpdate = new MetroFramework.Controls.MetroButton();
            this.btnProductDelete = new MetroFramework.Controls.MetroButton();
            this.btnProductAdd = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numberSold = new System.Windows.Forms.NumericUpDown();
            this.numberStock = new System.Windows.Forms.NumericUpDown();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txbProductName = new System.Windows.Forms.TextBox();
            this.CategoryPName = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.cbSupplierId = new MetroFramework.Controls.MetroComboBox();
            this.cbCateID = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.nbPrice = new System.Windows.Forms.NumericUpDown();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberSold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberStock)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbPrice)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvProduct.Name = "dgvProduct";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvProduct.Size = new System.Drawing.Size(596, 299);
            this.dgvProduct.TabIndex = 2;
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
            this.textBox2.Text = "Sản Phẩm";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLoadProduct
            // 
            this.btnLoadProduct.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnLoadProduct.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLoadProduct.Location = new System.Drawing.Point(484, 201);
            this.btnLoadProduct.Name = "btnLoadProduct";
            this.btnLoadProduct.Size = new System.Drawing.Size(101, 50);
            this.btnLoadProduct.TabIndex = 12;
            this.btnLoadProduct.Text = "Xem";
            this.btnLoadProduct.UseSelectable = true;
            this.btnLoadProduct.Click += new System.EventHandler(this.btnLoadProduct_Click);
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(114, 35);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(161, 26);
            this.txbID.TabIndex = 1;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel4.Location = new System.Drawing.Point(77, 35);
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
            this.cbStatus.Location = new System.Drawing.Point(114, 161);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(160, 29);
            this.cbStatus.TabIndex = 7;
            this.cbStatus.UseSelectable = true;
            // 
            // btnProductFind
            // 
            this.btnProductFind.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnProductFind.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnProductFind.Location = new System.Drawing.Point(484, 266);
            this.btnProductFind.Name = "btnProductFind";
            this.btnProductFind.Size = new System.Drawing.Size(101, 50);
            this.btnProductFind.TabIndex = 14;
            this.btnProductFind.Text = "Tìm kiếm";
            this.btnProductFind.UseSelectable = true;
            // 
            // txbProductFind
            // 
            this.txbProductFind.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProductFind.Location = new System.Drawing.Point(17, 280);
            this.txbProductFind.Name = "txbProductFind";
            this.txbProductFind.Size = new System.Drawing.Size(413, 22);
            this.txbProductFind.TabIndex = 13;
            this.txbProductFind.Text = "Từ khóa tìm kiếm";
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnProductUpdate.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnProductUpdate.Location = new System.Drawing.Point(184, 201);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(101, 50);
            this.btnProductUpdate.TabIndex = 10;
            this.btnProductUpdate.Text = "Sửa";
            this.btnProductUpdate.UseSelectable = true;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnProductDelete.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnProductDelete.Location = new System.Drawing.Point(329, 201);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(101, 50);
            this.btnProductDelete.TabIndex = 11;
            this.btnProductDelete.Text = "Xóa";
            this.btnProductDelete.UseSelectable = true;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnProductAdd.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnProductAdd.Location = new System.Drawing.Point(22, 201);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(101, 50);
            this.btnProductAdd.TabIndex = 9;
            this.btnProductAdd.Text = "Thêm";
            this.btnProductAdd.UseSelectable = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(224, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 40);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, -14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 2;
            // 
            // numberSold
            // 
            this.numberSold.Location = new System.Drawing.Point(424, 78);
            this.numberSold.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numberSold.Name = "numberSold";
            this.numberSold.Size = new System.Drawing.Size(161, 26);
            this.numberSold.TabIndex = 4;
            // 
            // numberStock
            // 
            this.numberStock.Location = new System.Drawing.Point(114, 77);
            this.numberStock.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numberStock.Name = "numberStock";
            this.numberStock.Size = new System.Drawing.Size(161, 26);
            this.numberStock.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel2.Location = new System.Drawing.Point(357, 78);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "SL bán :";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel1.Location = new System.Drawing.Point(22, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "SL tồn kho :";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbProductName
            // 
            this.txbProductName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProductName.Location = new System.Drawing.Point(424, 34);
            this.txbProductName.Name = "txbProductName";
            this.txbProductName.Size = new System.Drawing.Size(161, 26);
            this.txbProductName.TabIndex = 2;
            // 
            // CategoryPName
            // 
            this.CategoryPName.AutoSize = true;
            this.CategoryPName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.CategoryPName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CategoryPName.Location = new System.Drawing.Point(309, 35);
            this.CategoryPName.Name = "CategoryPName";
            this.CategoryPName.Size = new System.Drawing.Size(109, 19);
            this.CategoryPName.TabIndex = 2;
            this.CategoryPName.Text = "Tên sản phẩm :";
            this.CategoryPName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.dgvProduct);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 390);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(596, 299);
            this.metroPanel2.TabIndex = 7;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BackColor = System.Drawing.Color.White;
            this.metroPanel3.Controls.Add(this.cbSupplierId);
            this.metroPanel3.Controls.Add(this.cbCateID);
            this.metroPanel3.Controls.Add(this.metroLabel7);
            this.metroPanel3.Controls.Add(this.metroLabel6);
            this.metroPanel3.Controls.Add(this.nbPrice);
            this.metroPanel3.Controls.Add(this.metroLabel5);
            this.metroPanel3.Controls.Add(this.btnLoadProduct);
            this.metroPanel3.Controls.Add(this.txbID);
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.Controls.Add(this.cbStatus);
            this.metroPanel3.Controls.Add(this.btnProductFind);
            this.metroPanel3.Controls.Add(this.txbProductFind);
            this.metroPanel3.Controls.Add(this.btnProductUpdate);
            this.metroPanel3.Controls.Add(this.btnProductDelete);
            this.metroPanel3.Controls.Add(this.btnProductAdd);
            this.metroPanel3.Controls.Add(this.numberSold);
            this.metroPanel3.Controls.Add(this.numberStock);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.Controls.Add(this.metroLabel2);
            this.metroPanel3.Controls.Add(this.metroLabel1);
            this.metroPanel3.Controls.Add(this.txbProductName);
            this.metroPanel3.Controls.Add(this.CategoryPName);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(594, 329);
            this.metroPanel3.TabIndex = 3;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // cbSupplierId
            // 
            this.cbSupplierId.FormattingEnabled = true;
            this.cbSupplierId.ItemHeight = 23;
            this.cbSupplierId.Location = new System.Drawing.Point(424, 116);
            this.cbSupplierId.Name = "cbSupplierId";
            this.cbSupplierId.Size = new System.Drawing.Size(161, 29);
            this.cbSupplierId.TabIndex = 16;
            this.cbSupplierId.UseSelectable = true;
            // 
            // cbCateID
            // 
            this.cbCateID.FormattingEnabled = true;
            this.cbCateID.ItemHeight = 23;
            this.cbCateID.Location = new System.Drawing.Point(114, 116);
            this.cbCateID.Name = "cbCateID";
            this.cbCateID.Size = new System.Drawing.Size(160, 29);
            this.cbCateID.TabIndex = 15;
            this.cbCateID.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel7.Location = new System.Drawing.Point(319, 120);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(99, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Tên hãng SX :";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel6.Location = new System.Drawing.Point(42, 120);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(66, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Loại SP :";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nbPrice
            // 
            this.nbPrice.Location = new System.Drawing.Point(424, 161);
            this.nbPrice.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.nbPrice.Name = "nbPrice";
            this.nbPrice.Size = new System.Drawing.Size(161, 26);
            this.nbPrice.TabIndex = 8;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel5.Location = new System.Drawing.Point(379, 164);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(39, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Giá :";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel3.Location = new System.Drawing.Point(24, 168);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(85, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Trạng thái :";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.metroPanel1.Size = new System.Drawing.Size(596, 330);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // fmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 706);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "fmProduct";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmProduct_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberSold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberStock)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbPrice)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.TextBox textBox2;
        private MetroFramework.Controls.MetroButton btnLoadProduct;
        private System.Windows.Forms.TextBox txbID;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cbStatus;
        private MetroFramework.Controls.MetroButton btnProductFind;
        private System.Windows.Forms.TextBox txbProductFind;
        private MetroFramework.Controls.MetroButton btnProductUpdate;
        private MetroFramework.Controls.MetroButton btnProductDelete;
        private MetroFramework.Controls.MetroButton btnProductAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numberSold;
        private System.Windows.Forms.NumericUpDown numberStock;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txbProductName;
        private MetroFramework.Controls.MetroLabel CategoryPName;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.NumericUpDown nbPrice;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cbSupplierId;
        private MetroFramework.Controls.MetroComboBox cbCateID;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}