using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.negocio;

namespace WinFormsApp1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Usuario usr = new Usuario(this.textBox1.Text, this.textBox2.Text);
            bool correcto = login.autenticar(usr);
            if (!correcto)
            {
                MessageBox.Show("Usuario o contraseña incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Close();
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
