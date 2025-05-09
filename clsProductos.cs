using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace pryContiConexionBD
{
    public class clsProductos
    {
        public void CargarCategorias(ComboBox combo)
        {
            using (SqlConnection conexion = clsConexion.ObtenerConexion())
            {
                string query = "SELECT Id, Nombre FROM Categorias";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);

                combo.DisplayMember = "Nombre"; //Lo que se ve
                combo.ValueMember = "Id";       //Lo que se guarda
                combo.DataSource = dt;

                combo.SelectedIndex = -1; //Que no muestre ningún producto al inicio
            }
        }

        public void CargarComboModificarEliminar(ComboBox combo)
        {
            using (SqlConnection conexion = clsConexion.ObtenerConexion())
            {
                string query = "SELECT Codigo FROM Productos";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);

                combo.DisplayMember = "Codigo";
                combo.ValueMember = "Codigo";
                combo.DataSource = dt;

                combo.SelectedIndex = -1; 
            }
        }


        public void RegistrarProducto(string nombre, string descripcion, decimal precio, int stock, int categoriaId)
        {
            using (SqlConnection conexion = clsConexion.ObtenerConexion())
            {
                try
                {
                    string query = "INSERT INTO Productos (Nombre, Descripcion, Precio, Stock, CategoriaId) " +
                                   "VALUES (@Nombre, @Descripcion, @Precio, @Stock, @CategoriaId)";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Descripcion", descripcion);
                    comando.Parameters.AddWithValue("@Precio", precio);
                    comando.Parameters.AddWithValue("@Stock", stock);
                    comando.Parameters.AddWithValue("@CategoriaId", categoriaId);

                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error: " + ex.Message);
                }
            }
        }

        public void MostrarProductos(DataGridView dgvMostrar)
        {
            using (SqlConnection conexion = clsConexion.ObtenerConexion())
            {
                string query = @"SELECT P.Codigo, P.Nombre, P.Descripcion, P.Precio, P.Stock, C.Nombre AS Categoria 
                         FROM Productos P 
                         INNER JOIN Categorias C ON P.CategoriaId = C.Id";

                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvMostrar.DataSource = dt;
            }
        }

        public void EliminarProducto(int productoId)
        {
            using (SqlConnection conn = clsConexion.ObtenerConexion())
            {
                try
                {
                    //Query para eliminar el producto por ID (Codigo)
                    string deleteQuery = "DELETE FROM Productos WHERE Codigo = @codigo";
                    SqlCommand cmd = new SqlCommand(deleteQuery, conn);

                    //Pasar el ID del producto como parámetro
                    cmd.Parameters.AddWithValue("@codigo", productoId);

                    //Ejecutar la consulta
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error: " + ex.Message);
                }
            }
        }

        public void ModificarPrecio(int productoId, decimal nuevoPrecio)
        {
            using (SqlConnection conexion = clsConexion.ObtenerConexion())
            {
                try
                {
                    //Query para actualizar el precio de un producto según su ID
                    string updateQuery = "UPDATE Productos SET Precio = @precio WHERE Codigo = @productoId";

                    SqlCommand cmd = new SqlCommand(updateQuery, conexion);
                    cmd.Parameters.AddWithValue("@precio", nuevoPrecio);
                    cmd.Parameters.AddWithValue("@productoId", productoId); //Usar el ID para identificar el producto

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Precio actualizado correctamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error: " + ex.Message);
                }
            }
        }

        public void ModificarDescripcion(int codigo, string nuevaDescripcion)
        {
            try
            {
                using (SqlConnection conexion = clsConexion.ObtenerConexion())
                {
                    string query = "UPDATE Productos SET Descripcion = @descripcion WHERE Codigo = @codigo";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@descripcion", nuevaDescripcion);
                    cmd.Parameters.AddWithValue("@codigo", codigo);

                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Descripción actualizada correctamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           catch (Exception ex)
            {
                MessageBox.Show("❌ Error: " + ex.Message);
            }
        }
    }
}
