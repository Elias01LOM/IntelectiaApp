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
    public partial class UCLibro : UserControl
    {
        public UCLibro()
        {
            InitializeComponent();
        }
        public void ConfigurarDatos(string titulo, string autor, string precio, string urlImagen)
        {
            lblTitulo.Text = titulo;
            lblAutor.Text = autor;
            // lblPrecio.Text = "$" + precio; // Descomentar cuando se tenga label de precio
            if (titulo.Length > 20) lblTitulo.Text = titulo.Substring(0, 18) + "...";    // Si el título es muy largo, se acorta
            // Lógica para cargar la imagen desde la URL
            try
            {
                // Válida que el link no sea basura
                if (!string.IsNullOrEmpty(urlImagen) && urlImagen.StartsWith("http"))
                {
                    picPortada.LoadAsync(urlImagen);
                }
                else
                {
                    picPortada.Image = null;    //  Si no hay link válido, cargamos una imagen por defecto local o nada
                    picPortada.BackColor = Color.LightGray; // Un fondo gris
                }
            }
            catch
            {
                // Si falla la descarga, mostramos un color sólido
                picPortada.Image = null;
                picPortada.BackColor = Color.Gray;
            }
        }

        private void UCLibro_Load(object sender, EventArgs e)
        {

        }

        private void picPortada_Click(object sender, EventArgs e)
        {

        }
    }
}
