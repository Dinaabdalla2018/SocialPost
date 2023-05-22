namespace Application_D2
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_name = new TextBox();
            txt_password = new TextBox();
            login = new Button();
            label4 = new Label();
            label5 = new Label();
            txt_username = new TextBox();
            txt_age = new TextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(366, 555);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 13;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(366, 186);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 24);
            label2.TabIndex = 12;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(366, 64);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 39);
            label1.TabIndex = 11;
            label1.Text = "SignUp";
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Georgia", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(366, 220);
            txt_name.Margin = new Padding(4);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(248, 45);
            txt_name.TabIndex = 10;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Georgia", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(366, 590);
            txt_password.Margin = new Padding(4);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(248, 45);
            txt_password.TabIndex = 9;
            // 
            // login
            // 
            login.BackColor = Color.Brown;
            login.Cursor = Cursors.Hand;
            login.FlatStyle = FlatStyle.Flat;
            login.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            login.ForeColor = SystemColors.ButtonHighlight;
            login.Location = new Point(339, 750);
            login.Margin = new Padding(4);
            login.Name = "login";
            login.Size = new Size(256, 54);
            login.TabIndex = 8;
            login.Text = "SignUp";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(366, 430);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 18;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(366, 306);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(125, 25);
            label5.TabIndex = 17;
            label5.Text = "Username";
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Georgia", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            txt_username.Location = new Point(366, 341);
            txt_username.Margin = new Padding(4);
            txt_username.Multiline = true;
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(248, 45);
            txt_username.TabIndex = 16;
            // 
            // txt_age
            // 
            txt_age.Font = new Font("Georgia", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            txt_age.Location = new Point(366, 464);
            txt_age.Margin = new Padding(4);
            txt_age.Multiline = true;
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(248, 45);
            txt_age.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(70, 160);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 25);
            label6.TabIndex = 19;
            label6.Text = "Photo";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(15, 195);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 239);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(45, 464);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(169, 36);
            button1.TabIndex = 21;
            button1.Text = "Upload Photo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(899, 15);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1000, 849);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txt_username);
            Controls.Add(txt_age);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_name);
            Controls.Add(txt_password);
            Controls.Add(login);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_name;
        private TextBox txt_password;
        private Button login;
        private Label label4;
        private Label label5;
        private TextBox txt_username;
        private TextBox txt_age;
        private Label label6;
        private PictureBox pictureBox1;
        private Button button1;
        private PictureBox pictureBox2;
    }
}