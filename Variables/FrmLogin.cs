using System;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Variables
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {
            tbPassword.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
         if (Login(lblUsuario.Text, tbPassword.Text))
            {
                new Form1().Show();
                this.Hide();
            }
        }
        private Boolean Login(string username, string password)
        {
            return username.Equals("admin") && password.Equals("admin");
        }
    }
}
