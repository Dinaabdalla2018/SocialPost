namespace Application_D2
{
    partial class Message
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
            button1 = new Button();
            txt_message = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(309, 219);
            button1.Name = "button1";
            button1.Size = new Size(150, 48);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txt_message
            // 
            txt_message.AutoSize = true;
            txt_message.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_message.ForeColor = Color.ForestGreen;
            txt_message.Location = new Point(191, 123);
            txt_message.Name = "txt_message";
            txt_message.Size = new Size(428, 32);
            txt_message.TabIndex = 1;
            txt_message.Text = "Account created successfully";
            // 
            // Message
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 336);
            Controls.Add(txt_message);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Message";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Message";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label txt_message;
    }
}