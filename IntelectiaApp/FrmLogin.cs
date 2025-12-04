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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            CConexion objetoConexion = new CConexion();    // Instanciamos nuestra clase de conexión
            try    // Intentamos la conexión con la base de datos
            {
                objetoConexion.EstablecerConexion();
                MessageBox.Show("¡Conexión a la BD Intelectia establecida correctamente!");
                objetoConexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falló la prueba: " + ex.Message);
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void lblCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void lblCerrar_MouseEnter(object sender, EventArgs e)
        {
            lblCerrar.ForeColor = Color.Red;
        }
        private void lblCerrar_MouseLeave(object sender, EventArgs e)
        {
            lblCerrar.ForeColor = Color.Gray;
        }
        private void botonRedondo2_Click(object sender, EventArgs e)
        {
            // URL de autenticación de Google
            string urlGoogle = "https://accounts.google.com/signin/v2/identifier?flowName=GlifWebSignIn&flowEntry=ServiceLogin";
            try
            {
                // Abre el navegador predeterminado del sistema
                System.Diagnostics.Process.Start(urlGoogle);
                // Muestra mensaje en la app
                MessageBox.Show("Se ha abierto el navegador para iniciar sesión con Google.\n\n" +
                                "Nota: La integración completa de OAuth requiere configuración de API en la nube.",
                                "Redirección", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el navegador: " + ex.Message);
            }
        }
        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            // Validamos que no hay campos vacíos
            if (string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Por favor, ingrese correo y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CConexion objetoConexion = new CConexion();    // Conectamos a la Base de Datos
            MySqlConnection conexion = objetoConexion.EstablecerConexion();

            if (conexion != null) // Si la conexión abrió bien
            {
                try
                {
                    // Consulta SQL
                    string query = "SELECT tipoUsuario, nombre FROM Usuario WHERE email = @email AND contrasena = @pass AND estado = TRUE";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@email", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@pass", txtContraseña.Text);
                    MySqlDataReader reader = cmd.ExecuteReader();    // Ejecuta la lectura
                    if (reader.Read()) // Si encuentra a algún usuario
                    {
                        // Para que se guarden los datos del usuario para proximas modificaciones o para mostrar
                        Sesion.IdUsuario = reader["idUsuario"].ToString(); 
                        Sesion.Nombre = reader["nombre"].ToString();
                        Sesion.Email = reader["email"].ToString();
                        Sesion.TipoUsuario = reader["tipoUsuario"].ToString();
                        string nombreBD = reader["nombre"].ToString();
                        string rolBD = reader["tipoUsuario"].ToString(); // Opcional, por si se usa luego
                        FrmDashboard dash = new FrmDashboard(nombreBD);
                        this.Hide();    // Ocultamos el Login
                        dash.FormClosed += (s, args) => this.Close();    // Aseguramos cierre total
                        dash.Show();    // Mostramos el Dashboard
                    }
                    else
                    {
                        MessageBox.Show("Credenciales incorrectas o cuenta inactiva.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al autenticar: " + ex.Message);
                }
                finally
                {
                    objetoConexion.CerrarConexion();
                }
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            FrmRegistro registro = new FrmRegistro();
            registro.ShowDialog();
            this.Show();
        }
        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRecuperar recuperar = new FrmRecuperar();
            recuperar.ShowDialog();
            this.Show();
        }
    }
}
