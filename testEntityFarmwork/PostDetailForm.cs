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
    public partial class PostDetailForm : Form
    {
        private readonly int _postSelect;
        public PostDetailForm()
        {
            InitializeComponent();
        }

        internal struct SomeData
        {
            public string Text { get; set; }
        }

        public PostDetailForm(int postSelected)
        {
            _postSelect = postSelected;
            InitializeComponent();
        }

        private void PostDetail_Load(object sender, EventArgs e)
        {

            var post = GetPost(_postSelect);
            rtbPostDetail.Text = post.post_content;
            var postDetailForm = new PostDetailForm {Text = post.post_title};
            var comments = GetCommentsByPost(_postSelect);
            var commentOut = (from comment in comments
                let username = GetUsernameById(comment.author)
                let dateTime = comment.time
                where dateTime != null
                let timeComment = (DateTime) dateTime
                where username != null && comment.content_text != null
                select "[ " + username.ToString() + " | " + timeComment.ToString("t") + "] : " + comment.content_text
                into commentFormat
                select new SomeData()
                {
                    Text = commentFormat
                }).ToList();
            lbPostDetailComment.DisplayMember = "Text";
            lbPostDetailComment.DataSource = commentOut;
        }

        private static string GetUsernameById(int id)
        {
            using (var ctx = new AppEntities())
            {
                return ctx.users.Find(id)?.username.ToString();
            }
        }

        private static post GetPost(int postId)
        {
            using (var ctx = new AppEntities())
            {
                return ctx.posts.Find(postId);
            }
        }

        private static IEnumerable<comment> GetCommentsByPost(int postId)
        {
            using (var ctx = new AppEntities())
            {
                return ctx.comments
                    .Where(item => item.post_id == postId)
                    .OrderByDescending(o => o.time)
                    .ToList();
            }
        }

        private void BtnComment_Click(object sender, EventArgs e)
        {
            using (var ctx = new AppEntities())
            {
                ctx.comments.Add(new comment()
                {
                    content_text = tbComment.Text,
                    time = DateTime.Now,
                    post_id = _postSelect,
                    author = 1,
                    
                });
                ctx.SaveChanges();
                tbComment.Clear();
                PostDetail_Load(sender, e);
            }
        }

        //test
        private void PostDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
