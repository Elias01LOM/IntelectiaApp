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
    public partial class UCTarjetaProducto : UserControl
    {
        public UCTarjetaProducto()
        {
            InitializeComponent();
        }
        // Variables para guardar los datos (útiles para cuando hagamos clic)
        public string _isbn, _titulo, _autor, _precio, _url, _formato;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void ConfigurarProducto(string isbn, string titulo, string autor, string precio, string urlImagen, string formato)
        {
            _isbn = isbn; _titulo = titulo; _autor = autor; _precio = precio; _url = urlImagen; _formato = formato;

            lblTitulo.Text = titulo;
            lblAutor.Text = autor;
            lblPrecio.Text = "$ " + precio;

            // Carga de imagen segura
            try { if (!string.IsNullOrEmpty(urlImagen)) picPortada.LoadAsync(urlImagen); }
            catch { picPortada.BackColor = Color.Gold; } // Si falla, se ve dorado como tu diseño
        }
    }
}
