using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application_D2.Models;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Application_D2
{
    public partial class Register : Form
    {
        Appcontext db;
        public Register()
        {
            InitializeComponent();
            db = new Appcontext();
            txt_password.PasswordChar = '*';
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Click(object sender, EventArgs e)
        {
            Author a = new Author()
            {

                Name = txt_name.Text,
                Age = int.Parse(txt_age.Text),
                Username = txt_username.Text,
                Password = txt_password.Text,
            };
            if (pictureBox1.Image != null)
            {
                System.Drawing.Image image = pictureBox1.Image;
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    a.photo = ms.ToArray();
                }
            }
            db.Authors.Add(a);
            var result = db.Authors.Where(a => a.Username == txt_username.Text).FirstOrDefault();
            if (result == null)
            {
                db.SaveChanges();
                Message message = new Message("Account created successfully", 'g', txt_username.Text);
                message.ShowDialog();
                this.Close();
            }
            else
            {
                Message message = new Message("This username used", 'r', "");
                message.ShowDialog();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
            }

        }
    }
}
