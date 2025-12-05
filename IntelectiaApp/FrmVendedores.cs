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
    public partial class FrmVendedores : Form
    {
        public FrmVendedores()
        {
            InitializeComponent();
            btnPublicar_Click(null, null);
        }
        private void FrmVendedores_Load(object sender, EventArgs e)
        {
            // Validar que sea Vendedor o Admin
            if (Sesion.TipoUsuario != "Vendedor" && Sesion.TipoUsuario != "Administrador")
            {
                MessageBox.Show("Módulo exclusivo para Vendedores Verificados.", "Acceso Restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pnlContenidoVendedor.Enabled = false;
                pnlMenuLateral.Enabled = false;
                return;
            }

            MostrarPanel(new UCVendedor_Publicar());
        }

        private void MostrarPanel(UserControl panelHijo)
        {
            pnlContenidoVendedor.Controls.Clear();
            panelHijo.Dock = DockStyle.Fill;
            pnlContenidoVendedor.Controls.Add(panelHijo);
            panelHijo.BringToFront();
        }

        private void btnMisLibros_Click_1(object sender, EventArgs e)
        {
            MostrarPanel (new UCVendedor_MisLibros());
        }
        private void btnPublicar_Click(object sender, EventArgs e)
        {
            MostrarPanel (new UCVendedor_Publicar());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            MostrarPanel (new UCVendedor_Ventas());
        }
    }
}