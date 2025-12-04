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
    public partial class UCSeguridad_Datos : UserControl
    {
        public UCSeguridad_Datos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones Básicas
            if (string.IsNullOrWhiteSpace(txtContrasenaActual.Text) ||
                string.IsNullOrWhiteSpace(txtContrasenaNueva.Text))
            {
                MessageBox.Show("Por favor, ingrese tanto su contraseña actual como la nueva.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Conexión a Base de Datos
            CConexion objetoConexion = new CConexion();

            using (MySqlConnection conexion = objetoConexion.EstablecerConexion())
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    // Verificar identidad
                    string queryVerificar = "SELECT count(*) FROM Usuario WHERE idUsuario = @id AND contrasena = @passActual";

                    MySqlCommand cmdVerificar = new MySqlCommand(queryVerificar, conexion);
                    cmdVerificar.Parameters.AddWithValue("@id", Sesion.IdUsuario);
                    cmdVerificar.Parameters.AddWithValue("@passActual", txtContrasenaActual.Text.Trim());

                    int existe = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                    if (existe > 0)
                    {
                        // Actualizar a la nueva contraseña
                        string queryUpdate = "UPDATE Usuario SET contrasena = @passNueva WHERE idUsuario = @id";

                        MySqlCommand cmdUpdate = new MySqlCommand(queryUpdate, conexion);
                        cmdUpdate.Parameters.AddWithValue("@passNueva", txtContrasenaNueva.Text.Trim());
                        cmdUpdate.Parameters.AddWithValue("@id", Sesion.IdUsuario);

                        int filasAfectadas = cmdUpdate.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Su contraseña ha sido actualizada exitosamente.", "Cambio Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("La contraseña actual ingresada es incorrecta.", "Error de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LimpiarCampos()
        {
            txtContrasenaActual.Clear();
            txtContrasenaNueva.Clear();
        }
    }
}