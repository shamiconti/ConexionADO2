﻿using System;
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
    public partial class frmMostrarModificarProducto : Form
    {
        public frmMostrarModificarProducto()
        {
            InitializeComponent();
        }

        clsProductos ObjProductos = new clsProductos();
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ObjProductos.MostrarProductos(dgvMostrar);
        }

        private void btnModifcar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNuevoPrecio.Text == "")
                {
                    MessageBox.Show("Complete el " + lblNuevoPrecio.Text, "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNuevoPrecio.Focus();
                }
                else
                {
                    if (cmbModificarPrecio.SelectedIndex != -1)
                    {
                        int codigo = Convert.ToInt32(cmbModificarPrecio.SelectedValue);
                        decimal nuevoPrecio = Convert.ToDecimal(txtNuevoPrecio.Text);

                        ObjProductos.ModificarPrecio(codigo, nuevoPrecio);

                        // Recargar el combo
                        ObjProductos.CargarComboModificarEliminar(cmbModificarPrecio);

                        txtNuevoPrecio.Text = "";
                        cmbModificarDescripcion.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Selecciona un producto para modificar.", "Producto no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbModificarPrecio.Focus();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa un número válido para el precio.", "Número Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error: " + ex.Message);
            }
        }

        private void frmMostrarModificarProducto_Load(object sender, EventArgs e)
        {
            ObjProductos.CargarComboModificarEliminar(cmbModificarPrecio);
            ObjProductos.CargarComboModificarEliminar(cmbModificarDescripcion);
        }

        private void btnModificarDescripcion_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNuevaDescripcion.Text == "")
                {
                    MessageBox.Show("Complete la " + lblNuevaDescripcion.Text, "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNuevaDescripcion.Focus();
                }
                else
                {
                    if (cmbModificarDescripcion.SelectedIndex != -1)
                    {
                        int codigo = Convert.ToInt32(cmbModificarDescripcion.SelectedValue);
                        string nuevaDescripcion = txtNuevaDescripcion.Text;

                        ObjProductos.ModificarDescripcion(codigo, nuevaDescripcion);

                        // Recargar el combo
                        ObjProductos.CargarComboModificarEliminar(cmbModificarDescripcion);

                        txtNuevaDescripcion.Text = "";
                        cmbModificarDescripcion.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Selecciona un producto para modificar.", "Producto no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbModificarDescripcion.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error: " + ex.Message);
            }
        }

        private void cmbModificarPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCodigoDescripcion_Click(object sender, EventArgs e)
        {

        }
    }
}
