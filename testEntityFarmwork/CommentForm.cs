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
    public partial class CommentForm : Form
    {
        AppEntities db = new AppEntities();
        public CommentForm()
        {
            InitializeComponent();
            LoadData();
            DataBinding();
        }

        #region methods
        void LoadData()
        {
            dgvComment.DataSource = (from cm in db.comments
                                     select new
                                     {
                                         id = cm.id,
                                         content_text = cm.content_text,
                                         time = cm.time,
                                         author = cm.user.username,
                                         post = cm.post.post_title

                                     }).ToList();
            cbAuthor.DataSource = (from au in db.users
                                   select new
                                   {
                                       username = au.username,
                                       id=au.id
                                   }).ToList();
            cbAuthor.DisplayMember = "username";
            cbAuthor.ValueMember = "id";

            cbPost.DataSource = (from po in db.posts
                                 select new
                                 {
                                     post_title = po.post_title,
                                     id = po.id
                                 }).ToList();
            cbPost.DisplayMember = "post_title";
            cbPost.ValueMember = "id";
        }
        void DataBinding()
        {
            tbContent.DataBindings.Clear();
            cbAuthor.DataBindings.Clear();
            cbPost.DataBindings.Clear();
            tbContent.DataBindings.Add(new Binding("Text", dgvComment.DataSource, "content_text"));
            cbAuthor.DataBindings.Add(new Binding("Text", dgvComment.DataSource, "author"));
            cbPost.DataBindings.Add(new Binding("Text", dgvComment.DataSource, "post"));
        }
        void AddComment()
        {
            try
            {
                comment cmt = new comment { content_text = tbContent.Text, time = DateTime.Now, author = int.Parse(cbAuthor.SelectedValue.ToString()), post_id = int.Parse(cbPost.SelectedValue.ToString()) };
                db.comments.Add(cmt);
                db.SaveChanges();
                LoadData();
                DataBinding();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void EditComment()
        {
            try
            {
                int id = int.Parse(dgvComment.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
                comment edit = db.comments.Find(id);
                edit.content_text = tbContent.Text;
                edit.author = int.Parse(cbAuthor.SelectedValue.ToString());
                edit.post_id = int.Parse(cbPost.SelectedValue.ToString());
                edit.time = DateTime.Now;
                db.SaveChanges();
                MessageBox.Show("Edit success", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                DataBinding();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void DeleteComment()
        {
            try
            {
                int id = int.Parse(dgvComment.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
                comment del = db.comments.Where(u => u.id == id).SingleOrDefault();
                db.comments.Remove(del);
                db.SaveChanges();
                MessageBox.Show("Delete success", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                DataBinding();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        #endregion
        private void tbContent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnAddUser.Focus();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddComment();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditComment();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DeleteComment();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadData();
            tbContent.ResetText();
            tbContent.Focus();
        }

        private void CommentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainForm = new MainForm();
            var commentForm = new CommentForm();
            commentForm.Close();
            mainForm.Show();
        }
    }
}
