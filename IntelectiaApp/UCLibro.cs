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
        // Se declaran las variables para guardar los datos del libro
        private string tituloGuardado;
        private string autorGuardado;
        private string precioGuardado;
        private string urlGuardada;
        public UCLibro()
        {
            InitializeComponent();
        }
        public void ConfigurarDatos(string titulo, string autor, string precio, string urlImagen)
        {
            tituloGuardado = titulo;    // Guardamos los datos en memoria
            autorGuardado = autor;
            precioGuardado = precio;
            urlGuardada = urlImagen;
            lblTitulo.Text = titulo;    // Asignamos los datos a la tarjeta
            lblAutor.Text = autor;
            // Implementamos la lógica visual de imagen
            try
            {
                if (!string.IsNullOrEmpty(urlImagen) && urlImagen.StartsWith("http"))
                    picPortada.LoadAsync(urlImagen);
                else
                    picPortada.BackColor = Color.LightGray;
            }
            catch { picPortada.BackColor = Color.LightGray; }
        }
        private void UCLibro_Load(object sender, EventArgs e)
        {

        }

        private void picPortada_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Creamos la ventana de detalle y se le 'vomitan' los datos guardados
            FrmDetalleLibro detalle = new FrmDetalleLibro(
                tituloGuardado,
                autorGuardado,
                precioGuardado,
                urlGuardada
            );
            // ShowDialog() es clave; ya que abre la ventana y bloquea la de atrás hasta cerrar
            detalle.ShowDialog();
        }
    }
}
