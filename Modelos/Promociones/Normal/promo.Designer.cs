namespace Giovannis.Modelos.Promociones
{
    partial class promo
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
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_cod = new System.Windows.Forms.Label();
            this.lbl_descuento = new System.Windows.Forms.Label();
            this.lbl_porcentaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F);
            this.lbl_codigo.ForeColor = System.Drawing.Color.White;
            this.lbl_codigo.Location = new System.Drawing.Point(160, 15);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(341, 40);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "(Código Promocional)";
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F);
            this.lbl_status.ForeColor = System.Drawing.Color.White;
            this.lbl_status.Location = new System.Drawing.Point(1101, 15);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(115, 40);
            this.lbl_status.TabIndex = 1;
            this.lbl_status.Text = "Status:  ";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F);
            this.lbl_estado.ForeColor = System.Drawing.Color.White;
            this.lbl_estado.Location = new System.Drawing.Point(1208, 15);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(99, 40);
            this.lbl_estado.TabIndex = 2;
            this.lbl_estado.Text = "Activo";
            // 
            // lbl_cod
            // 
            this.lbl_cod.AutoSize = true;
            this.lbl_cod.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F);
            this.lbl_cod.ForeColor = System.Drawing.Color.White;
            this.lbl_cod.Location = new System.Drawing.Point(30, 15);
            this.lbl_cod.Name = "lbl_cod";
            this.lbl_cod.Size = new System.Drawing.Size(124, 40);
            this.lbl_cod.TabIndex = 3;
            this.lbl_cod.Text = "Código:";
            // 
            // lbl_descuento
            // 
            this.lbl_descuento.AutoSize = true;
            this.lbl_descuento.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F);
            this.lbl_descuento.ForeColor = System.Drawing.Color.White;
            this.lbl_descuento.Location = new System.Drawing.Point(617, 15);
            this.lbl_descuento.Name = "lbl_descuento";
            this.lbl_descuento.Size = new System.Drawing.Size(172, 40);
            this.lbl_descuento.TabIndex = 4;
            this.lbl_descuento.Text = "Descuento:";
            // 
            // lbl_porcentaje
            // 
            this.lbl_porcentaje.AutoSize = true;
            this.lbl_porcentaje.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F);
            this.lbl_porcentaje.ForeColor = System.Drawing.Color.White;
            this.lbl_porcentaje.Location = new System.Drawing.Point(795, 15);
            this.lbl_porcentaje.Name = "lbl_porcentaje";
            this.lbl_porcentaje.Size = new System.Drawing.Size(124, 40);
            this.lbl_porcentaje.TabIndex = 5;
            this.lbl_porcentaje.Text = "Código:";
            // 
            // promo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.lbl_porcentaje);
            this.Controls.Add(this.lbl_descuento);
            this.Controls.Add(this.lbl_cod);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_codigo);
            this.Name = "promo";
            this.Size = new System.Drawing.Size(1430, 72);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_cod;
        private System.Windows.Forms.Label lbl_descuento;
        private System.Windows.Forms.Label lbl_porcentaje;
    }
}
