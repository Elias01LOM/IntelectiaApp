namespace IntelectiaApp
{
    partial class UCGrupos_Chat
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
            this.flowMensajes = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTituloGrupo = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnEnviar = new BotonRedondo();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtMensaje);
            this.groupBox1.Controls.Add(this.btnEnviar);
            this.groupBox1.Controls.Add(this.flowMensajes);
            this.groupBox1.Controls.Add(this.lblTituloGrupo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.groupBox1.Location = new System.Drawing.Point(423, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 670);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // flowMensajes
            // 
            this.flowMensajes.AutoScroll = true;
            this.flowMensajes.AutoSize = true;
            this.flowMensajes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowMensajes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flowMensajes.Location = new System.Drawing.Point(6, 67);
            this.flowMensajes.Name = "flowMensajes";
            this.flowMensajes.Size = new System.Drawing.Size(398, 449);
            this.flowMensajes.TabIndex = 2;
            this.flowMensajes.WrapContents = false;
            // 
            // lblTituloGrupo
            // 
            this.lblTituloGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloGrupo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGrupo.Location = new System.Drawing.Point(5, 27);
            this.lblTituloGrupo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloGrupo.Name = "lblTituloGrupo";
            this.lblTituloGrupo.Size = new System.Drawing.Size(400, 37);
            this.lblTituloGrupo.TabIndex = 1;
            this.lblTituloGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.SystemColors.Window;
            this.txtMensaje.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMensaje.Location = new System.Drawing.Point(6, 562);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(398, 25);
            this.txtMensaje.TabIndex = 26;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(248, 614);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(156, 41);
            this.btnEnviar.TabIndex = 25;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // UCGrupos_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.groupBox1);
            this.Name = "UCGrupos_Chat";
            this.Size = new System.Drawing.Size(855, 683);
            this.Load += new System.EventHandler(this.UCGrupos_Chat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowMensajes;
        private System.Windows.Forms.Label lblTituloGrupo;
        private BotonRedondo btnEnviar;
        private System.Windows.Forms.TextBox txtMensaje;
    }
}
