namespace QuanLyBanHang
{
    partial class fmClean
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
            this.btnDCategory = new MetroFramework.Controls.MetroButton();
            this.btnDSupplier = new MetroFramework.Controls.MetroButton();
            this.btnDProduct = new MetroFramework.Controls.MetroButton();
            this.btnDOrder = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDCategory
            // 
            this.btnDCategory.Location = new System.Drawing.Point(3, 34);
            this.btnDCategory.Name = "btnDCategory";
            this.btnDCategory.Size = new System.Drawing.Size(93, 60);
            this.btnDCategory.TabIndex = 0;
            this.btnDCategory.Text = "Danh mục";
            this.btnDCategory.UseSelectable = true;
            this.btnDCategory.Click += new System.EventHandler(this.btnDCategory_Click);
            // 
            // btnDSupplier
            // 
            this.btnDSupplier.Location = new System.Drawing.Point(102, 34);
            this.btnDSupplier.Name = "btnDSupplier";
            this.btnDSupplier.Size = new System.Drawing.Size(93, 60);
            this.btnDSupplier.TabIndex = 1;
            this.btnDSupplier.Text = "Hãng SX";
            this.btnDSupplier.UseSelectable = true;
            this.btnDSupplier.Click += new System.EventHandler(this.btnDSupplier_Click);
            // 
            // btnDProduct
            // 
            this.btnDProduct.Location = new System.Drawing.Point(204, 34);
            this.btnDProduct.Name = "btnDProduct";
            this.btnDProduct.Size = new System.Drawing.Size(93, 60);
            this.btnDProduct.TabIndex = 2;
            this.btnDProduct.Text = "Sản Phẩm";
            this.btnDProduct.UseSelectable = true;
            this.btnDProduct.Click += new System.EventHandler(this.btnDProduct_Click);
            // 
            // btnDOrder
            // 
            this.btnDOrder.Location = new System.Drawing.Point(303, 34);
            this.btnDOrder.Name = "btnDOrder";
            this.btnDOrder.Size = new System.Drawing.Size(93, 60);
            this.btnDOrder.TabIndex = 3;
            this.btnDOrder.Text = "Hóa đơn";
            this.btnDOrder.UseSelectable = true;
            this.btnDOrder.Click += new System.EventHandler(this.btnDOrder_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnDProduct);
            this.metroPanel1.Controls.Add(this.btnDOrder);
            this.metroPanel1.Controls.Add(this.btnDCategory);
            this.metroPanel1.Controls.Add(this.btnDSupplier);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(30, 88);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(408, 134);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // fmClean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 251);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmClean";
            this.Padding = new System.Windows.Forms.Padding(30, 88, 30, 29);
            this.Text = "Làm trống bộ nhớ";
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnDCategory;
        private MetroFramework.Controls.MetroButton btnDSupplier;
        private MetroFramework.Controls.MetroButton btnDProduct;
        private MetroFramework.Controls.MetroButton btnDOrder;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}