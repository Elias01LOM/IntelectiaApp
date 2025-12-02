namespace IntelectiaApp
{
    partial class FrmBiblioteca
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowPanelLibros = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteca";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowPanelLibros
            // 
            this.flowPanelLibros.AutoScroll = true;
            this.flowPanelLibros.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowPanelLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelLibros.Location = new System.Drawing.Point(0, 0);
            this.flowPanelLibros.Name = "flowPanelLibros";
            this.flowPanelLibros.Padding = new System.Windows.Forms.Padding(20);
            this.flowPanelLibros.Size = new System.Drawing.Size(1182, 1033);
            this.flowPanelLibros.TabIndex = 1;
            // 
            // FrmBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 1033);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowPanelLibros);
            this.Name = "FrmBiblioteca";
            this.Text = "FrmBiblioteca";
            this.Load += new System.EventHandler(this.FrmBiblioteca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowPanelLibros;
    }
}