namespace WebService
{
    partial class fmSplash
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
            this.pgbWating = new System.Windows.Forms.ProgressBar();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorking = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // pgbWating
            // 
            this.pgbWating.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pgbWating.Location = new System.Drawing.Point(20, 500);
            this.pgbWating.Name = "pgbWating";
            this.pgbWating.Size = new System.Drawing.Size(819, 23);
            this.pgbWating.TabIndex = 0;
            // 
            // timerCheck
            // 
            this.timerCheck.Interval = 1000;
            // 
            // fmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 543);
            this.Controls.Add(this.pgbWating);
            this.Name = "fmSplash";
            this.Load += new System.EventHandler(this.fmSplash_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbWating;
        private System.Windows.Forms.Timer timerCheck;
        private System.ComponentModel.BackgroundWorker backgroundWorking;
    }
}