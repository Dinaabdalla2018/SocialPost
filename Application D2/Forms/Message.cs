using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_D2
{
    public partial class Message : Form
    {
        string username;
        public Message(string messge, char color,string _username)
        {
            InitializeComponent();
            txt_message.Text = messge;
            switch (color)
            {
                case 'g':
                    txt_message.ForeColor = Color.ForestGreen;
                    break;
                case 'r':
                    txt_message.ForeColor = Color.Red;
                    break;

            }
            username = _username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (username != "")
            {
                Home home = new Home(username);
                home.ShowDialog();
            }
            this.Close();
        }
    }
}
