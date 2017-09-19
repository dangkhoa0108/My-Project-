using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testEntityFarmwork {
    public partial class RegisterForm : MetroFramework.Forms.MetroForm {

        AppEntities db = new AppEntities();
        public RegisterForm() {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e) {

        }

        private void BtnResetPasword_Click(object sender, EventArgs e) {
            var resetPasswordForm = new ResetPasswordForm();
            this.Hide();
            resetPasswordForm.Show();
        }

        private void BtnShowLogin_Click(object sender, EventArgs e) {
            var loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void BtnRegister_Click(object sender, EventArgs e) {

            String name = txtName.Text;
            String email = txtEmail.Text;
            String password = txtPassword.Text;
            var isCheck = cbTerm.Checked;
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password) || !isCheck) {
                MessageBox.Show(@"Wrong Input");
            }
            else {


                try {

                    if (CheckEmailInDb()) {
                        MessageBox.Show("Email exists !!!");
                    }
                    else {
                        if (checkPassword()) {
                            var u = new user() { username = name, email = email, password = password };

                            db.users.Add(u);
                            db.SaveChanges();
                            Mail m = new Mail();
                            m.sendMail(email.ToString());
                            setRoleUser();
                            MessageBox.Show("Register successed!!!");
                            LoginInfo.email = email;
                            LoginInfo.role = "USER";
                            backMainForm();

                        }
                        else {
                            txtPassword.Text = "";
                            txtPassword2.Text = string.Empty;
                            MessageBox.Show("Invalid password");
                        }

                    }
                }
                catch (Exception ex) {

                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }

        }


        private bool CheckEmailInDb() {
            String inEmail = txtName.Text;
            return db.users.Any(e => e.email == inEmail);
        }
        private bool checkPassword() {

            String password = txtPassword.Text;
            String repassword = txtPassword2.Text;
            if (password.Equals(repassword))
                return true;
            return false;
        }

        // set Session
        private void backMainForm() {
            LoginInfo.email = txtEmail.Text;

            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e) {
            //var mainForm = new MainForm();
            //mainForm.Close()
            this.Hide();


        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e) {
            //this.metroToggle1.Checked;
            //if (metroToggle1.Checked) {
            //    BtnRegister.Enabled = true;

            //}
        }

        private void metroLabel5_Click(object sender, EventArgs e) {

        }

        private void setRoleUser() {
            //var query = from u in db.users
            //            select new { u.id };
            //int maxId = query.Max().id;
            int max = db.users.Max(u => u.id);

            try {
                user_role us = new user_role { role_id = 2, user_id = max };
                db.user_role.Add(us);
                db.SaveChanges();
                //MessageBox.Show("Add success!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                throw;

            }
        }

        private void LinkTerms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("You Hate Don Lang", "Our Term", MessageBoxButtons.OKCancel);
        }
    }
}
