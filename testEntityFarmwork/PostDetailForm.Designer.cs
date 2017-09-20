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
            this.tbComment = new MetroFramework.Controls.MetroTextBox();
            this.BtnComment = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lbPostTitle = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPostIndexStatus = new MetroFramework.Controls.MetroLabel();
            this.BtnLikePost = new MetroFramework.Controls.MetroButton();
            this.imgPostDetail = new System.Windows.Forms.PictureBox();
            this.xxx = new MetroFramework.Controls.MetroPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbUserPost = new MetroFramework.Controls.MetroLabel();
            this.imgAvatar = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rtbPostDetail = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.commentDataSetBindingSource)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPostDetail)).BeginInit();
            this.xxx.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPostDetailComment
            // 
            this.lbPostDetailComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPostDetailComment.FormattingEnabled = true;
            this.lbPostDetailComment.ItemHeight = 18;
            this.lbPostDetailComment.Location = new System.Drawing.Point(3, 3);
            this.lbPostDetailComment.Name = "lbPostDetailComment";
            this.lbPostDetailComment.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbPostDetailComment.Size = new System.Drawing.Size(552, 238);
            this.lbPostDetailComment.TabIndex = 1;
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(3, 247);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(439, 23);
            this.tbComment.TabIndex = 4;
            this.tbComment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbComment_KeyPress);
            // 
            // BtnComment
            // 
            this.BtnComment.Location = new System.Drawing.Point(448, 247);
            this.BtnComment.Name = "BtnComment";
            this.BtnComment.Size = new System.Drawing.Size(104, 23);
            this.BtnComment.TabIndex = 5;
            this.BtnComment.Text = "Send";
            this.BtnComment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnComment.Click += new System.EventHandler(this.BtnComment_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lbPostTitle);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(16, 25);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(530, 36);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lbPostTitle
            // 
            this.lbPostTitle.AutoSize = true;
            this.lbPostTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbPostTitle.Location = new System.Drawing.Point(13, 6);
            this.lbPostTitle.Name = "lbPostTitle";
            this.lbPostTitle.Size = new System.Drawing.Size(0, 0);
            this.lbPostTitle.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbPostIndexStatus);
            this.panel1.Controls.Add(this.BtnLikePost);
            this.panel1.Controls.Add(this.imgPostDetail);
            this.panel1.Location = new System.Drawing.Point(16, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 504);
            this.panel1.TabIndex = 8;
            // 
            // lbPostIndexStatus
            // 
            this.lbPostIndexStatus.AutoSize = true;
            this.lbPostIndexStatus.Location = new System.Drawing.Point(79, 472);
            this.lbPostIndexStatus.Name = "lbPostIndexStatus";
            this.lbPostIndexStatus.Size = new System.Drawing.Size(0, 0);
            this.lbPostIndexStatus.TabIndex = 2;
            // 
            // BtnLikePost
            // 
            this.BtnLikePost.Location = new System.Drawing.Point(7, 469);
            this.BtnLikePost.Name = "BtnLikePost";
            this.BtnLikePost.Size = new System.Drawing.Size(60, 23);
            this.BtnLikePost.Style = MetroFramework.MetroColorStyle.Blue;
            this.BtnLikePost.TabIndex = 1;
            this.BtnLikePost.Text = "Like";
            this.BtnLikePost.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnLikePost.Click += new System.EventHandler(this.BtnLikePost_Click);
            // 
            // imgPostDetail
            // 
            this.imgPostDetail.Location = new System.Drawing.Point(0, 3);
            this.imgPostDetail.Name = "imgPostDetail";
            this.imgPostDetail.Size = new System.Drawing.Size(527, 454);
            this.imgPostDetail.TabIndex = 0;
            this.imgPostDetail.TabStop = false;
            this.imgPostDetail.WaitOnLoad = true;
            // 
            // xxx
            // 
            this.xxx.AutoScroll = true;
            this.xxx.AutoSize = true;
            this.xxx.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.xxx.Controls.Add(this.rtbPostDetail);
            this.xxx.HorizontalScrollbar = true;
            this.xxx.HorizontalScrollbarBarColor = true;
            this.xxx.HorizontalScrollbarHighlightOnWheel = false;
            this.xxx.HorizontalScrollbarSize = 10;
            this.xxx.Location = new System.Drawing.Point(119, 3);
            this.xxx.Name = "xxx";
            this.xxx.Size = new System.Drawing.Size(436, 207);
            this.xxx.TabIndex = 8;
            this.xxx.VerticalScrollbar = true;
            this.xxx.VerticalScrollbarBarColor = true;
            this.xxx.VerticalScrollbarHighlightOnWheel = false;
            this.xxx.VerticalScrollbarSize = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbUserPost);
            this.panel2.Controls.Add(this.imgAvatar);
            this.panel2.Controls.Add(this.xxx);
            this.panel2.Location = new System.Drawing.Point(552, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 210);
            this.panel2.TabIndex = 9;
            // 
            // lbUserPost
            // 
            this.lbUserPost.AutoSize = true;
            this.lbUserPost.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbUserPost.Location = new System.Drawing.Point(3, 123);
            this.lbUserPost.MaximumSize = new System.Drawing.Size(117, 117);
            this.lbUserPost.Name = "lbUserPost";
            this.lbUserPost.Size = new System.Drawing.Size(0, 0);
            this.lbUserPost.TabIndex = 10;
            this.lbUserPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbUserPost.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // imgAvatar
            // 
            this.imgAvatar.Location = new System.Drawing.Point(3, 3);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.Size = new System.Drawing.Size(110, 117);
            this.imgAvatar.TabIndex = 9;
            this.imgAvatar.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbPostDetailComment);
            this.panel3.Controls.Add(this.tbComment);
            this.panel3.Controls.Add(this.BtnComment);
            this.panel3.Location = new System.Drawing.Point(552, 283);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(569, 288);
            this.panel3.TabIndex = 10;
            // 
            // rtbPostDetail
            // 
            this.rtbPostDetail.Location = new System.Drawing.Point(3, 3);
            this.rtbPostDetail.Multiline = true;
            this.rtbPostDetail.Name = "rtbPostDetail";
            this.rtbPostDetail.Size = new System.Drawing.Size(430, 201);
            this.rtbPostDetail.TabIndex = 2;
            // 
            // PostDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 575);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroPanel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPostDetail)).EndInit();
            this.xxx.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbPostDetailComment;
        private System.Windows.Forms.BindingSource commentDataSetBindingSource;
        private MetroFramework.Controls.MetroTextBox tbComment;
        private MetroFramework.Controls.MetroButton BtnComment;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lbPostTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgPostDetail;
        private MetroFramework.Controls.MetroPanel xxx;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroLabel lbPostIndexStatus;
        private MetroFramework.Controls.MetroButton BtnLikePost;
        private System.Windows.Forms.PictureBox imgAvatar;
        private MetroFramework.Controls.MetroLabel lbUserPost;
        private MetroFramework.Controls.MetroTextBox rtbPostDetail;
    }
}