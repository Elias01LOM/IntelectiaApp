using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntelectiaApp
{
    public partial class FrmPerfil : Form
    {
        private UCPerfil_Datos ucDatos = new UCPerfil_Datos();
        public FrmPerfil()
        {
            InitializeComponent();
        }
        private void FrmPerfil_Load(object sender, EventArgs e)
        {
            // Carga la primera pantalla automáticamente
            MostrarPanel(new UCPerfil_Datos());
        }

        private void MostrarPanel(UserControl panelHijo)
        {
            pnlContenido.Controls.Clear();
            panelHijo.Dock = DockStyle.Fill;

            // Lo agregamos al panel contenedor
            pnlContenido.Controls.Add(panelHijo);
            panelHijo.BringToFront();
        }

        private void btnInfoPersonal_Click(object sender, EventArgs e)
        {
            MostrarPanel(new UCPerfil_Datos());
        }

        private void btnMetodosPago_Click(object sender, EventArgs e)
        {
            MostrarPanel(new UCPago_Datos());
        }

        private void btnNavDirecciones_Click(object sender, EventArgs e)
        {
            MostrarPanel(new UCDirecciones_Datos());
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            MostrarPanel(new UCSeguridad_Datos());
        }
    }
}
