namespace Giovannis.Modelos.Altas_y_Bajas
{
    partial class AltasBajasCompleto
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
            this.lbl_alt_bajas = new System.Windows.Forms.Label();
            this.flw_alt_bajas = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lbl_alt_bajas
            // 
            this.lbl_alt_bajas.AutoSize = true;
            this.lbl_alt_bajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold);
            this.lbl_alt_bajas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lbl_alt_bajas.Location = new System.Drawing.Point(50, 50);
            this.lbl_alt_bajas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_alt_bajas.Name = "lbl_alt_bajas";
            this.lbl_alt_bajas.Size = new System.Drawing.Size(851, 153);
            this.lbl_alt_bajas.TabIndex = 1;
            this.lbl_alt_bajas.Text = "Altas y Bajas";
            // 
            // flw_alt_bajas
            // 
            this.flw_alt_bajas.Location = new System.Drawing.Point(76, 282);
            this.flw_alt_bajas.Name = "flw_alt_bajas";
            this.flw_alt_bajas.Size = new System.Drawing.Size(1500, 430);
            this.flw_alt_bajas.TabIndex = 2;
            // 
            // AltasBajasCompleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Controls.Add(this.flw_alt_bajas);
            this.Controls.Add(this.lbl_alt_bajas);
            this.Name = "AltasBajasCompleto";
            this.Size = new System.Drawing.Size(1596, 1055);
            this.Load += new System.EventHandler(this.AltasBajasCompleto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_alt_bajas;
        private System.Windows.Forms.FlowLayoutPanel flw_alt_bajas;
    }
}
