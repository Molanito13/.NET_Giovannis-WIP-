namespace Giovannis.Modelos.Pedidos.Gerente
{
    partial class pedidos_gerente
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.flw_pedidos = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(50, 27);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(446, 120);
            this.lbl_titulo.TabIndex = 9;
            this.lbl_titulo.Text = "Pedidos";
            // 
            // flw_pedidos
            // 
            this.flw_pedidos.AutoScroll = true;
            this.flw_pedidos.Location = new System.Drawing.Point(70, 176);
            this.flw_pedidos.Name = "flw_pedidos";
            this.flw_pedidos.Size = new System.Drawing.Size(1500, 881);
            this.flw_pedidos.TabIndex = 10;
            // 
            // pedidos_gerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Controls.Add(this.flw_pedidos);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "pedidos_gerente";
            this.Size = new System.Drawing.Size(1596, 1080);
            this.Load += new System.EventHandler(this.pedidos_gerente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.FlowLayoutPanel flw_pedidos;
    }
}
