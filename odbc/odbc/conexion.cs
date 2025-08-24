using System;
using System.Data.Odbc;
using System.Windows.Forms;

namespace odbc
{
    class Conexion
    {
        private string dsn = "Prueba1"; // nombre del DSN que creaste

        public OdbcConnection conexion()
        {
            string connectionString = $"DSN={dsn};";
            OdbcConnection conn = new OdbcConnection(connectionString);

            try
            {
                conn.Open();
                Console.WriteLine("Conexión abierta correctamente");
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al abrir la conexión: " + ex.Message);
                conn = null; // marcar como null si falla
            }

            return conn;
        }

        public void cerrarConexion(OdbcConnection conn)
        {
            try
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    Console.WriteLine("Conexión cerrada");
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al cerrar la conexión: " + ex.Message);
            }
        }
    }
}
