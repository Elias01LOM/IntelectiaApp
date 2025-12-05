using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IntelectiaApp
{
    public partial class FrmBiblioteca : Form
    {
        public FrmBiblioteca()
        {
            InitializeComponent();
        }

        private void FrmBiblioteca_Load(object sender, EventArgs e)
        {
            CargarLibrosDesdeBD();
            CargarSeccionLectura();
        }
        private void CargarSeccionLectura()
        {
            // Limpiamos
            flowLectura.Controls.Clear();

            // DATOS MOCKUP (Idénticos a tu imagen)
            // 1. Python
            UCTarjetaLecturacs card1 = new UCTarjetaLecturacs();
            card1.ConfigurarTarjeta("Python\nPara Todos", "Raúl G. Duque", 75);
            flowLectura.Controls.Add(card1);

            // 2. Machine Learning
            UCTarjetaLecturacs card2 = new UCTarjetaLecturacs();
            card2.ConfigurarTarjeta("Machine\nLearning", "Rudolph Russell", 15);
            flowLectura.Controls.Add(card2);

            // 3. Node JS
            UCTarjetaLecturacs card3 = new UCTarjetaLecturacs();
            card3.ConfigurarTarjeta("Manual de\nNodeJS", "Alejandro Morales", 60);
            flowLectura.Controls.Add(card3);
        }

        private void CargarLibrosDesdeBD()
        {
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowPanelLibros_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
