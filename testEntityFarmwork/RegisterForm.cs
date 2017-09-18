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
    public partial class RegisterForm : MetroFramework.Forms.MetroForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnResetPasword_Click(object sender, EventArgs e)
        {
            var resetPasswordForm = new ResetPasswordForm();
            this.Hide();
            resetPasswordForm.Show();
        }

        private void BtnShowLogin_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }
    }
}
