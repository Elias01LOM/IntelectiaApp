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
    public partial class UCVendedor_Ventas : UserControl
    {
        public UCVendedor_Ventas()
        {
            InitializeComponent();
        }
        private void UCVendedor_Ventas_Load_1(object sender, EventArgs e)
        {
            EstilizarTabla();
            CargarHistorialVentas();
        }
        private void EstilizarTabla()
        {
            // Aplicamos el mismo estilo moderno que en "Mis Libros"
            dgvVentas.RowTemplate.Height = 35;
            dgvVentas.ColumnHeadersHeight = 40;
            dgvVentas.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvVentas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            dgvVentas.EnableHeadersVisualStyles = false;
            dgvVentas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 85, 48); // Verde
            dgvVentas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvVentas.RowHeadersVisible = false;
            dgvVentas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarHistorialVentas()
        {
            CConexion objetoConexion = new CConexion();
            // Sin Try-Catch para depuración directa
            using (MySqlConnection conexion = objetoConexion.EstablecerConexion())
            {
                if (conexion != null)
                {
                    // CONSULTA MULTI-TABLA:
                    // 1. DetallePedido (Qué se vendió)
                    // 2. Libro (Para saber el título y filtrar por MI idVendedor)
                    // 3. Pedido (Para saber la fecha)
                    // 4. Estudiante -> Usuario (Para saber el nombre del comprador)

                    string query = @"
                        SELECT 
                            P.fechaPedido AS 'Fecha',
                            L.titulo AS 'Libro Vendido',
                            U.nombre AS 'Comprador',
                            DP.cantidad AS 'Cant.',
                            DP.precioUnitario AS 'Precio Unit.',
                            DP.subtotal AS 'Total'
                        FROM DetallePedido DP
                        INNER JOIN Libro L ON DP.isbn = L.isbn
                        INNER JOIN Pedido P ON DP.idPedido = P.idPedido
                        INNER JOIN Estudiante E ON P.idEstudiante = E.idEstudiante
                        INNER JOIN Usuario U ON E.idUsuario = U.idUsuario
                        WHERE L.idVendedor = (SELECT idVendedor FROM Vendedor WHERE idUsuario = @idUser)
                        ORDER BY P.fechaPedido DESC";

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion);
                    // Usamos la sesión global para filtrar SOLO mis ventas
                    adaptador.SelectCommand.Parameters.AddWithValue("@idUser", Sesion.IdUsuario);

                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dgvVentas.DataSource = dt;

                    // --- CALCULAR GANANCIAS TOTALES ---
                    // Recorremos la tabla sumando la columna 'Total'
                    decimal totalGanado = 0;
                    foreach (DataRow fila in dt.Rows)
                    {
                        // Convertimos a decimal (moneda) lo que haya en la columna 'Total'
                        if (fila["Total"] != DBNull.Value)
                        {
                            totalGanado += Convert.ToDecimal(fila["Total"]);
                        }
                    }

                    // Formato de moneda ($1,250.00)
                    lblGanancias.Text = "Total Ganado: " + totalGanado.ToString("C2");
                }
            }
        }
        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
