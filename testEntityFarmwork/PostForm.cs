using System;
using System.Data.Entity.Validation;
using System.Windows.Forms;
using System.Data.Entity;
using System.Linq;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace testEntityFarmwork {
    public partial class PostForm : MetroFramework.Forms.MetroForm {

        AppEntities db = new AppEntities();
        String email = LoginInfo.email.ToString();
        String role = LoginInfo.role.ToString();

        public PostForm() {

            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e) {
            if (role.Equals("USER") || role == "USER") {
                cbPublish.Hide();
                //label4.Hide();
                cbbUser.Enabled = false;

            }
            picturePost.Image = Properties.Resources.ClickHere;
            loadUser();
            loadPost();



        }
        //load combobox user
        private void loadUser() {
            var listUser = db.users.ToList();
            cbbUser.DataSource = listUser;
            cbbUser.DisplayMember = "username";
            cbbUser.ValueMember = "id";
        }


        // loadPost
        private void loadPost() {


            var listPost = from p in db.posts
                           select new { p.id, p.post_title, p.post_content, post_author = p.user.username, p.status, p.date_created, p.date_updated };

            dgvPost.DataSource = listPost.ToList();

        }

        //add Post
        private void BtnAddPost_Click(object sender, EventArgs e) {
            var cbStatus = 0;
            if (cbPublish.Checked)
                cbStatus = 1;
            else
                cbStatus = 0;

            byte[] images = null;
            FileStream fs = new FileStream(imgsrc, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            images = br.ReadBytes((int)fs.Length);



            var newPost = new post {
                post_author = int.Parse(cbbUser.SelectedValue.ToString()),
                post_content = tbContent.Text,
                post_title = tbTitle.Text,
                status = cbStatus,
                date_created = DateTime.Now,
                date_updated = DateTime.Now,
                img = images
            };
            try {

                db.posts.Add(newPost);
                db.SaveChanges();
                tbTitle.Clear();
                tbContent.Clear();
                cbPublish.Checked = false;
                loadPost();


            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx) {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors) {
                    foreach (var validationError in validationErrors.ValidationErrors) {
                        string message = $"{validationErrors.Entry.Entity.ToString()}:{validationError.ErrorMessage}";
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }



        private void DgvPost_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            btnSavePost.Enabled = true;
            int id = int.Parse(this.dgvPost.CurrentRow.Cells[0].Value.ToString());

            var post = db.posts.SingleOrDefault(p => p.id == id);
            //post.post_author = int.Parse(cbbUser.SelectedIndex.ToString());
            tbContent.Text = post.post_content;
            tbTitle.Text = post.post_title;
            cbbUser.SelectedValue = post.post_author;
            byte[] images = post.img;
            if (images == null) {

                picturePost.Image = Properties.Resources.ClickHere;
            }
            else {
                MemoryStream ms = new MemoryStream(images);
                var image = Image.FromStream(ms);
                picturePost.Image = image;

            }
            var cbStatus = post.status;
            if (cbStatus == 1) cbPublish.Checked = true;
            else cbPublish.Checked = false;


           
        }

        // update PostList


        private void BtnSavePost_Click(object sender, EventArgs e) {
            updatePost();
        }
        // Close window
        private void PostForm_FormClosed(object sender, FormClosedEventArgs e) {
            var mainForm = new MainForm();
            this.Hide();
            mainForm.Show();

        }
        // delete Post
        private void BtnDeletePost_Click(object sender, EventArgs e) {

            deletePost();
        }
        // delete menuStrip
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            deletePost();
        }
        private void deletePost() {
            int id = int.Parse(this.dgvPost.CurrentRow.Cells[0].Value.ToString());
            DialogResult dr = MessageBox.Show("Are you sure ?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes) {
                try {
                    var post = db.posts.SingleOrDefault(p => p.id == id);
                    db.posts.Remove(post);
                    db.SaveChanges();
                    MessageBox.Show("Delete Sucessed");
                    loadPost();

                }

                catch {
                    MessageBox.Show("Delete Failed");

                }
            }
        }

        // updatePost
        private void updatePost() {
            try {
                int id = int.Parse(this.dgvPost.CurrentRow.Cells[0].Value.ToString());
                post post = db.posts.SingleOrDefault(p => p.id == id);

                post.post_title = tbTitle.Text;
                post.post_content = tbContent.Text;
                post.post_author = int.Parse(cbbUser.SelectedValue.ToString());
                post.date_updated = DateTime.Now;
                var cbStatus = 0;
                if (cbPublish.Checked)
                    cbStatus = cbStatus == 0 ? 1 : 0;
                post.status = cbStatus;
                db.SaveChanges();
                MessageBox.Show("Update Sucessed");
                loadPost();
            }
            catch {
                MessageBox.Show("Update Failed");

            }
        }



        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e) {
            deletePost();
        }

        private void btnClearPost_Click(object sender, EventArgs e) {
            tbTitle.Clear();
            tbContent.Clear();
            cbPublish.Checked = false;
            cbbUser.Refresh();
        }
        String imgsrc = "";
        private void picturePost_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dialog.ShowDialog() == DialogResult.OK) {
                var size = new FileInfo(dialog.FileName).Length;
                var maxBytes = 100 * 1024 * 1024;
                if (size < maxBytes) {

                    imgsrc = dialog.FileName.ToString();

                    picturePost.ImageLocation = dialog.FileName;
                }
                else {

                    MessageBox.Show("File size: \n" + dialog.FileName + " \n> 100MB !");
                }
            }
        }
    }
}