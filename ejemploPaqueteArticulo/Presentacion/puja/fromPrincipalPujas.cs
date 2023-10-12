using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Negocio.pujas;
using Persistencia.puja;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion.puja
{
    public partial class fromPrincipalPujas : Form
    {
        public fromPrincipalPujas()
        {
            InitializeComponent();
        }

        private void fromPrincipalPujas_Load(object sender, EventArgs e)
        {
            actualizarCombo();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizoFormulario();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void botPujar_Click(object sender, EventArgs e)
        {
            //en persistencia controlo el monto para evitar ir innecesariamente a la base de datos
            //TODO implementar control fecha limite puja
            if (Int32.Parse(this.txtMonto.Text) > Int32.Parse(this.txtMonoMaximoPuja.Text))
            {
                string mensaje = Remate.pujar(
                                         ((Remate)comboBox1.SelectedItem).idRemate,
                                        Int32.Parse(this.txtMonto.Text), 
                                        this.txtUsuario.Text);

                if (!mensaje.Equals("ok"))
                {
                    MessageBox.Show(mensaje);
                    actualizarCombo();
                } else
                {
                    MessageBox.Show("La puja se realizo correctamente");
                }

            } else
            {
                MessageBox.Show("El monto de la puja debe ser mayor al de la última puja");
            }
           
        }

        private void actualizarCombo()
        {
            //inicializo el combo antes de cargardo
            comboBox1.Items.Clear();

            //Cargo los paquetes existentes en el combo pasado como parametro
            foreach (Remate remate in Remate.obtenerRemates())
            {
                comboBox1.Items.Add(remate);
            };
           
        }

        private void actualizoFormulario()
        {
            Remate remateCombo = (Remate)comboBox1.SelectedItem;
            RemateVO remateVO = new RepositorioRemate().obtenerRemate(remateCombo.idRemate);

            this.txtFechaLimitePuja.Text = remateVO.fechaLimitePuja.ToString();
            this.txtMonoMaximoPuja.Text = remateVO.montoMaximoPujaFinal.ToString();
            this.txtUsuarioPuja.Text = remateVO.usuarioPujaFinal;
 
        }
    }
}
