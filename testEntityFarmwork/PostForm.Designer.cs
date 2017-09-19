namespace testEntityFarmwork
{
    partial class PostForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddPost = new MetroFramework.Controls.MetroButton();
            this.btnClearPost = new MetroFramework.Controls.MetroButton();
            this.cbPublish = new MetroFramework.Controls.MetroCheckBox();
            this.cbbUser = new MetroFramework.Controls.MetroComboBox();
            this.tbContent = new MetroFramework.Controls.MetroTextBox();
            this.tbTitle = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgvPost = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSavePost = new MetroFramework.Controls.MetroButton();
            this.btnDeletePost = new MetroFramework.Controls.MetroButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPost)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.btnAddPost);
            this.panel2.Controls.Add(this.btnClearPost);
            this.panel2.Controls.Add(this.cbPublish);
            this.panel2.Controls.Add(this.cbbUser);
            this.panel2.Controls.Add(this.tbContent);
            this.panel2.Controls.Add(this.tbTitle);
            this.panel2.Controls.Add(this.metroLabel3);
            this.panel2.Controls.Add(this.metroLabel2);
            this.panel2.Controls.Add(this.metroLabel1);
            this.panel2.Location = new System.Drawing.Point(20, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 254);
            this.panel2.TabIndex = 13;
            // 
            // btnAddPost
            // 
            this.btnAddPost.Location = new System.Drawing.Point(611, 212);
            this.btnAddPost.Name = "btnAddPost";
            this.btnAddPost.Size = new System.Drawing.Size(115, 29);
            this.btnAddPost.TabIndex = 23;
            this.btnAddPost.Text = "Add New Post";
            this.btnAddPost.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddPost.Click += new System.EventHandler(this.BtnAddPost_Click);
            // 
            // btnClearPost
            // 
            this.btnClearPost.Location = new System.Drawing.Point(490, 212);
            this.btnClearPost.Name = "btnClearPost";
            this.btnClearPost.Size = new System.Drawing.Size(115, 29);
            this.btnClearPost.TabIndex = 23;
            this.btnClearPost.Text = "Clear Text";
            this.btnClearPost.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClearPost.Click += new System.EventHandler(this.btnClearPost_Click);
            // 
            // cbPublish
            // 
            this.cbPublish.AutoSize = true;
            this.cbPublish.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.cbPublish.Location = new System.Drawing.Point(74, 226);
            this.cbPublish.Name = "cbPublish";
            this.cbPublish.Size = new System.Drawing.Size(85, 15);
            this.cbPublish.TabIndex = 22;
            this.cbPublish.Text = "Publish Now";
            this.cbPublish.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbPublish.UseVisualStyleBackColor = true;
            // 
            // cbbUser
            // 
            this.cbbUser.FormattingEnabled = true;
            this.cbbUser.ItemHeight = 23;
            this.cbbUser.Location = new System.Drawing.Point(74, 190);
            this.cbbUser.Name = "cbbUser";
            this.cbbUser.Size = new System.Drawing.Size(121, 29);
            this.cbbUser.TabIndex = 21;
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(74, 40);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(652, 144);
            this.tbContent.TabIndex = 20;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(74, 14);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(652, 23);
            this.tbTitle.TabIndex = 19;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 192);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Author";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 40);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Content";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(19, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(33, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Title";
            // 
            // dgvPost
            // 
            this.dgvPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPost.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPost.Location = new System.Drawing.Point(20, 284);
            this.dgvPost.Name = "dgvPost";
            this.dgvPost.Size = new System.Drawing.Size(746, 250);
            this.dgvPost.TabIndex = 11;
            this.dgvPost.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPost_CellValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnSavePost);
            this.panel1.Controls.Add(this.btnDeletePost);
            this.panel1.Location = new System.Drawing.Point(20, 546);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 33);
            this.panel1.TabIndex = 12;
            // 
            // btnSavePost
            // 
            this.btnSavePost.Location = new System.Drawing.Point(349, 4);
            this.btnSavePost.Name = "btnSavePost";
            this.btnSavePost.Size = new System.Drawing.Size(75, 23);
            this.btnSavePost.TabIndex = 5;
            this.btnSavePost.Text = "Save Change";
            this.btnSavePost.Click += new System.EventHandler(this.BtnSavePost_Click);
            // 
            // btnDeletePost
            // 
            this.btnDeletePost.Location = new System.Drawing.Point(268, 4);
            this.btnDeletePost.Name = "btnDeletePost";
            this.btnDeletePost.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePost.TabIndex = 4;
            this.btnDeletePost.Text = "Delete";
            this.btnDeletePost.Click += new System.EventHandler(this.BtnDeletePost_Click);
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 598);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvPost);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PostForm";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PostForm_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPost)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroButton btnAddPost;
        private MetroFramework.Controls.MetroButton btnClearPost;
        private MetroFramework.Controls.MetroCheckBox cbPublish;
        private MetroFramework.Controls.MetroComboBox cbbUser;
        private MetroFramework.Controls.MetroTextBox tbContent;
        private MetroFramework.Controls.MetroTextBox tbTitle;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dgvPost;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton btnSavePost;
        private MetroFramework.Controls.MetroButton btnDeletePost;
    }
}

