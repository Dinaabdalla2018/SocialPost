using Application_D2.Models;

namespace Application_D2
{
    public partial class SignUP : Form
    {
        Appcontext db;
        public SignUP()
        {
            InitializeComponent();
            db = new Appcontext();
            txt_password.PasswordChar = '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Click(object sender, EventArgs e)
        {
            Author author = db.Authors.Where(a => a.Username == txt_username.Text && a.Password == txt_password.Text).FirstOrDefault();
            if (author != null)
            {
                this.Hide();
                Home home = new Home(txt_username.Text);
                home.ShowDialog();
                this.Close();
            }
            else
            {
                Message message = new Message("invalid username or password", 'r', "");
                message.ShowDialog();
            }


        }
    }
}