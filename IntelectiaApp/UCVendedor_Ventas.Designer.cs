namespace IntelectiaApp
{
    partial class UCVendedor_Ventas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGanancias = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblGanancias);
            this.groupBox1.Controls.Add(this.dgvVentas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.groupBox1.Location = new System.Drawing.Point(423, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 670);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // lblGanancias
            // 
            this.lblGanancias.AutoSize = true;
            this.lblGanancias.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblGanancias.ForeColor = System.Drawing.Color.Black;
            this.lblGanancias.Location = new System.Drawing.Point(35, 572);
            this.lblGanancias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGanancias.Name = "lblGanancias";
            this.lblGanancias.Size = new System.Drawing.Size(0, 20);
            this.lblGanancias.TabIndex = 12;
            // 
            // dgvVentas
            // 
            this.dgvVentas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(12, 92);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(392, 558);
            this.dgvVentas.TabIndex = 2;
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ventas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCVendedor_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.groupBox1);
            this.Name = "UCVendedor_Ventas";
            this.Size = new System.Drawing.Size(855, 683);
            this.Load += new System.EventHandler(this.UCVendedor_Ventas_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGanancias;
    }
}
