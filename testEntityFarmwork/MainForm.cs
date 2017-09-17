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

    public partial class MainForm : Form
    {
        private const int NumberPostPerPage = 16;
        private static int _realPage;
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
            using (var ctx = new AppEntities())
            {
                return ctx.posts
                    .Count(o => o.status == 1);
            }
        }

        private static IEnumerable<post> LoadPostPagination()
        {
            try
            {
                using (var ctx = new AppEntities())
                {
                    var postPaging = ctx.posts
                        .Where(item => item.status == 1)
                        .Distinct()
                        .OrderByDescending(d => d.date_created)
                        .Skip(_realPage * NumberPostPerPage)
                        .Take(NumberPostPerPage)
                        .ToList();
                    return postPaging;
                }
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
            BtnPrevious.Enabled = _realPage != 0;
            BtnNext.Enabled = CountPost() < NumberPostPerPage * _realPage ||
                              CountPost() > NumberPostPerPage * (_realPage + 1);

            lbCurrentPage.Text = _realPage.ToString();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            _realPage--;
            MainForm_Load(sender, e);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            _realPage++;
            MainForm_Load(sender, e);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            using (var ctx = new AppEntities())
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
    }
}