using System;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Variables
{
    public partial class FrmLogin : Form
    {
        int contador = 0;
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
         if (Login(tbUsuario.Text, tbPassword.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
         else
            {
                contador++;
                MessageBox.Show("Contraseña invalida");
            }
         if(contador==3)
            {
                MessageBox.Show("Usted ha excedido los intentos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private Boolean Login(string username, string password)
        {
            return username.Equals("admin") && password.Equals("admin");
        }
    }
}
