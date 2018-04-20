using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testEntityFarmwork
{
    public partial class ResetPasswordForm : MetroFramework.Forms.MetroForm
    {
        AppEntities ctx = new AppEntities();

        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void BtnResetShowLogin_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void BtnResetShowRegister_Click(object sender, EventArgs e)
        {
            var regiserForm = new RegisterForm();
            this.Hide();
            regiserForm.Show();
        }

        private void BtnResetPassword_Click(object sender, EventArgs e)
        {
            var inEmail = tbEmailResetPassword.Text;

            if (!CheckEmailInDb(inEmail))
            {
                MessageBox.Show(@"Email not found.");
            }
            else
            {
                var tempPassword = CreatePassword(8);
                UpdatePassword(inEmail, tempPassword);
                try
                {
                    MailMessage message = new MailMessage();
                    SmtpClient smtp = new SmtpClient();

                    message.From = new MailAddress("smartosc.net@gmail.com");
                    message.To.Add(new MailAddress(inEmail.ToString()));
                    message.Subject = "Reset Password";
                    message.Body = "Hi " + inEmail + " Your new password has been reset is : " + tempPassword;

                    smtp.Port = 587;
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = new NetworkCredential("smartosc.net@gmail.com", "123456789asdasd");
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(message);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"err: " + ex.Message);
                }
                MessageBox.Show(@"Nice ! You can login now");
            }
        }

        private bool CheckEmailInDb(string inEmail)
        {
            return ctx.users.Any(e => e.email == inEmail);
        }

        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        private void UpdatePassword(string inEmail, string inPassword)
        {
            (from p in ctx.users
                where p.email == inEmail
                select p).ToList().ForEach(x => x.password = inPassword);
            ctx.SaveChanges();

        }
    }
}
