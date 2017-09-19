namespace testEntityFarmwork
{
    partial class PostDetailForm
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
            this.lbPostDetailComment = new System.Windows.Forms.ListBox();
            this.commentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rtbPostDetail = new System.Windows.Forms.RichTextBox();
            this.tbComment = new MetroFramework.Controls.MetroTextBox();
            this.BtnComment = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lbPostTitle = new MetroFramework.Controls.MetroLabel();
            this.lbPostTitlea = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.commentDataSetBindingSource)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPostDetailComment
            // 
            this.lbPostDetailComment.FormattingEnabled = true;
            this.lbPostDetailComment.Location = new System.Drawing.Point(397, 63);
            this.lbPostDetailComment.Name = "lbPostDetailComment";
            this.lbPostDetailComment.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbPostDetailComment.Size = new System.Drawing.Size(423, 238);
            this.lbPostDetailComment.TabIndex = 1;
            // 
            // rtbPostDetail
            // 
            this.rtbPostDetail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbPostDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbPostDetail.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtbPostDetail.Enabled = false;
            this.rtbPostDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPostDetail.ForeColor = System.Drawing.Color.Black;
            this.rtbPostDetail.Location = new System.Drawing.Point(16, 63);
            this.rtbPostDetail.Margin = new System.Windows.Forms.Padding(10);
            this.rtbPostDetail.Name = "rtbPostDetail";
            this.rtbPostDetail.ReadOnly = true;
            this.rtbPostDetail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtbPostDetail.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbPostDetail.Size = new System.Drawing.Size(375, 267);
            this.rtbPostDetail.TabIndex = 0;
            this.rtbPostDetail.Text = "";
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(397, 307);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(342, 23);
            this.tbComment.TabIndex = 4;
            this.tbComment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbComment_KeyPress);
            // 
            // BtnComment
            // 
            this.BtnComment.Location = new System.Drawing.Point(745, 307);
            this.BtnComment.Name = "BtnComment";
            this.BtnComment.Size = new System.Drawing.Size(75, 23);
            this.BtnComment.TabIndex = 5;
            this.BtnComment.Text = "Send";
            this.BtnComment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnComment.Click += new System.EventHandler(this.BtnComment_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lbPostTitle);
            this.metroPanel1.Controls.Add(this.lbPostTitlea);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(16, 25);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(804, 36);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lbPostTitle
            // 
            this.lbPostTitle.AutoSize = true;
            this.lbPostTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbPostTitle.Location = new System.Drawing.Point(58, 2);
            this.lbPostTitle.Name = "lbPostTitle";
            this.lbPostTitle.Size = new System.Drawing.Size(0, 0);
            this.lbPostTitle.TabIndex = 2;
            // 
            // lbPostTitlea
            // 
            this.lbPostTitlea.AutoSize = true;
            this.lbPostTitlea.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbPostTitlea.Location = new System.Drawing.Point(8, 2);
            this.lbPostTitlea.Name = "lbPostTitlea";
            this.lbPostTitlea.Size = new System.Drawing.Size(57, 25);
            this.lbPostTitlea.TabIndex = 2;
            this.lbPostTitlea.Text = "Title : ";
            // 
            // PostDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 351);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.BtnComment);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.lbPostDetailComment);
            this.Controls.Add(this.rtbPostDetail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PostDetailForm";
            this.Resizable = false;
            this.Text = "PostDetail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PostDetailForm_FormClosed);
            this.Load += new System.EventHandler(this.PostDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.commentDataSetBindingSource)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbPostDetailComment;
        private System.Windows.Forms.BindingSource commentDataSetBindingSource;
        private System.Windows.Forms.RichTextBox rtbPostDetail;
        private MetroFramework.Controls.MetroTextBox tbComment;
        private MetroFramework.Controls.MetroButton BtnComment;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lbPostTitle;
        private MetroFramework.Controls.MetroLabel lbPostTitlea;
    }
}