namespace testEntityFarmwork
{
    partial class LoginForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnForgetPassword = new MetroFramework.Controls.MetroButton();
            this.BtnShowRegister = new MetroFramework.Controls.MetroButton();
            this.BtnSubmitLogin = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbLoginPassword = new MetroFramework.Controls.MetroTextBox();
            this.tbLoginEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Controls.Add(this.BtnForgetPassword);
            this.metroPanel1.Controls.Add(this.BtnShowRegister);
            this.metroPanel1.Controls.Add(this.BtnSubmitLogin);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.tbLoginPassword);
            this.metroPanel1.Controls.Add(this.tbLoginEmail);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(1, 23);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(282, 243);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::testEntityFarmwork.Properties.Resources.SmartOSC;
            this.pictureBox1.Location = new System.Drawing.Point(97, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // BtnForgetPassword
            // 
            this.BtnForgetPassword.Location = new System.Drawing.Point(146, 201);
            this.BtnForgetPassword.Name = "BtnForgetPassword";
            this.BtnForgetPassword.Size = new System.Drawing.Size(127, 23);
            this.BtnForgetPassword.TabIndex = 5;
            this.BtnForgetPassword.Text = "ForgetPassword";
            this.BtnForgetPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnForgetPassword.Click += new System.EventHandler(this.BtnForgetPassword_Click);
            // 
            // BtnShowRegister
            // 
            this.BtnShowRegister.Location = new System.Drawing.Point(11, 201);
            this.BtnShowRegister.Name = "BtnShowRegister";
            this.BtnShowRegister.Size = new System.Drawing.Size(127, 23);
            this.BtnShowRegister.TabIndex = 5;
            this.BtnShowRegister.Text = "Register";
            this.BtnShowRegister.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnShowRegister.Click += new System.EventHandler(this.BtnShowRegister_Click);
            // 
            // BtnSubmitLogin
            // 
            this.BtnSubmitLogin.Highlight = true;
            this.BtnSubmitLogin.Location = new System.Drawing.Point(97, 149);
            this.BtnSubmitLogin.Name = "BtnSubmitLogin";
            this.BtnSubmitLogin.Size = new System.Drawing.Size(70, 23);
            this.BtnSubmitLogin.TabIndex = 4;
            this.BtnSubmitLogin.Text = "Login";
            this.BtnSubmitLogin.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnSubmitLogin.Click += new System.EventHandler(this.BtnSubmitLogin_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(10, 106);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Password";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Email";
            // 
            // tbLoginPassword
            // 
            this.tbLoginPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbLoginPassword.Location = new System.Drawing.Point(97, 102);
            this.tbLoginPassword.Name = "tbLoginPassword";
            this.tbLoginPassword.PasswordChar = '*';
            this.tbLoginPassword.Size = new System.Drawing.Size(176, 23);
            this.tbLoginPassword.TabIndex = 2;
            this.tbLoginPassword.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbLoginPassword.UseStyleColors = true;
            this.tbLoginPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLoginPassword_KeyPress);
            // 
            // tbLoginEmail
            // 
            this.tbLoginEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbLoginEmail.Location = new System.Drawing.Point(97, 73);
            this.tbLoginEmail.Name = "tbLoginEmail";
            this.tbLoginEmail.Size = new System.Drawing.Size(176, 23);
            this.tbLoginEmail.TabIndex = 2;
            this.tbLoginEmail.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbLoginEmail.UseStyleColors = true;
            this.tbLoginEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLoginEmail_KeyPress);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 273);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Resizable = false;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton BtnSubmitLogin;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbLoginPassword;
        private MetroFramework.Controls.MetroTextBox tbLoginEmail;
        private MetroFramework.Controls.MetroButton BtnForgetPassword;
        private MetroFramework.Controls.MetroButton BtnShowRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}