namespace Giovannis.Modelos.Provedores
{
    partial class proveedores
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
            this.flw_proveedores = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_proveedores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flw_proveedores
            // 
            this.flw_proveedores.AutoScroll = true;
            this.flw_proveedores.Location = new System.Drawing.Point(87, 231);
            this.flw_proveedores.Name = "flw_proveedores";
            this.flw_proveedores.Size = new System.Drawing.Size(1454, 787);
            this.flw_proveedores.TabIndex = 3;
            // 
            // lbl_proveedores
            // 
            this.lbl_proveedores.AutoSize = true;
            this.lbl_proveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold);
            this.lbl_proveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lbl_proveedores.Location = new System.Drawing.Point(50, 50);
            this.lbl_proveedores.Name = "lbl_proveedores";
            this.lbl_proveedores.Size = new System.Drawing.Size(672, 120);
            this.lbl_proveedores.TabIndex = 2;
            this.lbl_proveedores.Text = "Proveedores";
            // 
            // proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Controls.Add(this.lbl_proveedores);
            this.Controls.Add(this.flw_proveedores);
            this.Name = "proveedores";
            this.Size = new System.Drawing.Size(1596, 1080);
            this.Load += new System.EventHandler(this.proveedores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flw_proveedores;
        private System.Windows.Forms.Label lbl_proveedores;
    }
}
