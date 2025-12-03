// Creación de la clase 'CConexion' para manejar la conexión a la base de datos MySQL
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IntelectiaApp
{
    public class CConexion
    {
        // La cadena de conexión a la base de datos es privada (encapsulamiento)
        private string cadenaConexion = "Server=localhost; Database=DB_Intelectia; Uid=root; Pwd=dDmf27r4ib saz;";
        private MySqlConnection conexion;
        public CConexion()    // Inicializa la conexión (constructor)
        {
            conexion = new MySqlConnection(cadenaConexion);
        }
        public MySqlConnection EstablecerConexion()    // Método que abre la conexión
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                    // MessageBox.Show("Conexión Exitosa a Intelectia"); // Descomentar solo para pruebas iniciales
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error crítico de conexión: " + ex.Message);
            }
            return conexion;
        }
        public void CerrarConexion()    // Método que cierra la conexión
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
