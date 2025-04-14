using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

using System.Windows.Forms;
using System.Data;

namespace pryGestionInventario
{
    internal class clsConexionBD
    {
        //cadena de conexion
        string cadenaConexion = "Server=localhost;Database=Ventas2;Trusted_Connection=True;";

        //conector
        SqlConnection coneccionBaseDatos;

        //comando
        SqlCommand comandoBaseDatos;

        public string nombreBaseDeDatos;


        public void ConectarBD()
        {
            try
            {
                coneccionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = coneccionBaseDatos.Database;

                coneccionBaseDatos.Open();
                
                MessageBox.Show("Conectado a " + nombreBaseDeDatos);
            }
            catch (Exception error)
            {
                MessageBox.Show("Tiene un errorcito - " + error.Message);
            }     

        }
        public DataTable ObtenerDatosTabla(string nombreTabla)
        {
            DataTable tabla = new DataTable();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string consulta = $"SELECT * FROM {"Contactos"}";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        conexion.Open();
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }

            return tabla;
        }

    }
}
