using System;
using System.Data.Odbc;
using System.Windows.Forms;

namespace odbc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtBNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBPuesto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBDepartamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            OdbcConnection conexion = cn.conexion(); // Abrimos la conexión
            if (conexion == null)
            {
                MessageBox.Show("No se pudo abrir la conexión a la base de datos.");
                return;
            }

            try
            {
                string query = "INSERT INTO empleados (nombre_completo, puesto, departamento) VALUES (?, ?, ?)";
                using (OdbcCommand cmd = new OdbcCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("?", TxtBNombre.Text);
                    cmd.Parameters.AddWithValue("?", TxtBPuesto.Text);
                    cmd.Parameters.AddWithValue("?", TxtBDepartamento.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Empleado agregado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
            finally
            {
                cn.cerrarConexion(conexion); // Cerramos la conexión
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            OdbcConnection conexion = cn.conexion(); // Abrimos la conexión
            if (conexion == null)
            {
                MessageBox.Show("No se pudo abrir la conexión a la base de datos.");
                return;
            }

            try
            {
                string query = "DELETE FROM empleados WHERE nombre_completo = ?";
                using (OdbcCommand cmd = new OdbcCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("?", TxtBNombre.Text);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                        MessageBox.Show("Empleado eliminado correctamente");
                    else
                        MessageBox.Show("No se encontró un empleado con ese nombre");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
            finally
            {
                cn.cerrarConexion(conexion); // Cerramos la conexión
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            consulta consulta = new consulta();
            consulta.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
