using System;
using System.Windows.Forms;
using System.Linq;

namespace testEntityFarmwork
{
    public partial class UserForm : MetroFramework.Forms.MetroForm
    {
        AppEntities db = new AppEntities();

        public UserForm()
        {
            InitializeComponent();
            LoadData();
            DataBinding();
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainForm = new MainForm();
            var userForm = new UserForm();
            userForm.Close();
            mainForm.Show();
        }

        #region methods
        void LoadData()
        {
            var listUser = from us in db.users select new { id = us.id, username = us.username, password = us.password, email = us.email };
            dgvUser.DataSource = listUser.ToList();
        }
        void DataBinding()
        {
            tbUsername.DataBindings.Clear();
            tbPassword.DataBindings.Clear();
            tbEmail.DataBindings.Clear();
            tbUsername.DataBindings.Add(new Binding("Text", dgvUser.DataSource, "username"));
            tbPassword.DataBindings.Add(new Binding("Text", dgvUser.DataSource, "password"));
            tbEmail.DataBindings.Add(new Binding("Text", dgvUser.DataSource, "email"));
        }
        void AddUser()
        {
            try
            {
                string emailcheck = tbEmail.Text.ToString();
                var check = db.users.Where(us => us.email.Equals(emailcheck)).SingleOrDefault();
                if (check == null)
                {
                    user user = new user { username = tbUsername.Text, password = tbPassword.Text, email = tbEmail.Text };
                    db.users.Add(user);
                    db.SaveChanges();
                    MessageBox.Show("Add success", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    DataBinding();
                }
                else MessageBox.Show("User already!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }

        }
        void EditUser()
        {
            try
            {
                int id = int.Parse(dgvUser.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
                user edit = db.users.Find(id);
                edit.username = tbUsername.Text;
                edit.password = tbPassword.Text;
                edit.email = tbEmail.Text;
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
        void DeleteUser()
        {
            try
            {
                int id = int.Parse(dgvUser.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
                user del = db.users.Where(u => u.id == id).SingleOrDefault();
                db.users.Remove(del);
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

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditUser();
        }

        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                tbEmail.Focus();
        }

        private void tbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                tbPassword.Focus();
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnAdd.Focus();
        }
    }
}