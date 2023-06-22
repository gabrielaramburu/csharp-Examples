using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsur = new frmUsuarios();
            frmUsur.Show(); //no modal
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLog = new frmLogin();
            frmLog.ShowDialog(); //modal
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
