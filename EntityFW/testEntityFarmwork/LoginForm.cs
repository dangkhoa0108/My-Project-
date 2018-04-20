﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace testEntityFarmwork
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        AppEntities _ctx = new AppEntities();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnSubmitLogin_Click(object sender, EventArgs e)
        {
            var inEmail = tbLoginEmail.Text;
            var inPassword = tbLoginPassword.Text;
            if (IsLoggedIn(inEmail, inPassword))
            {
                var i = (from usro in _ctx.user_role
                         join ro in _ctx.roles on usro.role_id equals ro.role_id
                         join us in _ctx.users on usro.user_id equals us.id
                         where (us.email == inEmail)
                         select new {
                             role = ro.role_name
                         }).FirstOrDefault();
                var userDb = (from u in _ctx.users where u.email == inEmail select u).FirstOrDefault();
                var mainForm = new MainForm();
                this.Hide();
                if (userDb != null) LoginInfo.userId = userDb.id;
                LoginInfo.email = inEmail;
                LoginInfo.role = i?.role.ToString();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show(@"Email or password is incorrect", @"Login Fail",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public bool IsValid(string emailaddress)
        {
            try
            {
                var m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        internal bool IsLoggedIn(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || IsValid(email) == false)
            {
                return false;

            }
            else
            {
                // Validator here
                var tempUser = _ctx.users.FirstOrDefault(u=>u.email == email && u.password == password);
                if (tempUser == null)
                {
                    return false;
                }else 
                return true;
            }
        }

        private void BtnShowRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            this.Hide();
            registerForm.Show();
        }

        private void BtnForgetPassword_Click(object sender, EventArgs e)
        {
            var resetPasswordForm = new ResetPasswordForm();
            this.Hide();
            resetPasswordForm.Show();
        }

        private void tbLoginPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
            {
                BtnSubmitLogin_Click(sender, e);
            }
        }

        private void tbLoginEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
            {
                BtnSubmitLogin_Click(sender, e);
            }
        }
    }
}
