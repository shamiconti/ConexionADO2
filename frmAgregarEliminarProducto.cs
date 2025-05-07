using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryContiConexionBD
{
    public partial class frmAgregarEliminarProducto : Form
    {
        public frmAgregarEliminarProducto()
        {
            InitializeComponent();
        }

        clsProductos ObjProductos = new clsProductos();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Complete el " + lblNombre.Text, "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
            }
            else
            {
                if (txtDescripcion.Text == "")
                {
                    MessageBox.Show("Complete el " + lblDescripcion.Text, "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescripcion.Focus();
                }
                else
                {
                    if (mskPrecio.Text == "")
                    {
                        MessageBox.Show("Complete el " + lblPrecio.Text, "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        mskPrecio.Focus();
                    }
                    else
                    {

                        if (mskStock.Text == "")
                        {
                            MessageBox.Show("Complete el " + lblStock.Text, "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            lblStock.Focus();
                        }
                        else
                        {
                            if (cmbCategoria.SelectedIndex == -1)
                            {
                                MessageBox.Show("Elija una " + lblCategoria.Text, "Categoría no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                cmbCategoria.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Datos registrados correctamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                decimal precio = Convert.ToDecimal(mskPrecio.Text);
                                int stock = Convert.ToInt32(mskStock.Text);
                                int categoriaId = Convert.ToInt32(cmbCategoria.SelectedValue);

                                ObjProductos.RegistrarProducto(txtNombre.Text, txtDescripcion.Text,
                                    precio, stock, categoriaId);

                                //Recargar el ComboBox de eliminar después de agregar el producto
                                ObjProductos.CargarComboModificarEliminar(cmbEliminarProducto);

                                txtNombre.Text = "";
                                txtDescripcion.Text = "";
                                mskPrecio.Text = "";
                                mskStock.Text = "";
                                cmbCategoria.Text = "";
                            }
                        }
                    }
                }
            }
        }

        private void frmAgregarEliminarProducto_Load(object sender, EventArgs e)
        {
            ObjProductos.CargarCategorias(cmbCategoria);
            ObjProductos.CargarComboModificarEliminar(cmbEliminarProducto);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbEliminarProducto.SelectedIndex != -1)
            {
                //Obtener el ID del producto seleccionado en el ComboBox
                int productoId = Convert.ToInt32(cmbEliminarProducto.SelectedValue);

                //Llamar al método para eliminar el producto seleccionado
                ObjProductos.EliminarProducto(productoId);

                //Volver a cargar el ComboBox con los productos actualizados
                ObjProductos.CargarComboModificarEliminar(cmbEliminarProducto);

                MessageBox.Show("Producto eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seleccioná un producto para eliminar.", "Producto no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
