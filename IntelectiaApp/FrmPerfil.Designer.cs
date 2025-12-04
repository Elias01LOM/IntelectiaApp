namespace IntelectiaApp
{
    partial class FrmPerfil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenuLateral = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSeguridad = new System.Windows.Forms.Button();
            this.btnInfoPersonal = new System.Windows.Forms.Button();
            this.btnMetodosPago = new System.Windows.Forms.Button();
            this.btnNavDirecciones = new System.Windows.Forms.Button();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.pnlMenuLateral.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuLateral
            // 
            this.pnlMenuLateral.Controls.Add(this.groupBox2);
            this.pnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuLateral.Name = "pnlMenuLateral";
            this.pnlMenuLateral.Size = new System.Drawing.Size(420, 683);
            this.pnlMenuLateral.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnNavDirecciones);
            this.groupBox2.Controls.Add(this.btnMetodosPago);
            this.groupBox2.Controls.Add(this.btnInfoPersonal);
            this.groupBox2.Controls.Add(this.btnSeguridad);
            this.groupBox2.Controls.Add(this.lblTitulo);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.groupBox2.Location = new System.Drawing.Point(7, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 670);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(5, 27);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(393, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Perfil y Ajustes";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.BackColor = System.Drawing.Color.White;
            this.btnSeguridad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeguridad.FlatAppearance.BorderSize = 0;
            this.btnSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeguridad.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSeguridad.ForeColor = System.Drawing.Color.Black;
            this.btnSeguridad.Location = new System.Drawing.Point(93, 255);
            this.btnSeguridad.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.Size = new System.Drawing.Size(225, 53);
            this.btnSeguridad.TabIndex = 2;
            this.btnSeguridad.Text = "Seguridad";
            this.btnSeguridad.UseVisualStyleBackColor = false;
            this.btnSeguridad.Click += new System.EventHandler(this.btnSeguridad_Click);
            // 
            // btnInfoPersonal
            // 
            this.btnInfoPersonal.BackColor = System.Drawing.Color.White;
            this.btnInfoPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfoPersonal.FlatAppearance.BorderSize = 0;
            this.btnInfoPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoPersonal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnInfoPersonal.ForeColor = System.Drawing.Color.Black;
            this.btnInfoPersonal.Location = new System.Drawing.Point(93, 155);
            this.btnInfoPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.btnInfoPersonal.Name = "btnInfoPersonal";
            this.btnInfoPersonal.Size = new System.Drawing.Size(225, 53);
            this.btnInfoPersonal.TabIndex = 3;
            this.btnInfoPersonal.Text = "Información Personal";
            this.btnInfoPersonal.UseVisualStyleBackColor = false;
            this.btnInfoPersonal.Click += new System.EventHandler(this.btnInfoPersonal_Click);
            // 
            // btnMetodosPago
            // 
            this.btnMetodosPago.BackColor = System.Drawing.Color.White;
            this.btnMetodosPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMetodosPago.FlatAppearance.BorderSize = 0;
            this.btnMetodosPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMetodosPago.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMetodosPago.ForeColor = System.Drawing.Color.Black;
            this.btnMetodosPago.Location = new System.Drawing.Point(93, 455);
            this.btnMetodosPago.Margin = new System.Windows.Forms.Padding(2);
            this.btnMetodosPago.Name = "btnMetodosPago";
            this.btnMetodosPago.Size = new System.Drawing.Size(225, 53);
            this.btnMetodosPago.TabIndex = 4;
            this.btnMetodosPago.Text = "Métodos de Pago";
            this.btnMetodosPago.UseVisualStyleBackColor = false;
            this.btnMetodosPago.Click += new System.EventHandler(this.btnMetodosPago_Click);
            // 
            // btnNavDirecciones
            // 
            this.btnNavDirecciones.BackColor = System.Drawing.Color.White;
            this.btnNavDirecciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDirecciones.FlatAppearance.BorderSize = 0;
            this.btnNavDirecciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDirecciones.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNavDirecciones.ForeColor = System.Drawing.Color.Black;
            this.btnNavDirecciones.Location = new System.Drawing.Point(93, 355);
            this.btnNavDirecciones.Margin = new System.Windows.Forms.Padding(2);
            this.btnNavDirecciones.Name = "btnNavDirecciones";
            this.btnNavDirecciones.Size = new System.Drawing.Size(225, 53);
            this.btnNavDirecciones.TabIndex = 5;
            this.btnNavDirecciones.Text = "Direcciones";
            this.btnNavDirecciones.UseVisualStyleBackColor = false;
            this.btnNavDirecciones.Click += new System.EventHandler(this.btnNavDirecciones_Click);
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 0);
            this.pnlContenido.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(855, 683);
            this.pnlContenido.TabIndex = 3;
            // 
            // FrmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(855, 683);
            this.Controls.Add(this.pnlMenuLateral);
            this.Controls.Add(this.pnlContenido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPerfil";
            this.Text = "FrmPerfil";
            this.pnlMenuLateral.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuLateral;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNavDirecciones;
        private System.Windows.Forms.Button btnMetodosPago;
        private System.Windows.Forms.Button btnInfoPersonal;
        private System.Windows.Forms.Button btnSeguridad;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlContenido;
    }
}