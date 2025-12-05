namespace IntelectiaApp
{
    partial class UCTarjetaLecturacs
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTituloPortada = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblTituloAbajo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(85)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.lblTituloPortada);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 140);
            this.panel1.TabIndex = 0;
            // 
            // lblTituloPortada
            // 
            this.lblTituloPortada.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloPortada.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblTituloPortada.ForeColor = System.Drawing.Color.White;
            this.lblTituloPortada.Location = new System.Drawing.Point(0, 0);
            this.lblTituloPortada.Name = "lblTituloPortada";
            this.lblTituloPortada.Size = new System.Drawing.Size(260, 140);
            this.lblTituloPortada.TabIndex = 0;
            this.lblTituloPortada.Text = "Python\\nPara Todos";
            this.lblTituloPortada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 262);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(280, 15);
            this.progressBar1.TabIndex = 1;
            // 
            // lblTituloAbajo
            // 
            this.lblTituloAbajo.AutoSize = true;
            this.lblTituloAbajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTituloAbajo.Location = new System.Drawing.Point(23, 172);
            this.lblTituloAbajo.Name = "lblTituloAbajo";
            this.lblTituloAbajo.Size = new System.Drawing.Size(53, 20);
            this.lblTituloAbajo.TabIndex = 2;
            this.lblTituloAbajo.Text = "label2";
            this.lblTituloAbajo.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAutor.Location = new System.Drawing.Point(24, 228);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(46, 18);
            this.lblAutor.TabIndex = 3;
            this.lblAutor.Text = "label3";
            this.lblAutor.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblPorcentaje.Location = new System.Drawing.Point(140, 285);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(46, 17);
            this.lblPorcentaje.TabIndex = 4;
            this.lblPorcentaje.Text = "label4";
            this.lblPorcentaje.Click += new System.EventHandler(this.label4_Click);
            // 
            // UCTarjetaLecturacs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTituloAbajo);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Name = "UCTarjetaLecturacs";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(300, 330);
            this.Load += new System.EventHandler(this.UCTarjetaLecturacs_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTituloPortada;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblTituloAbajo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblPorcentaje;
    }
}
