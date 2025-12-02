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
    public partial class FmrLogin : Form
    {
        public FmrLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instanciamos nuestra clase de conexión
            CConexion objetoConexion = new CConexion();

            // Intentamos conectar
            try
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
            // URL de autenticación de Google (simulación)
            string urlGoogle = "https://accounts.google.com/signin/v2/identifier?flowName=GlifWebSignIn&flowEntry=ServiceLogin";

            try
            {
                // Abre el navegador predeterminado del sistema
                System.Diagnostics.Process.Start(urlGoogle);
                // Opcional: Mostrar mensaje en la app
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
            // 1. Validación de campos vacíos (Calidad de Software)
            if (string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Por favor, ingrese correo y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Conectar a la Base de Datos
            CConexion objetoConexion = new CConexion();
            MySqlConnection conexion = objetoConexion.EstablecerConexion();

            if (conexion != null) // Si la conexión abrió bien
            {
                try
                {
                    // 3. Consulta SQL Segura (Evita Inyección SQL usando parámetros)
                    string query = "SELECT tipoUsuario, nombre FROM Usuario WHERE email = @email AND contrasena = @pass AND estado = TRUE";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@email", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@pass", txtContraseña.Text);

                    // 4. Ejecutar lectura
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read()) // Si encontró un usuario
                    {
                        string rol = reader["tipoUsuario"].ToString();
                        string nombre = reader["nombre"].ToString();
                        MessageBox.Show($"¡Bienvenido {nombre}!\nRol: {rol}", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Ocultamos el Login
                        this.Hide();
                        // Instanciamos el Dashboard
                        FrmDashboard dash = new FrmDashboard();
                        // Nos suscribimos al evento "Closed" del Dashboard
                        // Esto sirve para que, cuando se cierra el Dashboard; provoca que se cierre toda la aplicación por completo
                        dash.FormClosed += (s, args) => this.Close();
                        // Se mostrará el Dashboard
                        dash.Show();
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
            // Aquí abriremos el formulario de registro (cuando lo creemos)
            // FrmRegistro registro = new FrmRegistro();
            // registro.Show();
            // this.Hide();
            MessageBox.Show("Módulo de Registro en construcción.", "Intelectia");
        }
    }
}
