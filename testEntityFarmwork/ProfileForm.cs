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
    public partial class ProfileForm : Form
    {
        AppEntities db = new AppEntities();
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            var email1 = LoginInfo.email;
            var user = db.users.Where(u => u.email.Equals(email1)).FirstOrDefault();
            txtName.Text = user.username;
            txtMail.Text = email1;
        }

        //back Form
        private void backMainForm()
        {
            var mainForm = new MainForm();
            var profile = new ProfileForm();
            profile.Close();
            mainForm.Show();
        }
        // Close window

        private void ProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainForm = new MainForm();
            var profile = new ProfileForm();
            profile.Close();
            mainForm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateProfile();
        }
        private void updateProfile()
        {
            try
            {
                var email1 = LoginInfo.email;
                user user = db.users.Where(u => u.email.Equals(email1)).FirstOrDefault();
                user.username = txtName.Text;
                user.email = txtMail.Text;

                db.SaveChanges();

                MessageBox.Show("Update successed")
;
            }
            catch { MessageBox.Show("Update failed"); }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            this.Close();
           
            mainForm.Show();
        }
    }
}
