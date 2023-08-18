using Negocio;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class frmAsignacionDeArticulos : Form
    {
        Paquete paqueteSeleccionadoEnCombo;

        public frmAsignacionDeArticulos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //antes de cargar limpio la lista de articulos disponibles
            this.listOrigen.Items.Clear();
            foreach (Articulo art in Articulo.obtenerArticulosSinPaquete())
            {
                this.listOrigen.Items.Add(art);
            }
            //muestro los paquetes en el combo del tab que se carga primero
            cargarPaquetesEnCombo(this.comboPaquetesAsignacion);
        }

        private void butAgregar_Click_1(object sender, EventArgs e)
        {

            if (this.listOrigen.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un articulo sin paquete");
            }
            else
            {
                //Observar como se hace un casting del objeto recuperado
                Articulo articuloSeleccionado =
                        (Articulo)this.listOrigen.Items[this.listOrigen.SelectedIndex];

                this.listDestino.Items.Add(articuloSeleccionado);

                this.listOrigen.Items.Remove(articuloSeleccionado);
            }
        }





        private void butSacar_Click_1(object sender, EventArgs e)
        {
            if (this.listDestino.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un articulo del paquete");
            }
            else
            {
                //Observar como se hace un casting del objeto recuperado
                Articulo articuloSeleccionado =
                        (Articulo)this.listDestino.Items[this.listDestino.SelectedIndex];

                this.listOrigen.Items.Add(articuloSeleccionado);

                this.listDestino.Items.Remove(articuloSeleccionado);
            }
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //si hago click en el primer tab: Asignar articulos
            if (this.tabControl1.SelectedTab == this.tabControl1.TabPages["tabPage1"])
            {
                cargarPaquetesEnCombo(this.comboPaquetesAsignacion);

            }

            //si hago click en el segundo tab: Ver articulos del paquete
            if (this.tabControl1.SelectedTab == this.tabControl1.TabPages["tabPage2"])
            {
                cargarPaquetesEnCombo(this.comboPaquetesDisponibles);
            }
        }

        private void cargarPaquetesEnCombo(System.Windows.Forms.ComboBox comboACargar)
        {
            //inicializo el combo antes de cargardo
            comboACargar.Items.Clear();

            //Cargo los paquetes existentes en el combo pasado como parametro
            foreach (Paquete paquete in Paquete.obtenerPaquetes())
            {
                comboACargar.Items.Add(paquete);
            };
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cuando cambio la seleccion del combo muesto los datos del paquete
            this.paqueteSeleccionadoEnCombo = this.comboPaquetesDisponibles.SelectedItem as Paquete; //otra manera de hacer un casting
            this.txtDescPaquete.Text = paqueteSeleccionadoEnCombo.descripcion;
            this.txtFechaPaquete.Text = paqueteSeleccionadoEnCombo.fecha;

            ArrayList listaArticulosDelPaquete = new ArrayList();

            this.listArtPaquetes.Items.Clear();
            foreach (Articulo art in Articulo.obtenerArticulosPorPaquete(paqueteSeleccionadoEnCombo.id))
            {
                this.listArtPaquetes.Items.Add(art);
            }


        }

        private void button3_Click(object sender, EventArgs e) //al apretar boton guardar
        {

            Paquete paquete = this.paqueteSeleccionadoEnCombo;
            //asigno articulos al paquete
            foreach (Articulo art in this.listDestino.Items)
            {
                paquete.agregarArticulo(art);
            }
            //graba el paquete en la base de datos
            paquete.grabar();
            MessageBox.Show("Se asignaron los articulos al paquete");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboPaquetesAsignacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cuando cambio el paquete seleccionado en el tab de asignacion de articulos
            //muestro los articulos del paquete

            //cuando cambio la seleccion del combo muesto los datos del paquete
            this.paqueteSeleccionadoEnCombo = this.comboPaquetesAsignacion.SelectedItem as Paquete; //otra manera de hacer un casting

            ArrayList listaArticulosDelPaquete = new ArrayList();

            this.listDestino.Items.Clear();
            foreach (Articulo art in Articulo.obtenerArticulosPorPaquete(paqueteSeleccionadoEnCombo.id))
            {
                this.listDestino.Items.Add(art);
            }

        }

    }
}