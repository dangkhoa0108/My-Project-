namespace testEntityFarmwork
{
    public partial class MainForm
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
            this.tbSearch = new MetroFramework.Controls.MetroTextBox();
            this.BtnShowProfileForm = new MetroFramework.Controls.MetroButton();
            this.lbAccount = new MetroFramework.Controls.MetroTile();
            this.btnShowCommentForm = new MetroFramework.Controls.MetroButton();
            this.btnShowRoleForm = new MetroFramework.Controls.MetroButton();
            this.lbCurrentPage = new MetroFramework.Controls.MetroLabel();
            this.BtnNext = new MetroFramework.Controls.MetroButton();
            this.BtnPrevious = new MetroFramework.Controls.MetroButton();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.btnShowPostForm = new MetroFramework.Controls.MetroButton();
            this.btnShowUserForm = new MetroFramework.Controls.MetroButton();
            this.ListboxPostNow = new System.Windows.Forms.ListBox();
            this.BtnShowMyPostForm = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.lbClock = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(21, 16);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(450, 23);
            this.tbSearch.TabIndex = 16;
            // 
            // BtnShowProfileForm
            // 
            this.BtnShowProfileForm.Location = new System.Drawing.Point(16, 32);
            this.BtnShowProfileForm.Name = "BtnShowProfileForm";
            this.BtnShowProfileForm.Size = new System.Drawing.Size(98, 25);
            this.BtnShowProfileForm.TabIndex = 4;
            this.BtnShowProfileForm.Text = "Profile";
            this.BtnShowProfileForm.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lbAccount
            // 
            this.lbAccount.ForeColor = System.Drawing.Color.Black;
            this.lbAccount.Location = new System.Drawing.Point(3, 3);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(123, 23);
            this.lbAccount.TabIndex = 3;
            this.lbAccount.Text = "Account";
            this.lbAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAccount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbAccount.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // btnShowCommentForm
            // 
            this.btnShowCommentForm.Location = new System.Drawing.Point(27, 131);
            this.btnShowCommentForm.Name = "btnShowCommentForm";
            this.btnShowCommentForm.Size = new System.Drawing.Size(75, 23);
            this.btnShowCommentForm.TabIndex = 3;
            this.btnShowCommentForm.Text = "Comment";
            this.btnShowCommentForm.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnShowRoleForm
            // 
            this.btnShowRoleForm.Location = new System.Drawing.Point(27, 102);
            this.btnShowRoleForm.Name = "btnShowRoleForm";
            this.btnShowRoleForm.Size = new System.Drawing.Size(75, 23);
            this.btnShowRoleForm.TabIndex = 3;
            this.btnShowRoleForm.Text = "Role";
            this.btnShowRoleForm.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lbCurrentPage
            // 
            this.lbCurrentPage.AutoSize = true;
            this.lbCurrentPage.Location = new System.Drawing.Point(285, 363);
            this.lbCurrentPage.Name = "lbCurrentPage";
            this.lbCurrentPage.Size = new System.Drawing.Size(0, 0);
            this.lbCurrentPage.TabIndex = 15;
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(328, 361);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 23);
            this.BtnNext.TabIndex = 13;
            this.BtnNext.Text = "Next →";
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Location = new System.Drawing.Point(177, 361);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(75, 23);
            this.BtnPrevious.TabIndex = 14;
            this.BtnPrevious.Text = "← Previous";
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Highlight = true;
            this.btnSearch.Location = new System.Drawing.Point(477, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 23);
            this.btnSearch.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnShowPostForm
            // 
            this.btnShowPostForm.Location = new System.Drawing.Point(27, 73);
            this.btnShowPostForm.Name = "btnShowPostForm";
            this.btnShowPostForm.Size = new System.Drawing.Size(75, 23);
            this.btnShowPostForm.TabIndex = 3;
            this.btnShowPostForm.Text = "Post";
            this.btnShowPostForm.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnShowPostForm.Click += new System.EventHandler(this.BtnShowPostForm_Click);
            // 
            // btnShowUserForm
            // 
            this.btnShowUserForm.Location = new System.Drawing.Point(27, 44);
            this.btnShowUserForm.Name = "btnShowUserForm";
            this.btnShowUserForm.Size = new System.Drawing.Size(75, 23);
            this.btnShowUserForm.TabIndex = 3;
            this.btnShowUserForm.Text = "User";
            this.btnShowUserForm.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnShowUserForm.Click += new System.EventHandler(this.BtnShowUserForm_Click);
            // 
            // ListboxPostNow
            // 
            this.ListboxPostNow.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ListboxPostNow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListboxPostNow.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ListboxPostNow.FormattingEnabled = true;
            this.ListboxPostNow.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ListboxPostNow.ItemHeight = 18;
            this.ListboxPostNow.Location = new System.Drawing.Point(21, 59);
            this.ListboxPostNow.Margin = new System.Windows.Forms.Padding(20);
            this.ListboxPostNow.Name = "ListboxPostNow";
            this.ListboxPostNow.Size = new System.Drawing.Size(555, 292);
            this.ListboxPostNow.TabIndex = 10;
            this.ListboxPostNow.DoubleClick += new System.EventHandler(this.ListboxPostNow_DoubleClick);
            // 
            // BtnShowMyPostForm
            // 
            this.BtnShowMyPostForm.Location = new System.Drawing.Point(16, 63);
            this.BtnShowMyPostForm.Name = "BtnShowMyPostForm";
            this.BtnShowMyPostForm.Size = new System.Drawing.Size(98, 25);
            this.BtnShowMyPostForm.TabIndex = 4;
            this.BtnShowMyPostForm.Text = "My Post";
            this.BtnShowMyPostForm.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.BtnShowMyPostForm);
            this.metroPanel2.Controls.Add(this.BtnShowProfileForm);
            this.metroPanel2.Controls.Add(this.lbAccount);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(31, 52);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(129, 100);
            this.metroPanel2.TabIndex = 14;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.btnShowCommentForm);
            this.metroPanel1.Controls.Add(this.btnShowRoleForm);
            this.metroPanel1.Controls.Add(this.btnShowPostForm);
            this.metroPanel1.Controls.Add(this.btnShowUserForm);
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(31, 158);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(129, 172);
            this.metroPanel1.TabIndex = 12;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTile1
            // 
            this.metroTile1.ForeColor = System.Drawing.Color.Black;
            this.metroTile1.Location = new System.Drawing.Point(3, 3);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(123, 23);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Control Panel";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.tbSearch);
            this.metroPanel3.Controls.Add(this.lbCurrentPage);
            this.metroPanel3.Controls.Add(this.BtnNext);
            this.metroPanel3.Controls.Add(this.BtnPrevious);
            this.metroPanel3.Controls.Add(this.btnSearch);
            this.metroPanel3.Controls.Add(this.ListboxPostNow);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(177, 36);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(596, 398);
            this.metroPanel3.TabIndex = 15;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // lbClock
            // 
            this.lbClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbClock.AutoSize = true;
            this.lbClock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbClock.Location = new System.Drawing.Point(524, 10);
            this.lbClock.Name = "lbClock";
            this.lbClock.Size = new System.Drawing.Size(0, 13);
            this.lbClock.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.panel3.Controls.Add(this.lbClock);
            this.panel3.Location = new System.Drawing.Point(4, 442);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(769, 41);
            this.panel3.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(776, 488);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.metroPanel3);
            this.DisplayHeader = false;
            this.Location = new System.Drawing.Point(800, 200);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(500, 30, 0, 0);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox tbSearch;
        private MetroFramework.Controls.MetroButton BtnShowProfileForm;
        private MetroFramework.Controls.MetroTile lbAccount;
        private MetroFramework.Controls.MetroButton btnShowCommentForm;
        private MetroFramework.Controls.MetroButton btnShowRoleForm;
        private MetroFramework.Controls.MetroLabel lbCurrentPage;
        private MetroFramework.Controls.MetroButton BtnNext;
        private MetroFramework.Controls.MetroButton BtnPrevious;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroButton btnShowPostForm;
        private MetroFramework.Controls.MetroButton btnShowUserForm;
        private System.Windows.Forms.ListBox ListboxPostNow;
        private MetroFramework.Controls.MetroButton BtnShowMyPostForm;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.Label lbClock;
        private System.Windows.Forms.Panel panel3;
    }
}