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
        }

        #region methods
        void LoadData()
        {           
            dgvComment.DataSource = (from cm in db.comments
                                    select new
                                    {
                                        id= cm.id,
                                        content =cm.content_text,
                                        time =cm.time,
                                        author =cm.user.username,
                                        post =cm.post.post_title
                                    
                                    }).ToList();
        }

        #endregion
        private void tbContent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnAddUser.Focus();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbContent.ResetText();
            tbContent.Focus();
        }
    }
}
