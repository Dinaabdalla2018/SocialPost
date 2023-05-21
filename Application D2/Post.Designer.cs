namespace Application_D2
{
    partial class Post
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Post));
            photo_profile = new PictureBox();
            txt_name = new LinkLabel();
            label2 = new Label();
            linkLabel4 = new LinkLabel();
            txt_username = new LinkLabel();
            button1 = new Button();
            panel2 = new Panel();
            Bref = new Label();
            txt_bref = new TextBox();
            blog_combo = new ComboBox();
            label7 = new Label();
            txt_desc = new TextBox();
            label4 = new Label();
            txt_title = new TextBox();
            linkLabel5 = new LinkLabel();
            panel1 = new Panel();
            linkLabel10 = new LinkLabel();
            linkLabel11 = new LinkLabel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)photo_profile).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // photo_profile
            // 
            photo_profile.Image = (Image)resources.GetObject("photo_profile.Image");
            photo_profile.Location = new Point(16, 161);
            photo_profile.Margin = new Padding(4);
            photo_profile.Name = "photo_profile";
            photo_profile.Size = new Size(367, 333);
            photo_profile.SizeMode = PictureBoxSizeMode.StretchImage;
            photo_profile.TabIndex = 0;
            photo_profile.TabStop = false;
            // 
            // txt_name
            // 
            txt_name.AutoSize = true;
            txt_name.Font = new Font("Georgia", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txt_name.LinkColor = Color.Black;
            txt_name.Location = new Point(112, 571);
            txt_name.Margin = new Padding(4, 0, 4, 0);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(163, 32);
            txt_name.TabIndex = 1;
            txt_name.TabStop = true;
            txt_name.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(19, 177);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 32);
            label2.TabIndex = 2;
            label2.Text = "Description";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel4.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel4.LinkColor = Color.Black;
            linkLabel4.Location = new Point(735, 18);
            linkLabel4.Margin = new Padding(6, 0, 6, 0);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(67, 24);
            linkLabel4.TabIndex = 1;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "News";
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // txt_username
            // 
            txt_username.AutoSize = true;
            txt_username.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txt_username.LinkBehavior = LinkBehavior.HoverUnderline;
            txt_username.LinkColor = Color.DarkBlue;
            txt_username.Location = new Point(66, 18);
            txt_username.Margin = new Padding(6, 0, 6, 0);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(114, 24);
            txt_username.TabIndex = 0;
            txt_username.TabStop = true;
            txt_username.Text = "username";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(855, 371);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 3;
            button1.Text = "Post";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(Bref);
            panel2.Controls.Add(txt_bref);
            panel2.Controls.Add(blog_combo);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txt_desc);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txt_title);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(474, 161);
            panel2.Name = "panel2";
            panel2.Size = new Size(1017, 432);
            panel2.TabIndex = 11;
            // 
            // Bref
            // 
            Bref.AutoSize = true;
            Bref.BackColor = Color.Transparent;
            Bref.Font = new Font("Georgia", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Bref.ForeColor = Color.White;
            Bref.Location = new Point(19, 91);
            Bref.Margin = new Padding(6, 0, 6, 0);
            Bref.Name = "Bref";
            Bref.Size = new Size(66, 32);
            Bref.TabIndex = 10;
            Bref.Text = "Bref";
            // 
            // txt_bref
            // 
            txt_bref.Location = new Point(117, 89);
            txt_bref.Name = "txt_bref";
            txt_bref.Size = new Size(232, 34);
            txt_bref.TabIndex = 9;
            // 
            // blog_combo
            // 
            blog_combo.FlatStyle = FlatStyle.System;
            blog_combo.FormattingEnabled = true;
            blog_combo.Location = new Point(585, 22);
            blog_combo.Name = "blog_combo";
            blog_combo.Size = new Size(232, 36);
            blog_combo.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Georgia", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(484, 22);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(69, 32);
            label7.TabIndex = 7;
            label7.Text = "Blog";
            // 
            // txt_desc
            // 
            txt_desc.Location = new Point(20, 227);
            txt_desc.Multiline = true;
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(683, 133);
            txt_desc.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Georgia", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(19, 20);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 32);
            label4.TabIndex = 5;
            label4.Text = "Title";
            // 
            // txt_title
            // 
            txt_title.Location = new Point(117, 20);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(232, 34);
            txt_title.TabIndex = 4;
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel5.ForeColor = Color.IndianRed;
            linkLabel5.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel5.LinkColor = Color.IndianRed;
            linkLabel5.Location = new Point(1704, 18);
            linkLabel5.Margin = new Padding(6, 0, 6, 0);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(0, 24);
            linkLabel5.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(linkLabel10);
            panel1.Controls.Add(linkLabel5);
            panel1.Controls.Add(linkLabel4);
            panel1.Controls.Add(txt_username);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1599, 60);
            panel1.TabIndex = 9;
            // 
            // linkLabel10
            // 
            linkLabel10.AutoSize = true;
            linkLabel10.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel10.ForeColor = Color.IndianRed;
            linkLabel10.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel10.LinkColor = Color.IndianRed;
            linkLabel10.Location = new Point(1433, 18);
            linkLabel10.Margin = new Padding(4, 0, 4, 0);
            linkLabel10.Name = "linkLabel10";
            linkLabel10.Size = new Size(88, 24);
            linkLabel10.TabIndex = 3;
            linkLabel10.TabStop = true;
            linkLabel10.Text = "LogOut";
            linkLabel10.LinkClicked += linkLabel10_LinkClicked;
            // 
            // linkLabel11
            // 
            linkLabel11.AutoSize = true;
            linkLabel11.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel11.LinkColor = Color.IndianRed;
            linkLabel11.Location = new Point(138, 13);
            linkLabel11.Margin = new Padding(4, 0, 4, 0);
            linkLabel11.Name = "linkLabel11";
            linkLabel11.Size = new Size(93, 32);
            linkLabel11.TabIndex = 12;
            linkLabel11.TabStop = true;
            linkLabel11.Text = "Blogs";
            linkLabel11.LinkClicked += linkLabel11_LinkClicked;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Controls.Add(linkLabel11);
            panel3.Location = new Point(16, 630);
            panel3.Name = "panel3";
            panel3.Size = new Size(367, 54);
            panel3.TabIndex = 13;
            // 
            // Post
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMargin = new Size(0, 40);
            BackColor = Color.White;
            ClientSize = new Size(1599, 995);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txt_name);
            Controls.Add(photo_profile);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Post";
            Text = "Post";
            Load += Post_Load;
            ((System.ComponentModel.ISupportInitialize)photo_profile).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox photo_profile;
        private LinkLabel txt_name;
        private Label label2;
        private LinkLabel linkLabel4;
        private LinkLabel txt_username;
        private Button button1;
        private Panel panel2;
        private LinkLabel linkLabel5;
        private Panel panel1;
        private LinkLabel linkLabel10;
        private ComboBox blog_combo;
        private Label label7;
        private TextBox txt_desc;
        private Label label4;
        private TextBox txt_title;
        private Label Bref;
        private TextBox txt_bref;
        private LinkLabel linkLabel11;
        private Panel panel3;
    }
}