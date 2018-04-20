//using System;
//using System.ComponentModel;

//using System.Windows.Forms;
//using System.IO;
//using System.Linq;
//using System.Drawing;

//namespace WindowsFormsApp1
//{
//    public partial class UploadImage : Form
//    {
        
//        TestEntities db = new TestEntities();
//        public UploadImage()
//        {
//            InitializeComponent();
//        }
//        private void Form1_Load(object sender, EventArgs e)
//        {
//            label1.Hide();

//        }

//        String imgsrc = "";
//        private void btnBrowse_Click(object sender, EventArgs e)
//        {
//            OpenFileDialog dialog = new OpenFileDialog();
//            dialog.Filter = dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
//            if (dialog.ShowDialog() == DialogResult.OK)
//            {
//                var size = new FileInfo(dialog.FileName).Length;
//                var maxBytes = 100 * 1024;
//                if (size < maxBytes)
//                {
//                    label1.Show();
//                    imgsrc = dialog.FileName.ToString();
//                    label1.Text = dialog.FileName.ToString();
//                    pictureBox1.ImageLocation = dialog.FileName;
//                }
//                else
//                {

//                    MessageBox.Show("File size: \n" + dialog.FileName + " \n> 100MB !");
//                }




//            }
//        }

//        private void btnSave_Click(object sender, EventArgs e)
//        {
//            saveImages();
//        }

//        private void btnLoad_Click(object sender, EventArgs e)
//        {
//            loadImages(1);
//        }
//        private void saveImages()
//        {
//            try
//            {
//                byte[] images = null;
//                FileStream fs = new FileStream(imgsrc, FileMode.Open, FileAccess.Read);
//                BinaryReader br = new BinaryReader(fs);
//                images = br.ReadBytes((int)fs.Length);

//                var img = new Test() { img = images };
//                db.Tests.Add(img);

//                db.SaveChanges();
//                MessageBox.Show("OK");
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }

//        }
//        private void loadImages(int idUser)
//        {
//            try
//            {


//                var t = db.Tests.FirstOrDefault(i => i.id == idUser);
//                byte[] images = t.img;
//                //pictureBox1.ImageLocation
//                if (images == null)
//                {

//                    pictureBox1.Image = null;

//                }
//                else
//                {
//                    MemoryStream ms = new MemoryStream(images);

//                    var image = Image.FromStream(ms);
//                    pictureBox1.Image = image;

//                }
//            }
//            catch (Exception ex)
//            {

//                MessageBox.Show(ex.Message);
//            }
//        }

       
//    }
//}

