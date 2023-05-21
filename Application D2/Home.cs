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
using Application_D2.Properties;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Application_D2
{
    public partial class Home : Form
    {
        Appcontext db;
        public Home(string username)
        {
            InitializeComponent();
            db = new Appcontext();
            txt_username.Text = username;

        }
        Region get_region(PictureBox pictureBox)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox.Width - 3, pictureBox.Height - 3);
            Region rg = new Region(gp);
            return rg;
        }
        private void Home_Load(object sender, EventArgs e)
        {
            var posts = db.Posts.Include(p => p.author).Select(p => new { p.Id, p.date_, p.desc, p.title, p.author.Name, p.author.photo });
            int x = 260, y = 137;
            foreach (var item in posts)
            {
                // 
                // linkLabel1
                // 
                LinkLabel linkLabel = new LinkLabel();
                linkLabel.AutoSize = true;
                linkLabel.Font = new Font("Georgia", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
                linkLabel.LinkColor = Color.Black;
                linkLabel.Location = new Point(84, 46);
                linkLabel.Margin = new Padding(4, 0, 4, 0);
                linkLabel.Name = "L1" + item.Id;
                linkLabel.Size = new Size(211, 27);
                linkLabel.TabIndex = 4;
                linkLabel.TabStop = true;
                linkLabel.Text = item.Name;
                // 
                // pictureBox1
                // 
                PictureBox pictureBox = new PictureBox();
                if (item.photo != null)
                {
                    byte[] imageData = (byte[])item.photo;
                    MemoryStream ms = new MemoryStream(imageData);
                    Image image = Image.FromStream(ms);
                    pictureBox.Image = image;
                }
                else
                {
                    //Change path of image
                    pictureBox.Image = new Bitmap("C:\\Users\\dinaa\\Downloads\\ITI\\Entity Framework\\Lab\\Application D2\\image\\user.png");

                }
                pictureBox.Location = new Point(21, 41);
                pictureBox.Margin = new Padding(4);
                pictureBox.Name = "p" + item.Id;
                pictureBox.Size = new Size(55, 56);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.TabIndex = 3;
                pictureBox.TabStop = false;
                pictureBox.Region = get_region(pictureBox);
                // 
                // label3
                // 
                Label labelBody = new Label();
                labelBody.AutoSize = true;
                labelBody.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
                labelBody.Location = new Point(38, 167);
                labelBody.Margin = new Padding(4, 0, 4, 0);
                labelBody.Name = "lb" + item.Id;
                labelBody.Size = new Size(174, 27);
                labelBody.TabIndex = 2;
                labelBody.Text = item.desc;
                // 
                // label1
                // 
                Label ld = new Label();
                ld.AutoSize = true;
                ld.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
                ld.Location = new Point(627, 41);
                ld.Margin = new Padding(4, 0, 4, 0);
                ld.Name = "ld" + item.Id;
                ld.Size = new Size(157, 24);
                ld.TabIndex = 0;
                ld.Text = item.date_ + "";

                // label9
                // 
                Label lt = new Label();
                lt.AutoSize = true;
                lt.Font = new Font("Georgia", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
                lt.Location = new Point(38, 125);
                lt.Margin = new Padding(4, 0, 4, 0);
                lt.Name = "lt" + item.Id;
                lt.Size = new Size(57, 27);
                lt.TabIndex = 5;
                lt.Text = item.title;

                Panel groupBox = new Panel();
                // 
                // groupBox1
                // 
                groupBox.AutoSize = true;
                groupBox.AutoSizeMode = AutoSizeMode.GrowOnly;
                groupBox.BackgroundImageLayout = ImageLayout.Tile;
                groupBox.Controls.Add(lt);
                groupBox.Controls.Add(linkLabel);
                groupBox.Controls.Add(pictureBox);
                groupBox.Controls.Add(labelBody);
                groupBox.Controls.Add(ld);
                groupBox.BackColor=Color.LightGray;
                groupBox.Location = new Point(x, y);
                groupBox.Margin = new Padding(4);
                groupBox.Name = "g" + item.Id;
                groupBox.Padding = new Padding(4);
                groupBox.Size = new Size(792, 225);
                groupBox.TabIndex = 2;
                groupBox.TabStop = false;

                this.Controls.Add(groupBox);
                y += 250;
            }

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUP sign = new SignUP();
            sign.ShowDialog();
            this.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Post post = new Post(txt_username.Text);
            post.ShowDialog();
            this.Close();
        }
    }
}
