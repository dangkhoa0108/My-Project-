using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testEntityFarmwork
{
    public partial class ResetPasswordForm : MetroFramework.Forms.MetroForm
    {
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
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress("smartosc.net@gmail.com");
                message.To.Add(new MailAddress(inEmail.ToString()));
                message.Subject = "Test";
                message.Body = "Content";

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("smartosc.net@gmail.com", "123456789asdasd");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"err: " + ex.Message);
            }
        }
    }
}
