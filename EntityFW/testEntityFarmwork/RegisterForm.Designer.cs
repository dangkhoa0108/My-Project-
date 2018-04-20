namespace testEntityFarmwork
{
    partial class RegisterForm
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
            this.cbTerm = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.BtnResetPasword = new MetroFramework.Controls.MetroButton();
            this.BtnShowLogin = new MetroFramework.Controls.MetroButton();
            this.BtnRegister = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtPassword2 = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.LinkTerms = new System.Windows.Forms.LinkLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.LinkTerms);
            this.metroPanel1.Controls.Add(this.cbTerm);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.BtnResetPasword);
            this.metroPanel1.Controls.Add(this.BtnShowLogin);
            this.metroPanel1.Controls.Add(this.BtnRegister);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txtPassword2);
            this.metroPanel1.Controls.Add(this.txtPassword);
            this.metroPanel1.Controls.Add(this.txtEmail);
            this.metroPanel1.Controls.Add(this.txtName);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(2, 28);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(363, 333);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // cbTerm
            // 
            this.cbTerm.AutoSize = true;
            this.cbTerm.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.cbTerm.Location = new System.Drawing.Point(117, 195);
            this.cbTerm.Margin = new System.Windows.Forms.Padding(0);
            this.cbTerm.MaximumSize = new System.Drawing.Size(15, 19);
            this.cbTerm.Name = "cbTerm";
            this.cbTerm.Size = new System.Drawing.Size(15, 19);
            this.cbTerm.TabIndex = 1;
            this.cbTerm.Text = " ";
            this.cbTerm.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbTerm.UseStyleColors = true;
            this.cbTerm.UseVisualStyleBackColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(131, 15);
            this.metroLabel7.MinimumSize = new System.Drawing.Size(70, 30);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(132, 30);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Register";
            this.metroLabel7.UseStyleColors = true;
            // 
            // BtnResetPasword
            // 
            this.BtnResetPasword.Location = new System.Drawing.Point(199, 300);
            this.BtnResetPasword.Name = "BtnResetPasword";
            this.BtnResetPasword.Size = new System.Drawing.Size(142, 23);
            this.BtnResetPasword.TabIndex = 6;
            this.BtnResetPasword.Text = "Forget Password";
            this.BtnResetPasword.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnResetPasword.Click += new System.EventHandler(this.BtnResetPasword_Click);
            // 
            // BtnShowLogin
            // 
            this.BtnShowLogin.Location = new System.Drawing.Point(21, 300);
            this.BtnShowLogin.Name = "BtnShowLogin";
            this.BtnShowLogin.Size = new System.Drawing.Size(142, 23);
            this.BtnShowLogin.TabIndex = 6;
            this.BtnShowLogin.Text = "Login";
            this.BtnShowLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnShowLogin.Click += new System.EventHandler(this.BtnShowLogin_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Highlight = true;
            this.BtnRegister.Location = new System.Drawing.Point(117, 245);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(120, 23);
            this.BtnRegister.TabIndex = 6;
            this.BtnRegister.Text = "Submit";
            this.BtnRegister.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(117, 217);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(97, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "and conditions.";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(131, 195);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(157, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "I have read and accepted";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(27, 157);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(84, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Re-Password";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(27, 128);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Password";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(27, 99);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Email";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(27, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Full Name";
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(117, 153);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '●';
            this.txtPassword2.Size = new System.Drawing.Size(210, 23);
            this.txtPassword2.TabIndex = 2;
            this.txtPassword2.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(117, 124);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(210, 23);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(117, 95);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 23);
            this.txtName.TabIndex = 2;
            // 
            // LinkTerms
            // 
            this.LinkTerms.AutoSize = true;
            this.LinkTerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkTerms.Location = new System.Drawing.Point(285, 196);
            this.LinkTerms.Name = "LinkTerms";
            this.LinkTerms.Size = new System.Drawing.Size(41, 16);
            this.LinkTerms.TabIndex = 10;
            this.LinkTerms.TabStop = true;
            this.LinkTerms.Text = "terms";
            this.LinkTerms.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkTerms_LinkClicked);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 364);
            this.Controls.Add(this.metroPanel1);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton BtnResetPasword;
        private MetroFramework.Controls.MetroButton BtnShowLogin;
        private MetroFramework.Controls.MetroButton BtnRegister;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtPassword2;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroCheckBox cbTerm;
        private System.Windows.Forms.LinkLabel LinkTerms;
    }
}