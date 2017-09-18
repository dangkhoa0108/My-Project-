using System;
using System.Data.Entity.Validation;
using System.Windows.Forms;

namespace testEntityFarmwork
{
    public partial class PostForm : Form
    {
        public PostForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appDataSet3.users' table. You can move, or remove it, as needed.
            //usersTableAdapter.Fill(PostDataset.users);
            // TODO: This line of code loads data into the 'appDataSet2.posts' table. You can move, or remove it, as needed.
        }

        private void BtnAddPost_Click(object sender, EventArgs e)
        {
            var cbStatus = 0;
            if (cbPublish.Checked)
                cbStatus = cbStatus == 0 ? 1 : 0;

            var newPost = new post
            {
                post_author = int.Parse(cbbUser.SelectedValue.ToString()),
                post_content = tbContent.Text,
                post_title = tbTitle.Text,
                status = cbStatus,
                date_created = DateTime.Now,
                date_updated = DateTime.Now
            };
            try
            {
                using (var ctx = new AppEntities())
                {
                    ctx.posts.Add(newPost);
                    ctx.SaveChanges();
                    tbTitle.Clear();
                    tbContent.Clear();
                    cbPublish.Checked = false;
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = $"{validationErrors.Entry.Entity.ToString()}:{validationError.ErrorMessage}";
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }
        

        private void BtnDeletePost_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dgvPost.SelectedCells)
                if (oneCell.Selected)
                    dgvPost.Rows.RemoveAt(oneCell.RowIndex);
        }

        private void DgvPost_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnSavePost.Enabled = true;
        }

        private void BtnSavePost_Click(object sender, EventArgs e)
        {
        }

        private void PostForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainForm = new MainForm();
            var postForm = new PostForm();
            postForm.Close();
            mainForm.Show();
        }
    }
}