using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using WinFormsApp1.negocio;

namespace WinFormsApp1
{
    public partial class frmUsuarios : Form
    {

        public frmUsuarios()
        {
            InitializeComponent();
            //Estas propiedades se pueden setear con el IDE
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoResizeColumnHeadersHeight();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            //el evento Load se lanza al abrir el formulario.

            cargoGrilla();

        }

        private void cargoGrilla()
        {

            //agrego columna a la grilla
            this.dataGridView1.Columns.Add("id", "id");
            this.dataGridView1.Columns.Add("login", "Login de usuario");

            //cargo filas a la grilla

            foreach (Usuario usr in Usuario.obtenerUsuariosExistentes())
            {
                this.dataGridView1.Rows.Add(usr.id, usr.login);
            }
        }




        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
