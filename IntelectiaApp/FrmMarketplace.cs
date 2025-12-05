using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntelectiaApp
{
    public partial class FrmMarketplace : Form
    {
        public FrmMarketplace()
        {
            InitializeComponent();
            CargarMercado();
        }
        private void CargarMercado()
        {
            flowMercado.Controls.Clear();
            CConexion objetoConexion = new CConexion();
            using (MySqlConnection conexion = objetoConexion.EstablecerConexion())
            {
                if (conexion != null)
                {
                    try
                    {
                        // Traemos TODO (Sin filtros por ahora)
                        string query = "SELECT isbn, titulo, autor, precio, urlImagen, formato FROM Libro";
                        MySqlCommand cmd = new MySqlCommand(query, conexion);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            UCTarjetaProducto card = new UCTarjetaProducto();

                            card.ConfigurarProducto(
                                reader["isbn"].ToString(),
                                reader["titulo"].ToString(),
                                reader["autor"].ToString(),
                                reader["precio"].ToString(),
                                reader["urlImagen"].ToString(),
                                reader["formato"].ToString()
                            );

                            // Margen entre tarjetas
                            card.Margin = new Padding(15);

                            flowMercado.Controls.Add(card);
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
                }
            }
        }
        private void flowMercado_Paint(object sender, PaintEventArgs e)
        {
            CargarMercado();
        }

        private void FrmMarketplace_Load(object sender, EventArgs e)
        {
            CargarMercado();
        }
    }
}
