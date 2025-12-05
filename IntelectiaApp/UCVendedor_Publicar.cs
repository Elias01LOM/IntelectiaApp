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
    public partial class UCVendedor_Publicar : UserControl
    {
        public UCVendedor_Publicar()
        {
            InitializeComponent();
            CargarEstados();
            CargarCategorias();
        }
        private void CargarEstados()
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Nuevo");
            cmbEstado.Items.Add("Usado");
            cmbEstado.Items.Add("Digital");
            cmbEstado.SelectedIndex = 0;
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarCategorias()
        {
            CConexion objetoConexion = new CConexion();
            using (MySqlConnection conexion = objetoConexion.EstablecerConexion())
            {
                if (conexion != null)
                {
                    // Traemos ID y Nombre para que el Combo sepa qué guardar y qué mostrar
                    string query = "SELECT idCategoria, nombre FROM Categoria";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbCategoria.DataSource = dt;
                    cmbCategoria.DisplayMember = "nombre";       
                    cmbCategoria.ValueMember = "idCategoria";   
                    cmbCategoria.SelectedIndex = -1;             
                }
            }
        }
        private void btnPublicar_Click_1(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("El Título y el Precio son obligatorios.", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que seleccionó categoría
            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor selecciona una Categoría.", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Conexión y Guardado
            CConexion objetoConexion = new CConexion();
            using (MySqlConnection conexion = objetoConexion.EstablecerConexion())
            {
                if (conexion != null)
                {
                    // Obtener ID Vendedor
                    string queryVend = "SELECT idVendedor FROM Vendedor WHERE idUsuario = @idUser";
                    MySqlCommand cmdVend = new MySqlCommand(queryVend, conexion);
                    cmdVend.Parameters.AddWithValue("@idUser", Sesion.IdUsuario);

                    object result = cmdVend.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("No eres vendedor. No puedes publicar.");
                        return;
                    }
                    string idVendedor = result.ToString();

                    // INSERTAR LIBRO
                    string query = @"INSERT INTO Libro (isbn, titulo, autor, precio, stock, estado, formato, idVendedor, idCategoria, fechaPublicacion, editorial, edicion) 
                                     VALUES (@isbn, @titulo, @autor, @precio, @stock, @estado, 'Fisico', @idVend, @idCat, @fecha, @editorial, @edicion)";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@isbn", new Random().Next(100000, 999999).ToString());
                    cmd.Parameters.AddWithValue("@titulo", txtTitulo.Text.Trim());
                    cmd.Parameters.AddWithValue("@autor", txtAutor.Text.Trim());
                    cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text));

                    int stockVal = string.IsNullOrWhiteSpace(txtStock.Text) ? 1 : Convert.ToInt32(txtStock.Text);
                    cmd.Parameters.AddWithValue("@stock", stockVal);

                    cmd.Parameters.AddWithValue("@estado", cmbEstado.Text);
                    cmd.Parameters.AddWithValue("@idVend", idVendedor);

                    cmd.Parameters.AddWithValue("@idCat", cmbCategoria.SelectedValue.ToString());

                    cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                    cmd.Parameters.AddWithValue("@editorial", txtEditorial.Text.Trim());
                    cmd.Parameters.AddWithValue("@edicion", txtEdicion.Text.Trim());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("¡Libro publicado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
        }

        private void LimpiarCampos()
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtEditorial.Clear();
            txtEdicion.Clear();
            cmbCategoria.SelectedIndex = -1;
        }

        private void UCVendedor_Publicar_Load(object sender, EventArgs e)
        {

        }
    }
}