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
            this.dataGridView1.Columns.Add("pass", "Contraseña");

            //cargo filas a la grilla

            foreach (Usuario usr in Usuario.obtenerUsuariosExistentes())
            {
                this.dataGridView1.Rows.Add(usr.id, usr.login, usr.pass);
            }
        }




        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { //Obtiene un objeto que representa a la fila seleccionda por el usuario
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            this.textBox1.Text = row.Cells[1].Value.ToString(); //login
            this.textBox2.Text = row.Cells[2].Value.ToString(); //contraseña
            this.textBox3.Text = row.Cells[2].Value.ToString(); //repetir contraseña
            this.textBox4.Text = row.Cells[0].Value.ToString(); //id

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirme eliminación del elemento", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Usuario usr = new Usuario(Int32.Parse(this.textBox4.Text));
                bool borradoOk = usr.borrarUsuario();
                if (borradoOk)
                {
                    MessageBox.Show("Borrado exitosos"
                        , "Operación exitosa"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se eliminó registro"
                       , "Error al borrar"
                       , MessageBoxButtons.OK
                       , MessageBoxIcon.Error);
                }
                //antes de cargar la grilla, borro los datos anteriores
                this.dataGridView1.Rows.Clear();
                //vuelvo a cargar la tabla
                cargoGrilla();
            }
            else if (dialogResult == DialogResult.No)
            {
                //en este caso no hago nada
            }
        }
    }
}
