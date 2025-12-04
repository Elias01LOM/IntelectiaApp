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
    public partial class FrmDetalleLibro : Form
    {
        public FrmDetalleLibro(string titulo, string autor, string precio, string urlImagen)    // Exige que le envien los cuatro datos clave al nacer
        {
            InitializeComponent();
            lblTitulo.Text = titulo;    // Asignamos los datos recibidos
            lblAutor.Text = autor;
            lblPrecio.Text = "$" + precio;
            try    // El 'try' evitara que la app falle si la URL de la imagen es inválida
            {
                if (!string.IsNullOrEmpty(urlImagen) && urlImagen.StartsWith("http"))
                {
                    picPortada.Load(urlImagen);
                }
                else
                {
                    picPortada.Image = null;
                    picPortada.BackColor = Color.LightGray;
                }
            }
            catch
            {
                picPortada.BackColor = Color.LightGray;    // Si la descarga falla, ponemos un color gris de fondo
            }
        }
        private void FrmDetalleLibro_Load(object sender, EventArgs e)
        {

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();    // Cierra el formulario de 'Detalles'
        }
    }
}
