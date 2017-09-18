namespace testEntityFarmwork
{
    partial class ResetPasswordForm
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.BtnResetShowLogin = new MetroFramework.Controls.MetroButton();
            this.BtnResetShowRegister = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.BtnResetShowRegister);
            this.metroPanel1.Controls.Add(this.BtnResetShowLogin);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroTextBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(7, 26);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(452, 209);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(112, 77);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(321, 23);
            this.metroTextBox1.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Your Email";
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(112, 106);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(59, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Reset";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // BtnResetShowLogin
            // 
            this.BtnResetShowLogin.Location = new System.Drawing.Point(112, 169);
            this.BtnResetShowLogin.Name = "BtnResetShowLogin";
            this.BtnResetShowLogin.Size = new System.Drawing.Size(152, 23);
            this.BtnResetShowLogin.TabIndex = 5;
            this.BtnResetShowLogin.Text = "Login";
            this.BtnResetShowLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnResetShowLogin.Click += new System.EventHandler(this.BtnResetShowLogin_Click);
            // 
            // BtnResetShowRegister
            // 
            this.BtnResetShowRegister.Location = new System.Drawing.Point(281, 169);
            this.BtnResetShowRegister.Name = "BtnResetShowRegister";
            this.BtnResetShowRegister.Size = new System.Drawing.Size(152, 23);
            this.BtnResetShowRegister.TabIndex = 5;
            this.BtnResetShowRegister.Text = "Register";
            this.BtnResetShowRegister.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnResetShowRegister.Click += new System.EventHandler(this.BtnResetShowRegister_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(112, 11);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(127, 25);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Reset Password";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = true;
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 241);
            this.Controls.Add(this.metroPanel1);
            this.Name = "ResetPasswordForm";
            this.Resizable = false;
            this.Text = "ResetPasswordForm";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton BtnResetShowRegister;
        private MetroFramework.Controls.MetroButton BtnResetShowLogin;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}