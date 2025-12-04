// Form para el registro de nuevos usuarios en la aplicación IntelectiaApp
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
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||    // Validación de campos vacíos
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Por favor, verifique que todos los campos estén completos.",
                                "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtContraseña.Text != txtConfirmar.Text)    // Validación de coincidencia de contraseñas
            {
                MessageBox.Show("Las contraseñas no coinciden, verifique.",
                                "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CConexion db = new CConexion();    // Acceso a la base de datos
            using (MySqlConnection conn = db.EstablecerConexion())
            {
                string queryCheck = "SELECT count(*) FROM Usuario WHERE email = @emailCheck";    // Verificacoón de datos duplicados
                MySqlCommand cmdCheck = new MySqlCommand(queryCheck, conn);
                cmdCheck.Parameters.AddWithValue("@emailCheck", txtCorreo.Text.Trim());
                int existe = Convert.ToInt32(cmdCheck.ExecuteScalar());
                if (existe > 0)
                {
                    MessageBox.Show("El correo electrónico ya se encuentra registrado.",
                                    "Registro Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string nuevoId = "USR" + new Random().Next(1000, 9999);    // Genera el 'id' de los usuarios
                string query = "INSERT INTO Usuario (idUsuario, nombre, email, contrasena, fechaRegistro, tipoUsuario, estado) VALUES (@id, @nom, @mail, @pass, CURDATE(), 'Estudiante', 1)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", nuevoId);
                cmd.Parameters.AddWithValue("@nom", txtNombre.Text.Trim());
                cmd.Parameters.AddWithValue("@mail", txtCorreo.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", txtContraseña.Text.Trim());
                cmd.ExecuteNonQuery();
                string queryEst = "INSERT INTO Estudiante (idEstudiante, idUsuario) VALUES (@idEst, @idUser)";
                MySqlCommand cmdEst = new MySqlCommand(queryEst, conn);
                cmdEst.Parameters.AddWithValue("@idEst", "EST" + new Random().Next(1000, 9999));
                cmdEst.Parameters.AddWithValue("@idUser", nuevoId);
                cmdEst.ExecuteNonQuery();
                MessageBox.Show("Cuenta registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                this.Close();
            }
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCorreo.Clear();
            txtContraseña.Clear();
            txtConfirmar.Clear();
        }
        private void lblCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lnkLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void IblCerrar_MouseEnter(object sender, EventArgs e)
        {
            lblCerrar.ForeColor = Color.Red;
        }
        private void lblCerrar_MauseLeave(object sender, EventArgs e)
        {
            lblCerrar.ForeColor = Color.Gray;
        }
    }
}
