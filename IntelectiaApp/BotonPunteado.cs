using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace IntelectiaApp
{
    public class BotonPunteado : Control
    {
        public BotonPunteado()
        {
            this.DoubleBuffered = true;    // Evita parpadeos
            this.Size = new Size(200, 100);
            this.BackColor = Color.White;
            this.Cursor = Cursors.Hand;
            this.Text = "   +   Crear Colección";    // Espacios para simular icono
            this.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.ForeColor = Color.FromArgb(44, 85, 48);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Pen lapizPunteado = new Pen(Color.FromArgb(44, 85, 48), 2);    // Configuración del lápiz punteado
            lapizPunteado.DashStyle = DashStyle.Dash;    // Establece el estilo punteado
            Rectangle rect = new Rectangle(1, 1, this.Width - 3, this.Height - 3);    // Creación del rectángulo
            g.DrawRectangle(lapizPunteado, rect);
            // Desarrolla el texto centrado
            TextRenderer.DrawText(g, this.Text, this.Font, rect, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
