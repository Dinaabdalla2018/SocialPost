namespace Application_D2
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panel1 = new Panel();
            linkLabel5 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            txt_username = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(linkLabel5);
            panel1.Controls.Add(linkLabel4);
            panel1.Controls.Add(txt_username);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1371, 59);
            panel1.TabIndex = 6;
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel5.ForeColor = Color.IndianRed;
            linkLabel5.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel5.LinkColor = Color.IndianRed;
            linkLabel5.Location = new Point(1239, 13);
            linkLabel5.Margin = new Padding(4, 0, 4, 0);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(88, 24);
            linkLabel5.TabIndex = 2;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "LogOut";
            linkLabel5.LinkClicked += linkLabel5_LinkClicked;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel4.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel4.LinkColor = Color.DarkBlue;
            linkLabel4.Location = new Point(595, 13);
            linkLabel4.Margin = new Padding(4, 0, 4, 0);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(67, 24);
            linkLabel4.TabIndex = 1;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "News";
            // 
            // txt_username
            // 
            txt_username.AutoSize = true;
            txt_username.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txt_username.LinkBehavior = LinkBehavior.HoverUnderline;
            txt_username.LinkColor = Color.Black;
            txt_username.Location = new Point(48, 13);
            txt_username.Margin = new Padding(4, 0, 4, 0);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(114, 24);
            txt_username.TabIndex = 0;
            txt_username.TabStop = true;
            txt_username.Text = "username";
            txt_username.LinkClicked += linkLabel3_LinkClicked;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMargin = new Size(0, 40);
            BackColor = Color.Gray;
            ClientSize = new Size(1371, 945);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Home";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Home";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private LinkLabel linkLabel4;
        private LinkLabel txt_username;
        private LinkLabel linkLabel5;
    }
}