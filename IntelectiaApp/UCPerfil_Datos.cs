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
    public partial class UCPerfil_Datos : UserControl
    {
        public UCPerfil_Datos()
        {
            InitializeComponent();
        }

        private void UCPerfil_Datos_Load(object sender, EventArgs e)
        {
            txtNombre.Text = Sesion.Nombre;
            txtCorreo.Text = Sesion.Email;
            txtCorreo.Enabled = false;
        }
    }
}
