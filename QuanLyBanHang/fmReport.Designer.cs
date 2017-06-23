namespace QuanLyBanHang
{
    partial class fmReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dtpToDay = new MetroFramework.Controls.MetroDateTime();
            this.dtpFromDay = new MetroFramework.Controls.MetroDateTime();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportDataSet = new QuanLyBanHang.ReportDataSet();
            this.OrderTableAdapter = new QuanLyBanHang.ReportDataSetTableAdapters.OrderTableAdapter();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // rvReport
            // 
            this.rvReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "ReportData";
            reportDataSource2.Value = this.OrderBindingSource;
            this.rvReport.LocalReport.DataSources.Add(reportDataSource2);
            this.rvReport.LocalReport.ReportEmbeddedResource = "QuanLyBanHang.OrderReport.rdlc";
            this.rvReport.Location = new System.Drawing.Point(3, 52);
            this.rvReport.Name = "rvReport";
            this.rvReport.Size = new System.Drawing.Size(694, 474);
            this.rvReport.TabIndex = 0;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.rvReport);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 69);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(700, 529);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dtpToDay
            // 
            this.dtpToDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpToDay.Location = new System.Drawing.Point(379, 8);
            this.dtpToDay.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpToDay.Name = "dtpToDay";
            this.dtpToDay.Size = new System.Drawing.Size(200, 29);
            this.dtpToDay.TabIndex = 3;
            // 
            // dtpFromDay
            // 
            this.dtpFromDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpFromDay.Location = new System.Drawing.Point(80, 8);
            this.dtpFromDay.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpFromDay.Name = "dtpFromDay";
            this.dtpFromDay.Size = new System.Drawing.Size(200, 29);
            this.dtpFromDay.TabIndex = 2;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnLoad);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.dtpToDay);
            this.metroPanel2.Controls.Add(this.dtpFromDay);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(700, 46);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // OrderBindingSource
            // 
            this.OrderBindingSource.DataMember = "Order";
            this.OrderBindingSource.DataSource = this.ReportDataSet;
            // 
            // ReportDataSet
            // 
            this.ReportDataSet.DataSetName = "ReportDataSet";
            this.ReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OrderTableAdapter
            // 
            this.OrderTableAdapter.ClearBeforeFill = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(3, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Từ ngày :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(293, 13);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Đến ngày :";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(602, 8);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 29);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Xem";
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // fmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 621);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fmReport";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.Text = "Báo cáo doanh thu";
            this.Load += new System.EventHandler(this.fmReport_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvReport;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroDateTime dtpToDay;
        private MetroFramework.Controls.MetroDateTime dtpFromDay;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.BindingSource OrderBindingSource;
        private ReportDataSet ReportDataSet;
        private ReportDataSetTableAdapters.OrderTableAdapter OrderTableAdapter;
        private MetroFramework.Controls.MetroButton btnLoad;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}