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
    public partial class UCTarjetaLecturacs : UserControl
    {
        public UCTarjetaLecturacs()
        {
            InitializeComponent();
        }
        public void ConfigurarTarjeta(string titulo, string autor, int porcentaje)
        {
            lblTituloPortada.Text = titulo; // El texto grande en lo verde
            lblTituloAbajo.Text = titulo;   // El texto negro abajo
            lblAutor.Text = autor;

            progressBar1.Value = porcentaje;
            lblPorcentaje.Text = porcentaje + "% completado";
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void UCTarjetaLecturacs_Load(object sender, EventArgs e)
        {

        }
    }
}
