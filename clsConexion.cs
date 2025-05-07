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
    public class clsConexion
    {
        private static string ConexionBD = "Server=.;Database=Comercio;Trusted_Connection=True;";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(ConexionBD);
            try
            {
                conexion.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al conectar: " + ex.Message);
            }

            return conexion;
        }
    }
}
