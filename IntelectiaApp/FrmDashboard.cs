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
        public FrmDashboard()
        {
            InitializeComponent();
        }
        // Modificamos el constructor para pedir el nombre
    public FrmDashboard(string nombreUsuario)
        {
            InitializeComponent();
            lblSaludo.Text = $"Hola, {nombreUsuario}";
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
