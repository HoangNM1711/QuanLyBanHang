﻿namespace CheckConnectWCF
{
    partial class fmWaiting
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
            this.pgbWaiting = new System.Windows.Forms.ProgressBar();
            this.timerChecking = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorking = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // pgbWaiting
            // 
            this.pgbWaiting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pgbWaiting.Location = new System.Drawing.Point(20, 354);
            this.pgbWaiting.Name = "pgbWaiting";
            this.pgbWaiting.Size = new System.Drawing.Size(559, 23);
            this.pgbWaiting.TabIndex = 0;
            // 
            // timerChecking
            // 
            this.timerChecking.Interval = 1000;
            this.timerChecking.Tick += new System.EventHandler(this.timerChecking_Tick);
            // 
            // backgroundWorking
            // 
            this.backgroundWorking.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorking_DoWork);
            this.backgroundWorking.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorking_RunWorkerCompleted);
            // 
            // fmWaiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 397);
            this.Controls.Add(this.pgbWaiting);
            this.Name = "fmWaiting";
            this.Load += new System.EventHandler(this.fmWaiting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbWaiting;
        private System.Windows.Forms.Timer timerChecking;
        private System.ComponentModel.BackgroundWorker backgroundWorking;
    }
}