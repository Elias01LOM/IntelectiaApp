using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class BotonRedondo : Button
{
    // Se declara el método 'BotonRedondo' (constructor)
    public BotonRedondo()
    {
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0;
        this.BackColor = Color.FromArgb(212, 175, 55); // Dorado
        this.ForeColor = Color.White;
        this.Cursor = Cursors.Hand;
    }

    // Se sobrescribe el método de pitado (polimorfismo)
    protected override void OnPaint(PaintEventArgs pevent)
    {
        GraphicsPath path = new GraphicsPath();
        // Radio de los bordes (20px)
        path.AddArc(0, 0, 20, 20, 180, 90);
        path.AddArc(this.Width - 21, 0, 20, 20, 270, 90);
        path.AddArc(this.Width - 21, this.Height - 21, 20, 20, 0, 90);
        path.AddArc(0, this.Height - 21, 20, 20, 90, 90);
        path.CloseAllFigures();

        this.Region = new Region(path);
        base.OnPaint(pevent);
    }
}