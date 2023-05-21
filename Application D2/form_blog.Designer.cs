namespace Application_D2
{
    partial class form_blog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_blog));
            panel2 = new Panel();
            txt_combDesc = new Label();
            blog_combo = new ComboBox();
            button2 = new Button();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            txt_desc = new TextBox();
            label4 = new Label();
            txt_name = new TextBox();
            button1 = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(txt_combDesc);
            panel2.Controls.Add(blog_combo);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(31, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(293, 350);
            panel2.TabIndex = 0;
            // 
            // txt_combDesc
            // 
            txt_combDesc.AutoSize = true;
            txt_combDesc.BackColor = Color.Transparent;
            txt_combDesc.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_combDesc.ForeColor = Color.White;
            txt_combDesc.Location = new Point(57, 164);
            txt_combDesc.Margin = new Padding(6, 0, 6, 0);
            txt_combDesc.Name = "txt_combDesc";
            txt_combDesc.Size = new Size(130, 27);
            txt_combDesc.TabIndex = 7;
            txt_combDesc.Text = "Description";
            // 
            // blog_combo
            // 
            blog_combo.FlatStyle = FlatStyle.System;
            blog_combo.FormattingEnabled = true;
            blog_combo.Location = new Point(28, 82);
            blog_combo.Name = "blog_combo";
            blog_combo.Size = new Size(232, 28);
            blog_combo.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.System;
            button2.Location = new Point(67, 268);
            button2.Name = "button2";
            button2.Size = new Size(149, 42);
            button2.TabIndex = 7;
            button2.Text = "View";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Georgia", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(94, 30);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 32);
            label3.TabIndex = 7;
            label3.Text = "Blogs";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(629, 32);
            label1.Name = "label1";
            label1.Size = new Size(252, 32);
            label1.TabIndex = 0;
            label1.Text = "Create new Plog";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(txt_desc);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_name);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(372, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(828, 350);
            panel1.TabIndex = 12;
            // 
            // txt_desc
            // 
            txt_desc.Location = new Point(20, 135);
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
            label4.Size = new Size(88, 32);
            label4.TabIndex = 5;
            label4.Text = "Name";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(117, 20);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(232, 27);
            txt_name.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(679, 286);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 3;
            button1.Text = "Plog";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 86);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 32);
            label2.TabIndex = 2;
            label2.Text = "Description";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1186, 6);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Black;
            label9.Font = new Font("Georgia", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.IndianRed;
            label9.Location = new Point(489, 524);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(214, 32);
            label9.TabIndex = 7;
            label9.Text = "All Posts in blog";
            // 
            // form_blog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMargin = new Size(0, 40);
            BackColor = Color.DimGray;
            ClientSize = new Size(1290, 751);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_blog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "form_blog";
            Load += form_blog_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private Button button2;
        private Label label3;
        private Panel panel1;
        private TextBox txt_desc;
        private Label label4;
        private TextBox txt_name;
        private Button button1;
        private Label label2;
        private Label txt_combDesc;
        private ComboBox blog_combo;
        private PictureBox pictureBox1;
        private Label label9;
    }
}