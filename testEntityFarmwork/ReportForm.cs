using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testEntityFarmwork.Report;

namespace testEntityFarmwork
{
    public partial class ReportForm : MetroFramework.Forms.MetroForm
    {
        AppEntities db = new AppEntities();
        public ReportForm()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            var i = from us in db.users
                 join post in db.posts on us.id equals post.post_author
                 select new
                 {
                    username=us.username ?? "No Value",
                    post_title=post.post_title ?? "No Value",
                     date_created=post.date_created.ToString() ?? "No Value",
                     date_updated=post.date_updated.ToString() ?? "No Value"
                 };
            ThongKeBaiViet thongKe = new ThongKeBaiViet();
            thongKe.SetDataSource(i);
            crystalReportThongKe.ReportSource = thongKe;
        }
        private void ReportForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainForm = new MainForm();
            var reportForm = new ReportForm();
            reportForm.Close();
            mainForm.Show();
        }
    }
}
