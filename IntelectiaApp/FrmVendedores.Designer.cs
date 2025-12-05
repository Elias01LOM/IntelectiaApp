namespace IntelectiaApp
{
    partial class FrmVendedores
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
            this.btnMisLibros = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenidoVendedor = new System.Windows.Forms.Panel();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnPublicar = new System.Windows.Forms.Button();
            this.pnlMenuLateral.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuLateral
            // 
            this.pnlMenuLateral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMenuLateral.Controls.Add(this.groupBox2);
            this.pnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuLateral.Name = "pnlMenuLateral";
            this.pnlMenuLateral.Size = new System.Drawing.Size(420, 683);
            this.pnlMenuLateral.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnPublicar);
            this.groupBox2.Controls.Add(this.btnVentas);
            this.groupBox2.Controls.Add(this.btnMisLibros);
            this.groupBox2.Controls.Add(this.lblTitulo);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.groupBox2.Location = new System.Drawing.Point(7, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 670);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // btnMisLibros
            // 
            this.btnMisLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(85)))), ((int)(((byte)(48)))));
            this.btnMisLibros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMisLibros.FlatAppearance.BorderSize = 0;
            this.btnMisLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisLibros.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMisLibros.ForeColor = System.Drawing.Color.White;
            this.btnMisLibros.Location = new System.Drawing.Point(93, 277);
            this.btnMisLibros.Margin = new System.Windows.Forms.Padding(2);
            this.btnMisLibros.Name = "btnMisLibros";
            this.btnMisLibros.Size = new System.Drawing.Size(225, 53);
            this.btnMisLibros.TabIndex = 4;
            this.btnMisLibros.Text = "Mis Libros";
            this.btnMisLibros.UseVisualStyleBackColor = false;
            this.btnMisLibros.Click += new System.EventHandler(this.btnMisLibros_Click_1);
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
            this.lblTitulo.Text = "Menú Vendedor";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContenidoVendedor
            // 
            this.pnlContenidoVendedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContenidoVendedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenidoVendedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenidoVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContenidoVendedor.Name = "pnlContenidoVendedor";
            this.pnlContenidoVendedor.Size = new System.Drawing.Size(855, 683);
            this.pnlContenidoVendedor.TabIndex = 19;
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(85)))), ((int)(((byte)(48)))));
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Location = new System.Drawing.Point(93, 376);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(2);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(225, 53);
            this.btnVentas.TabIndex = 6;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnPublicar
            // 
            this.btnPublicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(85)))), ((int)(((byte)(48)))));
            this.btnPublicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPublicar.FlatAppearance.BorderSize = 0;
            this.btnPublicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublicar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPublicar.ForeColor = System.Drawing.Color.White;
            this.btnPublicar.Location = new System.Drawing.Point(93, 176);
            this.btnPublicar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(225, 53);
            this.btnPublicar.TabIndex = 7;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.UseVisualStyleBackColor = false;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // FrmVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 683);
            this.Controls.Add(this.pnlMenuLateral);
            this.Controls.Add(this.pnlContenidoVendedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVendedores";
            this.Text = "FrmVendedores";
            this.pnlMenuLateral.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuLateral;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMisLibros;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlContenidoVendedor;
        private System.Windows.Forms.Button btnPublicar;
        private System.Windows.Forms.Button btnVentas;
    }
}