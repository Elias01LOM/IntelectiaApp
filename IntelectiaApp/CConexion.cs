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
        private string cadenaConexion = "Server=localhost; Database=DB_Intelectia; Uid=root; Pwd=Ochoa#2006Elias;";

        private MySqlConnection conexion;

        // Inicializa la conexión (cosntructor)
        public CConexion()
        {
            conexion = new MySqlConnection(cadenaConexion);
        }

        // Método que abre la conexión
        public MySqlConnection EstablecerConexion()
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

        // Método que cierra la conexión
        public void CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
