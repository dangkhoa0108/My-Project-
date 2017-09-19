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
            this.crystalReportThongKe = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportThongKe
            // 
            this.crystalReportThongKe.ActiveViewIndex = -1;
            this.crystalReportThongKe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportThongKe.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportThongKe.Location = new System.Drawing.Point(20, 60);
            this.crystalReportThongKe.Name = "crystalReportThongKe";
            this.crystalReportThongKe.Size = new System.Drawing.Size(614, 308);
            this.crystalReportThongKe.TabIndex = 0;
            this.crystalReportThongKe.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 388);
            this.Controls.Add(this.crystalReportThongKe);
            this.MinimizeBox = false;
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportForm_FormClosed);
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportThongKe;
    }
}