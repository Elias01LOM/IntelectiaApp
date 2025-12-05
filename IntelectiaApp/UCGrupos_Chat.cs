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
    public partial class UCGrupos_Chat : UserControl
    {
        public string TituloGrupo { get; set; }
        public UCGrupos_Chat()
        {
            InitializeComponent();
        }

        private void UCGrupos_Chat_Load(object sender, EventArgs e)
        {
            lblTituloGrupo.Text = "Chat de: " + TituloGrupo;

            // --- SIMULACIÓN: 3 Personas ya hablaron antes que tú ---
            AgregarMensaje("Juan Pérez", "Hola a todos, ¿alguien tiene la tarea de ayer?", false);
            AgregarMensaje("María G.", "Sí, la subieron a Teams, revisa la carpeta.", false);
            AgregarMensaje("Profe. Roberto", "Jóvenes, recuerden que el examen es el viernes a las 8am.", false);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMensaje.Text)) return;

            // Agregar MI mensaje (True = Soy yo, sale verde)
            // Usamos Sesion.Nombre para que salga tu nombre real
            string miNombre = string.IsNullOrEmpty(Sesion.Nombre) ? "Yo" : Sesion.Nombre;
            AgregarMensaje(miNombre, txtMensaje.Text, true);

            txtMensaje.Clear();
        }

        private void AgregarMensaje(string usuario, string mensaje, bool soyYo)
        {
            // Creamos una "Burbuja" (Panel)
            Panel pnlBurbuja = new Panel();
            pnlBurbuja.AutoSize = true;
            pnlBurbuja.Padding = new Padding(10);
            pnlBurbuja.MaximumSize = new Size(400, 0); // Ancho máximo

            Label lbl = new Label();
            lbl.Text = $"{usuario}:\n{mensaje}";
            lbl.AutoSize = true;
            lbl.MaximumSize = new Size(380, 0);
            lbl.Font = new Font("Segoe UI", 10);

            if (soyYo)
            {
                pnlBurbuja.BackColor = Color.FromArgb(220, 248, 198); // Verde WhatsApp
                // Truco: Margen izquierdo grande para empujarlo a la derecha
                pnlBurbuja.Margin = new Padding(300, 5, 10, 5);
            }
            else
            {
                pnlBurbuja.BackColor = Color.White; // Blanco normal
                pnlBurbuja.Margin = new Padding(10, 5, 300, 5);
            }

            pnlBurbuja.Controls.Add(lbl);
            flowMensajes.Controls.Add(pnlBurbuja);

            // Auto-scroll al final para ver lo nuevo
            flowMensajes.ScrollControlIntoView(pnlBurbuja);
        }
    }
}