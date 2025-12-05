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
    public partial class UCGrupos_Explorar : UserControl
    {
        private FrmGrupos formularioPadre;
        public UCGrupos_Explorar(FrmGrupos padre)
        {
            InitializeComponent();
            this.formularioPadre = padre;
            CargarGruposSimulados();
        }
        public UCGrupos_Explorar() { InitializeComponent(); }
        private void CargarGruposSimulados()
        {
            flowGrupos.Controls.Clear();

            // --- SIMULACIÓN: Creamos botones manualmente ---
            CrearTarjeta("Cálculo Integral", "Matemáticas");
            CrearTarjeta("Programación C#", "Sistemas");
            CrearTarjeta("Inglés Avanzado", "Idiomas");
            CrearTarjeta("Debate Histórico", "Humanidades");
            CrearTarjeta("Física Mecánica", "Ciencias");
        }

        private void CrearTarjeta(string nombre, string materia)
        {
            Button btn = new Button();
            btn.Text = $"{nombre}\n({materia})";
            btn.Size = new Size(180, 100);
            btn.BackColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btn.Margin = new Padding(10);
            btn.Cursor = Cursors.Hand;

            // Al hacer clic, abrimos el chat con el nombre del botón
            btn.Click += (s, e) =>
            {
                if (formularioPadre != null) formularioPadre.AbrirChat(nombre);
            };

            flowGrupos.Controls.Add(btn);
        }
    }
}