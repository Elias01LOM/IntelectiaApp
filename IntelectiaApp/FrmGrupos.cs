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
    public partial class FrmGrupos : Form
    {
        public FrmGrupos()
        {
            InitializeComponent();
        }
        private void FrmGrupos_Load(object sender, EventArgs e)
        {
            MostrarPanel(new UCGrupos_Explorar(this));
        }
        public void MostrarPanel(UserControl panelHijo)
        {
            pnlContenido.Controls.Clear();
            panelHijo.Dock = DockStyle.Fill;
            pnlContenido.Controls.Add(panelHijo);
            panelHijo.BringToFront();
        }
        public void AbrirChat(string nombreGrupo)
        {
            UCGrupos_Chat chat = new UCGrupos_Chat();
            chat.TituloGrupo = nombreGrupo; // Le pasamos el nombre del grupo
            MostrarPanel(chat);
        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {
            MostrarPanel(new UCGrupos_Explorar(this));
        }

        private void btnMisChats_Click(object sender, EventArgs e)
        {
        }
    }
}
