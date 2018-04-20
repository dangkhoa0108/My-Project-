namespace testEntityFarmwork
{
    partial class ReportForm
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
            this.frmReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // frmReport
            // 
            this.frmReport.ActiveViewIndex = -1;
            this.frmReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.frmReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmReport.Location = new System.Drawing.Point(20, 60);
            this.frmReport.Name = "frmReport";
            this.frmReport.Size = new System.Drawing.Size(678, 466);
            this.frmReport.TabIndex = 0;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 546);
            this.Controls.Add(this.frmReport);
            this.MinimizeBox = false;
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportForm_FormClosed);
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer frmReport;
    }
}