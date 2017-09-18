using System;
using System.Data.Entity.Validation;
using System.Windows.Forms;
using System.Data.Entity;
using System.Linq;
namespace testEntityFarmwork {
    public partial class PostForm : Form {

        AppEntities db = new AppEntities();
        public PostForm() {

            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e) {

            loadUser();
            loadPost();
            DataBinding();

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
                cbStatus = cbStatus == 0 ? 1 : 0;

            var newPost = new post {
                post_author = int.Parse(cbbUser.SelectedValue.ToString()),
                post_content = tbContent.Text,
                post_title = tbTitle.Text,
                status = cbStatus,
                date_created = DateTime.Now,
                date_updated = DateTime.Now
            };
            try {

                db.posts.Add(newPost);
                db.SaveChanges();
                tbTitle.Clear();
                tbContent.Clear();
                cbPublish.Checked = false;
                loadPost();
                DataBinding();

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
        }

        // update PostList


        private void BtnSavePost_Click(object sender, EventArgs e) {

        }
        // Close window
        private void PostForm_FormClosed(object sender, FormClosedEventArgs e) {
            var mainForm = new MainForm();
            var postForm = new PostForm();
            postForm.Close();
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


                post.post_author = int.Parse(cbbUser.SelectedValue.ToString());
                post.post_content = tbContent.Text;
                post.post_title = tbTitle.Text;

                post.date_updated = DateTime.Now;
                var cbStatus = 0;
                if (cbPublish.Checked)
                    cbStatus = cbStatus == 0 ? 1 : 0;
                post.status = cbStatus;
                db.SaveChanges();
                MessageBox.Show("Update Sucessed");
            }
            catch {
                MessageBox.Show("Update Failed");

            }
        }

        void DataBinding() {
            tbTitle.DataBindings.Clear();
            tbContent.DataBindings.Clear();
            tbTitle.DataBindings.Add(new Binding("Text", dgvPost.DataSource, "post_title"));
            tbContent.DataBindings.Add(new Binding("Text", dgvPost.DataSource, "post_content"));
            cbPublish.DataBindings.Add(new Binding("Checked", dgvPost.DataSource, "status"));
            if (cbPublish.Text == "1") {
                cbPublish.Enabled = true;
            }
            else { cbPublish.Checked = false; }

        }


    }
}