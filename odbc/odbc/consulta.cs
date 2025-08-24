using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace odbc
{
    public partial class consulta : Form
    {
        Conexion cn = new Conexion();
        public consulta()
        {
            InitializeComponent();
        }

        private void DgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                string cadena = "SELECT * FROM empleados";

                OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn.conexion());

                DataTable dt = new DataTable();

                datos.Fill(dt);

                DgvDatos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }

        }
    }
}
