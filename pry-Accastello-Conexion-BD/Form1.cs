using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryGestionInventario;

namespace pry_Accastello_Conexion_BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            clsConexionBD objConexion = new clsConexionBD();
            objConexion.ConectarBD();
            DataTable datos = objConexion.ObtenerDatosTabla("Contactos");
            dgvGrilla.DataSource = datos;
        }
    }
}
