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
using Castle.Components.DictionaryAdapter.Xml;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Application_D2
{
    public partial class Post : Form
    {
        Appcontext db;
        int id_user;
        string usename;
        public Post(string _username)
        {
            InitializeComponent();
            db = new Appcontext();
            txt_username.Text = _username;
            usename = _username;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Home home = new Home(txt_username.Text);
            home.ShowDialog();
            this.Close();
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUP sign = new SignUP();
            sign.ShowDialog();
            this.Close();
        }

        private void Update(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel linkLabelU = sender as LinkLabel;
            if (linkLabelU.Text == "Update")
            {
                GroupBox groupBox = linkLabelU.Parent as GroupBox;

                TextBox text = groupBox.Controls[1] as TextBox;
                TextBox title = groupBox.Controls[0] as TextBox;

                title.Enabled = true;
                text.Enabled = true;

                linkLabelU.Text = "Save";
            }
            else
            {
                GroupBox groupBox = linkLabelU.Parent as GroupBox;

                TextBox title = groupBox.Controls[1] as TextBox;
                TextBox text = groupBox.Controls[0] as TextBox;
                int IdPost = int.Parse(linkLabelU.Name.Substring(2));

                Models.Post UPost = db.Posts.Where(p => p.Id == IdPost).Single();
                UPost.title = title.Text;
                UPost.desc = text.Text;
                db.SaveChanges();
                title.Enabled = false;
                text.Enabled = false;

                linkLabelU.Text = "Update";
            }


        }
        private void Delete(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this post?", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LinkLabel dL = (LinkLabel)sender;
                int idPost = int.Parse(dL.Name.Substring(2));
                var post_ = db.Posts.Where(p => p.Id == idPost).Single();
                db.Posts.Remove(post_);
                db.SaveChanges();
                //refresh
                this.Controls.Clear();
                InitializeComponent();
                txt_username.Text = usename;
                Post_Load(sender, e);
            }
        }

        Region get_region(PictureBox pictureBox)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox.Width - 3, pictureBox.Height - 3);
            Region rg = new Region(gp);
            return rg;
        }
        void load_post()
        {
            var posts_ = db.Posts.Select(p => new { id = p.Id, p.desc, p.title, p.date_, p.author_id }).Where(a => a.author_id == id_user);
            int x = 465, y = 632;

            foreach (var item in posts_)
            {
                // 
                #region linkLabel
                LinkLabel linkLabelD = new LinkLabel();
                linkLabelD.AutoSize = true;
                linkLabelD.Cursor = Cursors.Hand;
                linkLabelD.Font = new Font("Georgia", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
                linkLabelD.ForeColor = Color.Red;
                linkLabelD.LinkColor = Color.Red;
                linkLabelD.Location = new Point(916, 405);
                linkLabelD.Margin = new Padding(6, 0, 6, 0);
                linkLabelD.Name = "LD" + item.id;
                linkLabelD.Size = new Size(88, 27);
                linkLabelD.TabIndex = 6;
                linkLabelD.TabStop = true;
                linkLabelD.Text = "Delete";
                linkLabelD.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Delete);
                #endregion
                // 
                // linkLabel2
                LinkLabel linkLabelU = new LinkLabel();
                linkLabelU.AutoSize = true;
                linkLabelU.Cursor = Cursors.Hand;
                linkLabelU.DisabledLinkColor = Color.OliveDrab;
                linkLabelU.Font = new Font("Georgia", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
                linkLabelU.LinkColor = Color.OliveDrab;
                linkLabelU.Location = new Point(796, 405);
                linkLabelU.Margin = new Padding(6, 0, 6, 0);
                linkLabelU.Name = "LU" + item.id;
                linkLabelU.Size = new Size(99, 27);
                linkLabelU.TabIndex = 5;
                linkLabelU.TabStop = true;
                linkLabelU.Text = "Update";
                linkLabelU.LinkClicked += Update;
                // 
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
                LU.Text = txt_name.Text;
                // 
                // pictureBox3
                // 
                PictureBox picture = new PictureBox();
                picture.Image = photo_profile.Image;
                picture.Location = new Point(29, 57);
                picture.Margin = new Padding(6);
                picture.Name = "P" + item.id;
                picture.Size = new Size(76, 78);
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
                ld.Location = new Point(864, 59);
                ld.Margin = new Padding(6, 0, 6, 0);
                ld.Name = "ld" + item.id;
                ld.Size = new Size(157, 24);
                ld.TabIndex = 0;
                ld.Text = item.date_ + "";

                // 
                // label8
                // 
                TextBox lt = new TextBox();
                lt.AutoSize = true;
                lt.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
                lt.Location = new Point(29, 169);
                lt.Margin = new Padding(6, 0, 6, 0);
                lt.Name = "lt" + item.title;
                lt.Size = new Size(164, 34);
                lt.TabIndex = 7;
                lt.Text = item.title;
                lt.BackColor = Color.RosyBrown;
                lt.ForeColor = Color.Black;
                lt.Enabled = false;
                // 
                // textBox1
                // 
                TextBox text = new TextBox();
                text.Location = new Point(29, 225);
                text.Multiline = true;
                text.Name = "text" + item.id;
                text.Size = new Size(929, 141);
                text.TabIndex = 8;
                text.Text = item.desc;
                text.Enabled = false;
                text.BackColor = Color.RosyBrown;
                text.ForeColor = Color.Black;

                #region groupBox
                // 
                GroupBox groupBox = new GroupBox();
                groupBox.AutoSize = true;
                groupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                groupBox.BackgroundImageLayout = ImageLayout.Zoom;
                groupBox.Controls.Add(text);
                groupBox.Controls.Add(lt);
                groupBox.Controls.Add(ld);
                groupBox.Controls.Add(linkLabelD);
                groupBox.Controls.Add(LU);
                groupBox.Controls.Add(picture);
                groupBox.Controls.Add(linkLabelU);
                groupBox.FlatStyle = FlatStyle.Popup;
                groupBox.Location = new Point(x, y);
                groupBox.Margin = new Padding(6);
                groupBox.Name = "groupBox3";
                groupBox.Padding = new Padding(6);
                groupBox.Size = new Size(1033, 465);
                groupBox.TabIndex = 8;
                groupBox.TabStop = false;
                #endregion
                this.Controls.Add(groupBox);
                y += 483;
            }
        }

        private void Post_Load(object sender, EventArgs e)
        {
            var info = db.Authors.Select(a => new { a.Id, a.Name, a.photo, a.posts, a.Username }).Where(a => a.Username == txt_username.Text).Single();
            id_user = info.Id;
            txt_name.Text = info.Name;
            if (info.photo != null)
            {
                byte[] imageData = (byte[])info.photo;
                MemoryStream ms = new MemoryStream(imageData);
                System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                photo_profile.Image = image;
            }
            else
            {
                //Change path of image
                photo_profile.Image = new Bitmap("C:\\Users\\dinaa\\Downloads\\ITI\\Entity Framework\\Lab\\Application D2\\image\\user.png");

            }
            photo_profile.Region = get_region(photo_profile);
            blog_combo.DataSource = db.Blogs.ToList();

            blog_combo.DisplayMember = "Name";
            blog_combo.ValueMember = "Id";

            load_post();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Models.Post npost = new Models.Post()
            {
                title = txt_title.Text,
                desc = txt_desc.Text,
                bref = txt_bref.Text,
                date_ = DateTime.Now,
                blog_id = (int)blog_combo.SelectedValue,
                author_id = id_user,
            };
            db.Posts.Add(npost);
            db.SaveChanges();

            txt_title.Text = txt_desc.Text = txt_bref.Text = "";

            //refesh
            this.Controls.Clear();
            InitializeComponent();
            txt_username.Text = usename;
            Post_Load(sender, e);

        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            form_blog blog = new form_blog();
            blog.ShowDialog();
        }
    }
}

