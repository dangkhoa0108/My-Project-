using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
