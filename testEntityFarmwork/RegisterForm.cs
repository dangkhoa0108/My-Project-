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


            try {

                if (CheckEmailInDb()) {
                    MessageBox.Show("Email exists !!!");
                }
                else {
                    if (checkPassword()) {
                        var u = new user() { username = name, email = email, password = password };
                        db.users.Add(u);
                        db.SaveChanges();
                        MessageBox.Show("Register successed!!!");
                        backMainForm();
                        Mail m = new Mail();
                        m.sendMail(email.ToString());
                        
                    
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

        private void backMainForm() {
            LoginInfo.email = txtEmail.Text;
           
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e) {
            //var mainForm = new MainForm();
            //mainForm.Close()
            this.Close();
             
         
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
