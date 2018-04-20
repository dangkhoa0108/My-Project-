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
    public partial class RoleForm : MetroFramework.Forms.MetroForm
    {
        AppEntities db = new AppEntities();
        public RoleForm()
        {
            InitializeComponent();
            LoadData();
            DataBinding();
        }
        #region methods
        void LoadData()
        {
            dgvRole.DataSource = (from ro in db.roles
                                  select new
                                  {
                                      ro.role_id,
                                      ro.role_name
                                  }).ToList();
        }
        void DataBinding()
        {
            tbRoleName.DataBindings.Clear();
            tbRoleName.DataBindings.Add(new Binding("Text", dgvRole.DataSource, "role_name"));

        }
        void Add()
        {
            try
            {
                role r = new role { role_name = tbRoleName.Text };
                db.roles.Add(r);
                db.SaveChanges();
                LoadData();
                DataBinding();
            }
            catch ( Exception ex) 
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void Edit()
        {
            try
            {
                int id = int.Parse(dgvRole.SelectedCells[0].OwningRow.Cells["role_id"].Value.ToString());
                role edit = db.roles.Find(id);
                edit.role_name = tbRoleName.Text;
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
                int id = int.Parse(dgvRole.SelectedCells[0].OwningRow.Cells["role_id"].Value.ToString());
                role del = db.roles.Where(u => u.role_id == id).SingleOrDefault();
                db.roles.Remove(del);
                db.SaveChanges();
                MessageBox.Show("Delete success!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void tbRoleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnAdd.Focus();
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

        private void RoleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainForm = new MainForm();
            var roleForm = new RoleForm();
            roleForm.Hide();
            mainForm.Show();
        }

        private void btnSetRole_Click(object sender, EventArgs e)
        {
            var roleForm = new RoleForm();
            var setRole = new SetUserRoleForm();
            roleForm.Hide();
            setRole.Show();
        }
    }
}
