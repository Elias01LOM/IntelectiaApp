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
            CargarLibrosDesdeBD();      // Se encarga de cargar los libros desde la base de datos
            CargarSeccionLectura();     // Se encarga de cargar la sección de 'Lecturas en Progreso'
            CargarLecturasRecientes();  // Se encarga de cargar la sección de 'Continuar Leyendo'
            CargarColecciones();        // Se encarga de cargar la sección de 'Mis Colecciones'
        }
        // Creamos y cargamos la sección de 'Mis Colecciones'
        private void CargarSeccionLectura()
        {
            flowLectura.Controls.Clear();    // Limpia los controles existentes
            UCTarjetaLecturacs card1 = new UCTarjetaLecturacs();
            card1.ConfigurarTarjeta("Python\nPara Todos", "Raúl G. Duque", 75);
            flowLectura.Controls.Add(card1);
            UCTarjetaLecturacs card2 = new UCTarjetaLecturacs();
            card2.ConfigurarTarjeta("Machine\nLearning", "Rudolph Russell", 15);
            flowLectura.Controls.Add(card2);
            UCTarjetaLecturacs card3 = new UCTarjetaLecturacs();
            card3.ConfigurarTarjeta("Manual de\nNodeJS", "Alejandro Morales", 60);
            flowLectura.Controls.Add(card3);
        }
        // Creamos y cargamos la sección de 'Continuar Leyendo'
        private void CargarLecturasRecientes()
        {
            flowLectura.Controls.Clear();    // Limpia los controles existentes
            UCTarjetaLecturacs card1 = new UCTarjetaLecturacs();
            card1.ConfigurarTarjeta("Python\nPara Todos", "Raúl G. Duque", 75);
            flowLectura.Controls.Add(card1);
            UCTarjetaLecturacs card2 = new UCTarjetaLecturacs();
            card2.ConfigurarTarjeta("Machine\nLearning", "Rudolph Russell", 15);
            flowLectura.Controls.Add(card2);
            UCTarjetaLecturacs card3 = new UCTarjetaLecturacs();
            card3.ConfigurarTarjeta("Manual de\nNodeJS", "Alejandro Morales", 60);
            flowLectura.Controls.Add(card3);
        }
        // Creamos y cargamos la sección de 'Mis Colecciones'
        private void CargarColecciones()
        {
            flowColecciones.Controls.Clear();    // Limpia los controles existentes
            BotonPunteado btnCrear = new BotonPunteado();    // Desarrollamos el botón 'Crear Colección'
            btnCrear.Size = new Size(280, 100);
            btnCrear.Text = "+  Crear Colección";
            flowColecciones.Controls.Add(btnCrear);
            Panel pnlTesis = new Panel();    // Se crea una panel siple para la colección 'Proyecto de Tesis'
            pnlTesis.Size = new Size(280, 100);
            pnlTesis.BackColor = Color.FromArgb(35, 65, 38);
            Label lblTesis = new Label();
            lblTesis.Text = "Proyecto de Tesis";
            lblTesis.ForeColor = Color.White;
            lblTesis.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblTesis.Dock = DockStyle.Fill;
            lblTesis.TextAlign = ContentAlignment.MiddleCenter;
            pnlTesis.Controls.Add(lblTesis);
            flowColecciones.Controls.Add(pnlTesis);
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Configuramos el cuadro de diálogo para abrir archivos
            OpenFileDialog abrirArchivo = new OpenFileDialog();
            abrirArchivo.Filter = "Documentos PDF|*.pdf|Libros EPUB|*.epub|Todos los archivos|*.*";
            abrirArchivo.Title = "Selecciona un documento para tu biblioteca";
            if (abrirArchivo.ShowDialog() == DialogResult.OK)    // Si el usuario selecciona un archivo y presiona 'Aceptar'
            {
                // Obtienemos el nombre del archivo sin la ruta completa ni la extensión
                string nombreArchivo = System.IO.Path.GetFileNameWithoutExtension(abrirArchivo.FileName);
                string autor = "Documento Local";    // Simulamos un autor genérico
                UCTarjetaLecturacs nuevaTarjeta = new UCTarjetaLecturacs();    // Crea una nueva tarjeta de lectura de forma dinámica
                nuevaTarjeta.ConfigurarTarjeta(nombreArchivo, autor, 0);       // Configura la tarjeta que marque '0s' de progreso
                flowLectura.Controls.Add(nuevaTarjeta);                // Agrega la nueva tarjeta al 'flowLayoutPanel'
                flowLectura.Controls.SetChildIndex(nuevaTarjeta, 0);   // Utilizamos 'SetChildIndex' para que aparezca primero
                MessageBox.Show($"¡Documento '{nombreArchivo}' agregado a tu biblioteca!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Configuramos el cuadro de diálogo para abrir archivos
            OpenFileDialog abrirArchivo = new OpenFileDialog();
            abrirArchivo.Filter = "Documentos PDF|*.pdf|Libros EPUB|*.epub|Todos los archivos|*.*";
            abrirArchivo.Title = "Selecciona un documento para tu biblioteca";
            if (abrirArchivo.ShowDialog() == DialogResult.OK)    // Si el usuario selecciona un archivo y presiona 'Aceptar'
            {
                // Obtienemos el nombre del archivo sin la ruta completa ni la extensión
                string nombreArchivo = System.IO.Path.GetFileNameWithoutExtension(abrirArchivo.FileName);
                string autor = "Documento Local";    // Simulamos un autor genérico
                UCTarjetaLecturacs nuevaTarjeta = new UCTarjetaLecturacs();    // Crea una nueva tarjeta de lectura de forma dinámica
                nuevaTarjeta.ConfigurarTarjeta(nombreArchivo, autor, 0);       // Configura la tarjeta que marque '0s' de progreso
                flowLectura.Controls.Add(nuevaTarjeta);                // Agrega la nueva tarjeta al 'flowLayoutPanel'
                flowLectura.Controls.SetChildIndex(nuevaTarjeta, 0);   // Utilizamos 'SetChildIndex' para que aparezca primero
                MessageBox.Show($"¡Documento '{nombreArchivo}' agregado a tu biblioteca!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblTabMarketplace_Click(object sender, EventArgs e)
        {
            FrmDashboard dashboardPrincipal = this.ParentForm as FrmDashboard;    // Creamos una referencia al formulario principal (dashboard)
            if (dashboardPrincipal != null)    // Verificamos que la referencia no sea nula
            {
                dashboardPrincipal.AbrirMarketplaceDesdeBiblioteca();    // Llamamos al método público del dashboard para abrir el marketplace
            }
        }

        private void pnlContenedorPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
