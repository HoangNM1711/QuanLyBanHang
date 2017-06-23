namespace QuanLyBanHang
{
    partial class fmOrderDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnOrderLoad = new MetroFramework.Controls.MetroButton();
            this.txbID = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnOrderUpdate = new MetroFramework.Controls.MetroButton();
            this.btnOrderDelete = new MetroFramework.Controls.MetroButton();
            this.btnOrderAdd = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CategoryPName = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.btnODFind = new MetroFramework.Controls.MetroButton();
            this.txbODFind = new System.Windows.Forms.TextBox();
            this.cbCategory = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txbOrderId = new System.Windows.Forms.TextBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.cbProductID = new MetroFramework.Controls.MetroComboBox();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExport = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(225, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 40);
            this.panel1.TabIndex = 9;
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
            this.textBox2.Text = "Chi tiết đơn hàng";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOrderLoad
            // 
            this.btnOrderLoad.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnOrderLoad.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnOrderLoad.Location = new System.Drawing.Point(445, 215);
            this.btnOrderLoad.Name = "btnOrderLoad";
            this.btnOrderLoad.Size = new System.Drawing.Size(101, 50);
            this.btnOrderLoad.TabIndex = 12;
            this.btnOrderLoad.Text = "Xem";
            this.btnOrderLoad.UseSelectable = true;
            this.btnOrderLoad.Click += new System.EventHandler(this.btnOrderLoad_Click);
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(110, 45);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(165, 26);
            this.txbID.TabIndex = 1;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel4.Location = new System.Drawing.Point(70, 47);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(31, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "ID :";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOrderUpdate
            // 
            this.btnOrderUpdate.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnOrderUpdate.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnOrderUpdate.Location = new System.Drawing.Point(174, 215);
            this.btnOrderUpdate.Name = "btnOrderUpdate";
            this.btnOrderUpdate.Size = new System.Drawing.Size(101, 50);
            this.btnOrderUpdate.TabIndex = 10;
            this.btnOrderUpdate.Text = "Cập nhật";
            this.btnOrderUpdate.UseSelectable = true;
            this.btnOrderUpdate.Click += new System.EventHandler(this.btnOrderUpdate_Click);
            // 
            // btnOrderDelete
            // 
            this.btnOrderDelete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnOrderDelete.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnOrderDelete.Location = new System.Drawing.Point(320, 215);
            this.btnOrderDelete.Name = "btnOrderDelete";
            this.btnOrderDelete.Size = new System.Drawing.Size(101, 50);
            this.btnOrderDelete.TabIndex = 11;
            this.btnOrderDelete.Text = "Xóa";
            this.btnOrderDelete.UseSelectable = true;
            this.btnOrderDelete.Click += new System.EventHandler(this.btnOrderDelete_Click);
            // 
            // btnOrderAdd
            // 
            this.btnOrderAdd.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnOrderAdd.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnOrderAdd.Location = new System.Drawing.Point(50, 215);
            this.btnOrderAdd.Name = "btnOrderAdd";
            this.btnOrderAdd.Size = new System.Drawing.Size(101, 50);
            this.btnOrderAdd.TabIndex = 9;
            this.btnOrderAdd.Text = "Thêm";
            this.btnOrderAdd.UseSelectable = true;
            this.btnOrderAdd.Click += new System.EventHandler(this.btnOrderAdd_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel2.Location = new System.Drawing.Point(321, 132);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Số lượng :";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel1.Location = new System.Drawing.Point(299, 47);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Mã đơn hàng :";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CategoryPName
            // 
            this.CategoryPName.AutoSize = true;
            this.CategoryPName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.CategoryPName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CategoryPName.Location = new System.Drawing.Point(321, 94);
            this.CategoryPName.Name = "CategoryPName";
            this.CategoryPName.Size = new System.Drawing.Size(83, 19);
            this.CategoryPName.TabIndex = 2;
            this.CategoryPName.Text = "Sản phẩm :";
            this.CategoryPName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BackColor = System.Drawing.Color.White;
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.btnExport);
            this.metroPanel3.Controls.Add(this.btnODFind);
            this.metroPanel3.Controls.Add(this.txbODFind);
            this.metroPanel3.Controls.Add(this.cbCategory);
            this.metroPanel3.Controls.Add(this.metroLabel6);
            this.metroPanel3.Controls.Add(this.txbTotalPrice);
            this.metroPanel3.Controls.Add(this.metroLabel5);
            this.metroPanel3.Controls.Add(this.txbPrice);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.Controls.Add(this.txbOrderId);
            this.metroPanel3.Controls.Add(this.numQuantity);
            this.metroPanel3.Controls.Add(this.cbProductID);
            this.metroPanel3.Controls.Add(this.btnOrderLoad);
            this.metroPanel3.Controls.Add(this.txbID);
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.Controls.Add(this.btnOrderUpdate);
            this.metroPanel3.Controls.Add(this.btnOrderDelete);
            this.metroPanel3.Controls.Add(this.btnOrderAdd);
            this.metroPanel3.Controls.Add(this.metroLabel2);
            this.metroPanel3.Controls.Add(this.metroLabel1);
            this.metroPanel3.Controls.Add(this.CategoryPName);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(20, 60);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(622, 340);
            this.metroPanel3.TabIndex = 10;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // btnODFind
            // 
            this.btnODFind.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnODFind.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnODFind.Location = new System.Drawing.Point(445, 271);
            this.btnODFind.Name = "btnODFind";
            this.btnODFind.Size = new System.Drawing.Size(101, 50);
            this.btnODFind.TabIndex = 26;
            this.btnODFind.Text = "Tìm kiếm";
            this.btnODFind.UseSelectable = true;
            this.btnODFind.Click += new System.EventHandler(this.btnODFind_Click);
            // 
            // txbODFind
            // 
            this.txbODFind.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbODFind.Location = new System.Drawing.Point(50, 286);
            this.txbODFind.Name = "txbODFind";
            this.txbODFind.Size = new System.Drawing.Size(371, 22);
            this.txbODFind.TabIndex = 25;
            this.txbODFind.Text = "Từ khóa tìm kiếm";
            this.txbODFind.GotFocus += new System.EventHandler(this.txbODFind_GotFocus);
            this.txbODFind.LostFocus += new System.EventHandler(this.txbODFind_LostFocus);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.ItemHeight = 23;
            this.cbCategory.Location = new System.Drawing.Point(110, 90);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(165, 29);
            this.cbCategory.TabIndex = 24;
            this.cbCategory.UseSelectable = true;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel6.Location = new System.Drawing.Point(18, 94);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(83, 19);
            this.metroLabel6.TabIndex = 23;
            this.metroLabel6.Text = "Danh mục :";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalPrice.Location = new System.Drawing.Point(269, 172);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(152, 26);
            this.txbTotalPrice.TabIndex = 6;
            this.txbTotalPrice.TextChanged += new System.EventHandler(this.txbTotalPrice_TextChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel5.Location = new System.Drawing.Point(174, 172);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(86, 19);
            this.metroLabel5.TabIndex = 22;
            this.metroLabel5.Text = "Thành tiền :";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbPrice
            // 
            this.txbPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrice.Location = new System.Drawing.Point(110, 132);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.ReadOnly = true;
            this.txbPrice.Size = new System.Drawing.Size(165, 26);
            this.txbPrice.TabIndex = 4;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel3.Location = new System.Drawing.Point(60, 132);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 19);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "Giá :";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbOrderId
            // 
            this.txbOrderId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbOrderId.Location = new System.Drawing.Point(411, 45);
            this.txbOrderId.Name = "txbOrderId";
            this.txbOrderId.ReadOnly = true;
            this.txbOrderId.Size = new System.Drawing.Size(173, 26);
            this.txbOrderId.TabIndex = 2;
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(411, 132);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(173, 26);
            this.numQuantity.TabIndex = 5;
            // 
            // cbProductID
            // 
            this.cbProductID.FormattingEnabled = true;
            this.cbProductID.ItemHeight = 23;
            this.cbProductID.Location = new System.Drawing.Point(411, 90);
            this.cbProductID.Name = "cbProductID";
            this.cbProductID.Size = new System.Drawing.Size(173, 29);
            this.cbProductID.TabIndex = 3;
            this.cbProductID.UseSelectable = true;
            this.cbProductID.SelectedIndexChanged += new System.EventHandler(this.cbProductID_SelectedIndexChanged);
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderDetail.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvOrderDetail.Size = new System.Drawing.Size(622, 271);
            this.dgvOrderDetail.TabIndex = 11;
            this.dgvOrderDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetail_CellClick);
            this.dgvOrderDetail.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOrderDetail_CellFormatting);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvOrderDetail);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 271);
            this.panel2.TabIndex = 12;
            // 
            // btnExport
            // 
            this.btnExport.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnExport.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnExport.Location = new System.Drawing.Point(516, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(101, 25);
            this.btnExport.TabIndex = 27;
            this.btnExport.Text = "Export Excel";
            this.btnExport.UseSelectable = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // fmOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroPanel3);
            this.Name = "fmOrderDetail";
            this.Load += new System.EventHandler(this.fmOrderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton btnOrderLoad;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnOrderUpdate;
        private MetroFramework.Controls.MetroButton btnOrderDelete;
        private MetroFramework.Controls.MetroButton btnOrderAdd;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel CategoryPName;
        public System.Windows.Forms.DataGridView dgvOrderDetail;
        public System.Windows.Forms.TextBox txbID;
        public System.Windows.Forms.TextBox txbOrderId;
        public System.Windows.Forms.NumericUpDown numQuantity;
        public MetroFramework.Controls.MetroComboBox cbProductID;
        public System.Windows.Forms.TextBox txbPrice;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txbTotalPrice;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        public MetroFramework.Controls.MetroComboBox cbCategory;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton btnODFind;
        private System.Windows.Forms.TextBox txbODFind;
        private MetroFramework.Controls.MetroButton btnExport;
    }
}