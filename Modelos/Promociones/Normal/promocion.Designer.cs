namespace Giovannis.Modelos.Promociones
{
    partial class promocion
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
            this.lbl_notificaciones = new System.Windows.Forms.Label();
            this.flw_promociones = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lbl_notificaciones
            // 
            this.lbl_notificaciones.AutoSize = true;
            this.lbl_notificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold);
            this.lbl_notificaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lbl_notificaciones.Location = new System.Drawing.Point(50, 50);
            this.lbl_notificaciones.Name = "lbl_notificaciones";
            this.lbl_notificaciones.Size = new System.Drawing.Size(689, 120);
            this.lbl_notificaciones.TabIndex = 1;
            this.lbl_notificaciones.Text = "Promociones";
            // 
            // flw_promociones
            // 
            this.flw_promociones.AutoScroll = true;
            this.flw_promociones.Location = new System.Drawing.Point(70, 226);
            this.flw_promociones.Name = "flw_promociones";
            this.flw_promociones.Size = new System.Drawing.Size(1454, 787);
            this.flw_promociones.TabIndex = 2;
            // 
            // promocion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Controls.Add(this.flw_promociones);
            this.Controls.Add(this.lbl_notificaciones);
            this.Name = "promocion";
            this.Size = new System.Drawing.Size(1596, 1080);
            this.Load += new System.EventHandler(this.promocion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_notificaciones;
        private System.Windows.Forms.FlowLayoutPanel flw_promociones;
    }
}
