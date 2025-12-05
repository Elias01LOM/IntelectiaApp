namespace IntelectiaApp
{
    partial class UCGrupos_Explorar
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowGrupos = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.flowGrupos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Explorar Grupos de Estudio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.flowGrupos);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.groupBox1.Location = new System.Drawing.Point(423, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 670);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // flowGrupos
            // 
            this.flowGrupos.AutoScroll = true;
            this.flowGrupos.AutoSize = true;
            this.flowGrupos.Controls.Add(this.label1);
            this.flowGrupos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowGrupos.Location = new System.Drawing.Point(3, 39);
            this.flowGrupos.Name = "flowGrupos";
            this.flowGrupos.Size = new System.Drawing.Size(404, 628);
            this.flowGrupos.TabIndex = 2;
            // 
            // UCGrupos_Explorar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.groupBox1);
            this.Name = "UCGrupos_Explorar";
            this.Size = new System.Drawing.Size(855, 683);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowGrupos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowGrupos;
    }
}
