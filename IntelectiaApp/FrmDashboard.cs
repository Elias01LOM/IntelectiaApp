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
        // Constructor del formulario
        public FrmDashboard(string nombreUsuario)
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
    }
}
