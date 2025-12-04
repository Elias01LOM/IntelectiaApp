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
    public partial class FrmDashboard : Form
    {
        private Form formularioActivo = null;    // Variable para rastrear el formulario activo dentro del panel
        public FrmDashboard(string nombreUsuario)    // Constructor del formulario
        {
            InitializeComponent();
            lblSaludo.Text = "Hola, " + nombreUsuario;    // Asignamos el nombre del usuario al label de saludo

        }
        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); // Esto disparará el evento que cierra toda la app correctamente
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AbrirFormularioHijo(Form formularioHijo)
        {
            // Si ya hay un formulario abierto, lo cerramos para liberar memoria
            if (formularioActivo != null)
                formularioActivo.Close();
            formularioActivo = formularioHijo;
            // Configuramos el formulario hijo para que se comporte como un control
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panel3.Controls.Add(formularioHijo); // Agregamos el formulario al Panel Central
            panel3.Tag = formularioHijo;
            formularioHijo.BringToFront();    // Mostramos dicho formulario
            formularioHijo.Show();
        }

        private void btnBiblioteca_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmBiblioteca());
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmPerfil());
        }
    }
}
