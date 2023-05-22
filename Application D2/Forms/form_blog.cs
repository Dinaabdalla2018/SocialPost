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

namespace Application_D2
{
    public partial class form_blog : Form
    {
        Appcontext db;
        public form_blog()
        {
            InitializeComponent();
            db = new Appcontext();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Blog plog = new Blog()
            {
                Name = txt_name.Text,
                Desc = txt_desc.Text,
            };
            db.Blogs.Add(plog);
            db.SaveChanges();

            txt_name.Text = txt_desc.Text = "";
            blog_combo.DisplayMember = "Name";
            blog_combo.ValueMember = "Id";
            blog_combo.DataSource = db.Blogs.ToList();
        }

        private void form_blog_Load(object sender, EventArgs e)
        {
            blog_combo.DisplayMember = "Name";
            blog_combo.ValueMember = "Id";
            blog_combo.DataSource = db.Blogs.ToList();
            loadPost();

        }
        Region get_region(PictureBox pictureBox)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox.Width - 3, pictureBox.Height - 3);
            Region rg = new Region(gp);
            return rg;
        }
        void loadPost()
        {

            int index_plog = (int)blog_combo.SelectedValue;
            var posts_ = db.Posts.Select(p => new { id = p.Id, p.desc, p.title, p.date_, p.author, p.blog_id }).Where(a => a.blog_id == index_plog);
            int x = 167, y = 625;

            foreach (var item in posts_)
            {

                // linkLabel6
                LinkLabel LU = new LinkLabel();
                LU.AutoSize = true;
                LU.Font = new Font("Georgia", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
                LU.LinkColor = Color.Black;
                LU.Location = new Point(117, 66);
                LU.Margin = new Padding(6, 0, 6, 0);
                LU.Name = "LU" + item.id;
                LU.Size = new Size(211, 27);
                LU.TabIndex = 4;
                LU.TabStop = true;
                LU.Text = item.author.Name;
                // 
                // pictureBox3
                // 
                PictureBox picture = new PictureBox();
                if (item.author.photo != null)
                {
                    byte[] imageData = (byte[])item.author.photo;
                    MemoryStream ms = new MemoryStream(imageData);
                    System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                    picture.Image = image;
                }
                else
                {
                    //change path
                    picture.Image = new Bitmap("C:\\Users\\dinaa\\Downloads\\ITI\\Entity Framework\\Lab\\Application D2\\image\\user.png");

                }
                picture.Location = new Point(20, 20);
                picture.Margin = new Padding(6);
                picture.Name = "P" + item.id;
                picture.Size = new Size(87, 63);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.TabIndex = 3;
                picture.TabStop = false;
                picture.Region = get_region(picture);

                // 
                // label6
                // 
                Label ld = new Label();
                ld.AutoSize = true;
                ld.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
                ld.Location = new Point(650, 20);
                ld.Margin = new Padding(6, 0, 6, 0);
                ld.Name = "ld" + item.id;
                ld.Size = new Size(88, 32);
                ld.TabIndex = 0;
                ld.Text = item.date_ + "";

                // 
                // label8
                // 
                Label lt = new Label();
                lt.AutoSize = true;
                lt.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
                lt.Location = new Point(36, 143);
                lt.Margin = new Padding(6, 0, 6, 0);
                lt.Name = "lt" + item.title;
                lt.Size = new Size(88, 32);
                lt.TabIndex = 7;
                lt.Text = item.title;
                // 
                // textBox1
                // 
                Label text = new Label();
                text.Location = new Point(36, 214);
                text.Name = "text" + item.id;
                text.Size = new Size(929, 141);
                text.TabIndex = 8;
                text.Text = item.desc;

                #region groupBox
                // 
                Panel groupBox = new Panel();
                groupBox.AutoSize = true;
                groupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                groupBox.BackgroundImageLayout = ImageLayout.Zoom;
                groupBox.Controls.Add(text);
                groupBox.Controls.Add(lt);
                groupBox.Controls.Add(ld);
                groupBox.Controls.Add(LU);
                groupBox.Controls.Add(picture);
                groupBox.Location = new Point(x, y);
                groupBox.Margin = new Padding(6);
                groupBox.Name = "groupBox3";
                groupBox.Padding = new Padding(6);
                groupBox.Size = new Size(845, 250);
                groupBox.TabIndex = 8;
                groupBox.TabStop = false;
                groupBox.BackColor = Color.Gainsboro;
                #endregion
                this.Controls.Add(groupBox);
                y += 380;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //refesh
            int index = (int)blog_combo.SelectedValue;
            this.Controls.Clear();
            InitializeComponent();
            blog_combo.DisplayMember = "Name";
            blog_combo.ValueMember = "Id";
            blog_combo.DataSource = db.Blogs.ToList();
            blog_combo.SelectedValue = index;
            txt_combDesc.Text = db.Blogs.Where(p => p.Id == index).Select(p => p.Name).SingleOrDefault();
            loadPost();
        }

    }
}
