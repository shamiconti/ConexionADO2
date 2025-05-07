using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryContiConexionBD
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarEliminarProducto frmAgregarProducto = new frmAgregarEliminarProducto();
            frmAgregarProducto.ShowDialog();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrarModificarProducto frmMostrarProducto = new frmMostrarModificarProducto();
            frmMostrarProducto.ShowDialog();
        }
    }
}
