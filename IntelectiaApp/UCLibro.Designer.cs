namespace IntelectiaApp
{
    partial class UCLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLibro));
            this.picPortada = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // picPortada
            // 
            this.picPortada.Dock = System.Windows.Forms.DockStyle.Top;
            this.picPortada.Image = ((System.Drawing.Image)(resources.GetObject("picPortada.Image")));
            this.picPortada.Location = new System.Drawing.Point(0, 0);
            this.picPortada.Name = "picPortada";
            this.picPortada.Size = new System.Drawing.Size(180, 190);
            this.picPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPortada.TabIndex = 1;
            this.picPortada.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTitulo.Location = new System.Drawing.Point(0, 190);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(124, 23);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Título del Libro";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAutor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAutor.ForeColor = System.Drawing.Color.Gray;
            this.lblAutor.Location = new System.Drawing.Point(0, 213);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(109, 20);
            this.lblAutor.TabIndex = 3;
            this.lblAutor.Text = "Autor del Libro";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Detalles";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UCLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picPortada);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "UCLibro";
            this.Size = new System.Drawing.Size(180, 280);
            this.Load += new System.EventHandler(this.UCLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPortada;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Button button1;
    }
}
