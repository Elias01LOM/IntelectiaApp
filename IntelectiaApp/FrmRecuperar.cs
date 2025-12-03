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
    public partial class FrmRecuperar : Form
    {
        private string codigoGenerado = "";
        private string correoValidado = "";
        public FrmRecuperar()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            // Se envia el correo para confirmar
            if (btnAccion.Text == "Enviar Enlace")
            {
                if (string.IsNullOrWhiteSpace(txtCorreo.Text))
                {
                    MessageBox.Show("Escribe tu correo primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar en BD si existe el correo
                CConexion db = new CConexion();
                using (MySqlConnection conn = db.EstablecerConexion())
                {
                }
                Random rnd = new Random();
                codigoGenerado = rnd.Next(1000, 9999).ToString();
                correoValidado = txtCorreo.Text;

                // Se hace el envio de codigo
                MessageBox.Show($"\nSe ha enviado un correo a: {correoValidado}\nCódigo de seguridad: {codigoGenerado}",
                                "Correo Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblTituloCodigo.Visible = true;
                txtCodigo.Visible = true;

                // Deshabilitamos el correo para que no lo cambien a medio proceso
                txtCorreo.Enabled = false;

                // Cambiamos el botón para el siguiente paso
                btnAccion.Text = "Verificar Código";
            }
            // Se verifica el codigo
            else if (btnAccion.Text == "Verificar Código")
            {
                if (txtCodigo.Text == codigoGenerado)
                {
                    // Si el codigo es correcto se procede al cambio de contraseña
                    RecuperarContrasenaReal();
                }
                else
                {
                    MessageBox.Show("El código ingresado es incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void RecuperarContrasenaReal()
        {
            CConexion db = new CConexion();
            using (MySqlConnection conn = db.EstablecerConexion())
            {
                try
                {
                    // Buscamos la contraseña del correo que validamos antes
                    string query = "SELECT contrasena, nombre FROM Usuario WHERE email = @mail";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@mail", correoValidado);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string pass = reader["contrasena"].ToString();
                        string nombre = reader["nombre"].ToString();

                        MessageBox.Show($"Identidad Verificada.\n\nHola {nombre}, tu contraseña es: {pass}",
                                        "Recuperación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de base de datos: " + ex.Message);
                }
            }
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IblCerrar_MouseEnter(object sender, EventArgs e)
        {
            lblCerrar.ForeColor = Color.Red;
        }

        private void IblCerrar_MouseLeave(object sender, EventArgs e)
        {
            lblCerrar.ForeColor = Color.Gray;
        }

        private void lnkLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}