using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testEntityFarmwork {
    public partial class ProfileForm : MetroFramework.Forms.MetroForm {
        AppEntities db = new AppEntities();
        String imgsrc = "";
        public ProfileForm() {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e) {
            var email1 = LoginInfo.email.ToString();
            txtRole.Enabled = false;
            txtMail.Enabled = false;
            try {
                var user = db.users.Where(u => u.email.Equals(email1)).FirstOrDefault();
                txtName.Text = user.username;
                txtMail.Text = email1;
                txtRole.Text = LoginInfo.role;
                byte[] images = user.img;
                if (images == null) {
                    //avatar.Image = null;
                    avatar.Image = Properties.Resources.SmartOSC;
                    //avatar.Image = Image.FromFile(@"Resources\SmartOSC.png");
                }
                else {
                    MemoryStream ms = new MemoryStream(images);
                    var image = Image.FromStream(ms);
                    avatar.Image = image;

                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        //back Form
        private void backMainForm() {
            var mainForm = new MainForm();
            var profile = new ProfileForm();
            profile.Hide();
            mainForm.Show();
        }
        // Close window

        private void ProfileForm_FormClosing(object sender, FormClosingEventArgs e) {
            var mainForm = new MainForm();
            var profile = new ProfileForm();
            profile.Hide();
            mainForm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            updateProfile();
        }
        private void updateProfile() {
            try {
                var email1 = LoginInfo.email;
                user user = db.users.Where(u => u.email.Equals(email1)).FirstOrDefault();
                user.username = txtName.Text;
                user.email = txtMail.Text;


                byte[] images = null;
                FileStream fs = new FileStream(imgsrc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                images = br.ReadBytes((int)fs.Length);
                user.img = images;
                db.SaveChanges();

                MessageBox.Show("Update successed")
;
            }
            catch (Exception ex) {
                MessageBox.Show("Update failed \n" + ex.Message);
            }

        }

        private void btnBack_Click(object sender, EventArgs e) {
            var mainForm = new MainForm();
            this.Hide();

            mainForm.Show();
        }

        private void BtnUpload_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dialog.ShowDialog() == DialogResult.OK) {
                var size = new FileInfo(dialog.FileName).Length;
                var maxBytes = 100 * 1024 * 1024; // Max 100 MB
                if (size < maxBytes) {

                    imgsrc = dialog.FileName.ToString();

                    avatar.ImageLocation = dialog.FileName;
                }
                else {

                    MessageBox.Show("File size: \n" + dialog.FileName + " \n> 100MB !");
                }




            }


        }

    }
}
