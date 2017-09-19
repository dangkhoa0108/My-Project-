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
    public partial class SetUserRoleForm : Form
    {
        AppEntities db = new AppEntities();
        public SetUserRoleForm()
        {
            InitializeComponent();
            LoadData();
            DataBinding();
        }
        #region methods
        void LoadData()
        {
            dgvSetRole.DataSource = (from usro in db.user_role
                                     join ro in db.roles on usro.role_id equals ro.role_id
                                     join us in db.users on usro.user_id equals us.id
                                     select new
                                     { 
                                         id = usro.role_user_id,
                                         role = ro.role_name,
                                         username = us.username

                                     }).ToList();
            cbUser.DataSource = (from us in db.users
                                 select new
                                 {
                                     id = us.id,
                                     username = us.username
                                 }).ToList();
            cbUser.DisplayMember = "username";
            cbUser.ValueMember = "id";
            cbRole.DataSource = (from ro in db.roles
                                 select new
                                 {
                                     id = ro.role_id,
                                     name = ro.role_name
                                 }).ToList();
            cbRole.DisplayMember = "name";
            cbRole.ValueMember = "id";
        }
        void DataBinding()
        {
            cbUser.DataBindings.Clear();
            cbRole.DataBindings.Clear();
            cbUser.DataBindings.Add(new Binding("Text",dgvSetRole.DataSource, "username"));
            cbRole.DataBindings.Add(new Binding("Text",dgvSetRole.DataSource, "role"));
        }
        void Add()
        {
            try
            {
                user_role us = new user_role { role_id = int.Parse(cbRole.SelectedValue.ToString()), user_id = int.Parse(cbUser.SelectedValue.ToString()) };
                db.user_role.Add(us);
                db.SaveChanges();
                MessageBox.Show("Add success!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                DataBinding();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void Edit()
        {
            try
            {
                int id = int.Parse(dgvSetRole.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
                user_role edit = db.user_role.Find(id);
                edit.role_id = int.Parse(cbRole.SelectedValue.ToString());
                edit.user_id = int.Parse(cbUser.SelectedValue.ToString());
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
        void Delete()
        {
            try
            {
                int id = int.Parse(dgvSetRole.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
                user_role del = db.user_role.Where(u => u.role_user_id == id).SingleOrDefault();
                db.user_role.Remove(del);
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

        private void SetUserRoleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainForm = new MainForm();
            var setRole = new SetUserRoleForm();
            setRole.Close();
            mainForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
