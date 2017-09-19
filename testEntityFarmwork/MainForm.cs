using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace testEntityFarmwork
{
    

    internal struct SomeData
    {
        public int Value { get; set; }
        public string Text { get; set; }
    }

    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        static AppEntities ctx = new AppEntities();
        private const int NumberPostPerPage = 16;
        public static int RealPage;
        private Timer _t;

        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnShowPostForm_Click(object sender, EventArgs e)
        {
            Visible = false;
            var mainForm = new MainForm();
            var postForm = new PostForm();
            mainForm.Hide();
            postForm.Show();
        }

        private void BtnShowUserForm_Click(object sender, EventArgs e)
        {
            Visible = false;
            var mainForm = new MainForm();
            var userForm = new UserForm();
            mainForm.Hide();
            userForm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Close();
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            StartTimer();
            var listPostPagination = LoadPostPagination();
            var postOut = listPostPagination.Select(post => new SomeData
            {
                Value = post.id,
                Text = post.post_title
            })
                .ToList();
            ListboxPostNow.DisplayMember = "Text";
            ListboxPostNow.DataSource = postOut;
            SettingPagination();
        }

        private static int CountPost()
        {
                return ctx.posts
                    .Count(o => o.status == 1);
        }

        private static IEnumerable<post> LoadPostPagination()
        {
            try
            {
                var postPaging = ctx.posts
                    .Where(item => item.status == 1)
                    .Distinct()
                    .OrderByDescending(d => d.date_created)
                    .Skip(RealPage * NumberPostPerPage)
                    .Take(NumberPostPerPage)
                    .ToList();
                return postPaging;
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Console.WriteLine(@"Entity of type {0} in state {1} has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine(@"- Property: {0}, Error: {1}",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        private void StartTimer()
        {
            _t = new Timer { Interval = 1000 };
            _t.Tick += T_Tick;
            _t.Enabled = true;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToString("f");
        }

        private void SettingPagination()
        {
            BtnPrevious.Enabled = RealPage != 0;
            BtnNext.Enabled = CountPost() < NumberPostPerPage * RealPage ||
                              CountPost() > NumberPostPerPage * (RealPage + 1);

            lbCurrentPage.Text = RealPage.ToString();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var postPaging = ctx.posts
                .Where(item => item.status == 1 && item.post_title.Contains(tbSearch.Text))
                .OrderByDescending(d => d.date_created)
                .ToList();
            var postOut = postPaging.Select(post => new SomeData
                {
                    Value = post.id,
                    Text = post.post_title
                })
                .ToList();
            ListboxPostNow.DisplayMember = "Text";
            ListboxPostNow.DataSource = postOut;
            
        }

        private void ListboxPostNow_DoubleClick(object sender, EventArgs e)
        {
            int? value = ((SomeData) ListboxPostNow.SelectedItem).Value;
            var postSelected = (int) value;
            Visible = false;
            var mainForm = new MainForm();
            var postDetailForm = new PostDetailForm(postSelected);
            mainForm.Hide();
            postDetailForm.Show();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {

        }

        private void BtnShowProfileForm_Click(object sender, EventArgs e)
        {
            Visible = false;
            var mainForm = new MainForm();
            var profileForm = new ProfileForm();
            mainForm.Hide();
            profileForm.Show();
        }

        private void btnShowCommentForm_Click(object sender, EventArgs e)
        {
            var commentForm = new CommentForm();
            this.Hide();
            commentForm.Show();
        }

        private void btnShowRoleForm_Click(object sender, EventArgs e)
        {
            var roleForm = new RoleForm();
            this.Hide();
            roleForm.Show();
        }
    }
}