using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IntelectiaApp
{
    public partial class FrmBiblioteca : Form
    {
        public FrmBiblioteca()
        {
            InitializeComponent();
        }

        private void FrmBiblioteca_Load(object sender, EventArgs e)
        {
            CargarLibrosDesdeBD();
        }

        private void CargarLibrosDesdeBD()
        {
            // Se limpia el panel; si es que se recarga
            flowPanelLibros.Controls.Clear();
            CConexion objetoConexion = new CConexion();
            using (MySqlConnection conexion = objetoConexion.EstablecerConexion())
            {
                if (conexion != null)
                {
                    try
                    {
                        string query = "SELECT titulo, autor, precio, urlImagen, formato FROM Libro WHERE formato IN ('PDF', 'EPUB', 'Audio')";    // Se hace la consulta SQL
                        MySqlCommand cmd = new MySqlCommand(query, conexion);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())    // Se recorren los resultados
                        {
                            // Obtener datos de la fila actual
                            string titulo = reader["titulo"].ToString();
                            string autor = reader["autor"].ToString();
                            string precio = reader["precio"].ToString();
                            string url = reader["urlImagen"].ToString();
                            // Se crea la isntancia 'UCLibro'
                            UCLibro tarjeta = new UCLibro();
                            // Se inyectan los datos
                            tarjeta.ConfigurarDatos(titulo, autor, precio, url);
                            // Se agregan los elementos al panel visual
                            flowPanelLibros.Controls.Add(tarjeta);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar biblioteca: " + ex.Message);
                    }
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowPanelLibros_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
