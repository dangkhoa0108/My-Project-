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
            this.commentDataSet = new testEntityFarmwork.CommentDataSet();
            this.commentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rtbPostDetail = new System.Windows.Forms.RichTextBox();
            this.tbComment = new MetroFramework.Controls.MetroTextBox();
            this.BtnComment = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.commentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPostDetailComment
            // 
            this.lbPostDetailComment.FormattingEnabled = true;
            this.lbPostDetailComment.Location = new System.Drawing.Point(397, 28);
            this.lbPostDetailComment.Name = "lbPostDetailComment";
            this.lbPostDetailComment.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbPostDetailComment.Size = new System.Drawing.Size(262, 238);
            this.lbPostDetailComment.TabIndex = 1;
            // 
            // commentDataSet
            // 
            this.commentDataSet.DataSetName = "AppDataSet";
            this.commentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commentDataSetBindingSource
            // 
            this.commentDataSetBindingSource.DataSource = this.commentDataSet;
            this.commentDataSetBindingSource.Position = 0;
            // 
            // rtbPostDetail
            // 
            this.rtbPostDetail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbPostDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbPostDetail.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtbPostDetail.Enabled = false;
            this.rtbPostDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPostDetail.ForeColor = System.Drawing.Color.Black;
            this.rtbPostDetail.Location = new System.Drawing.Point(16, 28);
            this.rtbPostDetail.Margin = new System.Windows.Forms.Padding(10);
            this.rtbPostDetail.Name = "rtbPostDetail";
            this.rtbPostDetail.ReadOnly = true;
            this.rtbPostDetail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtbPostDetail.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbPostDetail.Size = new System.Drawing.Size(375, 238);
            this.rtbPostDetail.TabIndex = 0;
            this.rtbPostDetail.Text = "";
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(16, 279);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(563, 23);
            this.tbComment.TabIndex = 4;
            // 
            // BtnComment
            // 
            this.BtnComment.Location = new System.Drawing.Point(586, 278);
            this.BtnComment.Name = "BtnComment";
            this.BtnComment.Size = new System.Drawing.Size(75, 23);
            this.BtnComment.TabIndex = 5;
            this.BtnComment.Text = "Send";
            this.BtnComment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnComment.Click += new System.EventHandler(this.BtnComment_Click);
            // 
            // PostDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 311);
            this.Controls.Add(this.BtnComment);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.lbPostDetailComment);
            this.Controls.Add(this.rtbPostDetail);
            this.Name = "PostDetailForm";
            this.Resizable = false;
            this.Text = "PostDetail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PostDetailForm_FormClosed);
            this.Load += new System.EventHandler(this.PostDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.commentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbPostDetailComment;
        private CommentDataSet commentDataSet;
        private System.Windows.Forms.BindingSource commentDataSetBindingSource;
        private System.Windows.Forms.RichTextBox rtbPostDetail;
        private MetroFramework.Controls.MetroTextBox tbComment;
        private MetroFramework.Controls.MetroButton BtnComment;
    }
}