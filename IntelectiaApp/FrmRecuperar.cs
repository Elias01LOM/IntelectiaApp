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
        private const string CODIGO_MAESTRO = "12345";
        private string correoValidado = "";
        public FrmRecuperar()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {

            // Enviar codigo
            if (btnAccion.Text == "Enviar Enlace")
            {
                // Validar campo vacío
                if (string.IsNullOrWhiteSpace(txtCorreo.Text))
                {
                    MessageBox.Show("Escribe tu correo primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar en BD si existe el correo
                CConexion db = new CConexion();
                using (MySqlConnection conn = db.EstablecerConexion())
                {
                    if (conn.State != ConnectionState.Open) return;

                    string queryCheck = "SELECT count(*) FROM Usuario WHERE email = @mail AND estado = 1";
                    MySqlCommand cmdCheck = new MySqlCommand(queryCheck, conn);
                    cmdCheck.Parameters.AddWithValue("@mail", txtCorreo.Text.Trim());

                    int existe = Convert.ToInt32(cmdCheck.ExecuteScalar());

                    if (existe == 0)
                    {
                        MessageBox.Show("Ese correo no está registrado en nuestro sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Simular envío de correo
                correoValidado = txtCorreo.Text.Trim();
                MessageBox.Show($"Se ha enviado un correo a: {correoValidado}\nCódigo de seguridad: {CODIGO_MAESTRO}",
                                "Correo Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mostrar campo de código
                panel5.Visible = true;
                lblTituloCodigo.Visible = true;
                txtCodigo.Visible = true;

                // Desbloquear contenedor padre
                if (txtCodigo.Parent != null)
                {
                    txtCodigo.Parent.Visible = true;
                    txtCodigo.Parent.Enabled = true;
                }

                // Configurar campo de código para escribir
                txtCodigo.Enabled = true;
                txtCodigo.ReadOnly = false;
                txtCodigo.BringToFront();
                txtCodigo.Focus();

                // Bloquear correo y cambiar botón
                txtCorreo.Enabled = false;
                btnAccion.Text = "Verificar Código";
            }
            // Verifica el codigo
            else if (btnAccion.Text == "Verificar Código")
            {
                if (txtCodigo.Text == CODIGO_MAESTRO)
                {
                    RecuperarContrasenaReal();
                }
                else
                {
                    MessageBox.Show("El código ingresado es incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodigo.Clear();
                    txtCodigo.Focus();
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
                    string query = "SELECT contrasena, nombre FROM Usuario WHERE email = @mail";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@mail", correoValidado);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string pass = reader["contrasena"].ToString();

                        MessageBox.Show($"Identidad Verificada.",
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