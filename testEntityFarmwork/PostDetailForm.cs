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
using MetroFramework;

namespace testEntityFarmwork
{
    public partial class PostDetailForm : MetroFramework.Forms.MetroForm
    {
        static AppEntities ctx = new AppEntities();
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
            lbPostTitle.Text = post.post_title;
            rtbPostDetail.Text = post.post_content;
            byte[] avatar = GetUserOwnPost().img;
            byte[] images = post.img;
            if (avatar == null)
            {
                imgAvatar.Image = Properties.Resources.SmartOSC;
            }
            else
            {
                MemoryStream ms = new MemoryStream(avatar);
                var avatars = Image.FromStream(ms);
                imgAvatar.Image = avatars;
                imgAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (images == null)
            {
                imgPostDetail.Image = Properties.Resources.SmartOSC;
            }
            else
            {
                MemoryStream ms = new MemoryStream(images);
                var image = Image.FromStream(ms);
                imgPostDetail.Image = image;
                imgPostDetail.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            BtnLikePost.Highlight = CheckIsLike(_postSelect, LoginInfo.userId);
            lbPostIndexStatus.Text = $@"{CountLike()} people Like and have {CountComment()} comment in this post";
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
            return ctx.users.Find(id)?.username.ToString();
        }

        private static post GetPost(int postId)
        {
            return ctx.posts.Find(postId);
        }

        private static IEnumerable<comment> GetCommentsByPost(int postId)
        {
            return ctx.comments
                .Where(item => item.post_id == postId)
                .OrderByDescending(o => o.time)
                .ToList();
        }

        private void BtnComment_Click(object sender, EventArgs e)
        {
            ctx.comments.Add(new comment()
            {
                content_text = tbComment.Text,
                time = DateTime.Now,
                post_id = _postSelect,
                author = LoginInfo.userId,
                    
            });
            ctx.SaveChanges();
            tbComment.Clear();
            PostDetail_Load(sender, e);
        }

        private void PostDetailForm_FormClosed(object sender, FormClosingEventArgs e)
        {
            var mainForm = new MainForm();
            var postDetailForm = new PostDetailForm();
            mainForm.Show();
            postDetailForm.Close();
        }

        private void tbComment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                BtnComment_Click(sender, e);
            }
            
        }

        private void BtnLikePost_Click(object sender, EventArgs e)
        {
            if (!CheckIsLike(_postSelect, LoginInfo.userId))
            {   
                try
                {
                    ctx.like_post.Add(new like_post
                    {
                        post_id = _postSelect,
                        user_id = LoginInfo.userId
                    });
                    ctx.SaveChanges();
                    BtnLikePost.Theme = MetroThemeStyle.Light;
                    BtnLikePost.Highlight = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                try
                {
                    var item = ctx.like_post.FirstOrDefault(x => x.post_id == _postSelect && x.user_id == LoginInfo.userId);
                    ctx.like_post.Remove(item ?? throw new InvalidOperationException());
                    BtnLikePost.Highlight = false;
                    ctx.SaveChanges();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
            }
        }
        private bool CheckIsLike(int postId, int userId)
        {
            return (from c in ctx.like_post
                where c.post_id == postId && c.user_id == userId
                select c
            ).Any();
        }

        private int CountLike()
        {
            return ctx.like_post.Count(x => x.post_id == _postSelect && x.user_id == LoginInfo.userId);
        }

        private int CountComment()
        {
            return ctx.comments.Count(x => x.post_id == _postSelect);
        }

        private user GetUserOwnPost()
        {
            return (from p in ctx.posts where p.id == _postSelect select p.user).Single();
        }
    }
}
