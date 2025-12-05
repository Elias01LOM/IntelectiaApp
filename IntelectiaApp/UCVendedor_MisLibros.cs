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
    public partial class UCVendedor_MisLibros : UserControl
    {
        public UCVendedor_MisLibros()
        {
            InitializeComponent();
        }

        private void UCVendedor_MisLibros_Load_1(object sender, EventArgs e)
        {
            CargarInventario();
            EstilizarTabla();
        }
        private void EstilizarTabla()
        {
            // 1. Ajustar altura de las filas (Para que se vea "chiquito" y compacto)
            dgvInventario.RowTemplate.Height = 35; // Valor normal es 22, 35 es cómodo. Si quieres muy compacto usa 25.
            dgvInventario.ColumnHeadersHeight = 40; // Cabecera un poco más alta

            // 2. Ajustar Fuentes (Letra más pequeña y moderna)
            dgvInventario.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvInventario.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            // 3. Quitar bordes y espacios innecesarios
            dgvInventario.RowHeadersVisible = false; // Quita la columna gris vacía de la izquierda
            dgvInventario.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInventario.BorderStyle = BorderStyle.None;

            // 4. Colores (Para que combine con tu app)
            dgvInventario.BackgroundColor = Color.White; // Fondo blanco limpio
            dgvInventario.EnableHeadersVisualStyles = false; // Permitir pintar cabeceras
            dgvInventario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 85, 48); // Tu Verde
            dgvInventario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // 5. Comportamiento de Selección
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selecciona toda la fila
            dgvInventario.MultiSelect = false;
            dgvInventario.DefaultCellStyle.SelectionBackColor = Color.FromArgb(212, 175, 55); // Tu Dorado
            dgvInventario.DefaultCellStyle.SelectionForeColor = Color.White;

            // 6. Ajuste de Columnas (Rellenar espacio)
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void CargarInventario()
        {
            CConexion objetoConexion = new CConexion();
            using (MySqlConnection conexion = objetoConexion.EstablecerConexion())
            {
                if (conexion != null)
                {
                    // Consulta anidada: Traer libros de MI usuario vendedor
                    string query = "SELECT titulo, autor, precio, stock, estado FROM Libro WHERE idVendedor = (SELECT idVendedor FROM Vendedor WHERE idUsuario = @id)";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
                    da.SelectCommand.Parameters.AddWithValue("@id", Sesion.IdUsuario);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvInventario.DataSource = dt;
                }
            }
        }
    }
}