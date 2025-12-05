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
            btnBiblioteca_Click(null, null);    // Autoarranca el formulario de 'Mi Biblioteca'
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
            ResaltarBoton(btnBiblioteca);    // Resalta el botón activo
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmPerfil());
            ResaltarBoton(btnPerfil);    // Resalta el botón activo
        }
        private void ResaltarBoton(Button botonActivo)
        {
            // 1. Color Original (Verde Institucional)
            Color colorNormal = Color.FromArgb(44, 85, 48);

            // 2. Color "Seleccionado" (Un poco más oscuro o más claro para contraste)
            Color colorActivo = Color.FromArgb(35, 65, 38); // Verde más oscuro

            // 3. Resetear TODOS los botones (Pon aquí los nombres de tus 5 botones)
            btnBiblioteca.BackColor = colorNormal;
            btnMarketplace.BackColor = colorNormal;
            btnGrupos.BackColor = colorNormal;
            btnVendedores.BackColor = colorNormal;
            btnPerfil.BackColor = colorNormal;

            // 4. Encender SOLO el que dimos clic
            if (botonActivo != null)
            {
                botonActivo.BackColor = colorActivo;
                // Opcional: Poner una barrita de color al lado o cambiar el texto a Bold
            }
        }

        private void btnMarketplace_Click(object sender, EventArgs e)
        {
            ResaltarBoton(btnMarketplace);    // Resalta el botón activo
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            ResaltarBoton(btnGrupos);    // Resalta el botón activo
            AbrirFormularioHijo(new FrmGrupos());
        }

        private void btnVendedores_Click(object sender, EventArgs e)
        {
            ResaltarBoton(btnVendedores);    // Resalta el botón activo
            AbrirFormularioHijo(new FrmVendedores());
        }

        private void lblSaludo_Click(object sender, EventArgs e)
        {

        }

        private void lblCerrar_MouseEnter(object sender, EventArgs e)
        {
            lblCerrar.ForeColor = Color.Red;
        }

        private void lblCerrar_MouseLeave(object sender, EventArgs e)
        {
            lblCerrar.ForeColor = Color.Gray;
        }
    }
}
