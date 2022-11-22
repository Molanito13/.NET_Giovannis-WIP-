namespace Giovannis.Modelos.Stock
{
    partial class Ingredientes
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
            this.lbl_ingrediente_1 = new System.Windows.Forms.Label();
            this.lbl_ingrediente_2 = new System.Windows.Forms.Label();
            this.lbl_cantidad_1 = new System.Windows.Forms.Label();
            this.lbl_cantidad_2 = new System.Windows.Forms.Label();
            this.lbl_provedor_1 = new System.Windows.Forms.Label();
            this.lbl_provedor_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ingrediente_1
            // 
            this.lbl_ingrediente_1.AutoSize = true;
            this.lbl_ingrediente_1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F);
            this.lbl_ingrediente_1.ForeColor = System.Drawing.Color.White;
            this.lbl_ingrediente_1.Location = new System.Drawing.Point(27, 24);
            this.lbl_ingrediente_1.Name = "lbl_ingrediente_1";
            this.lbl_ingrediente_1.Size = new System.Drawing.Size(179, 40);
            this.lbl_ingrediente_1.TabIndex = 4;
            this.lbl_ingrediente_1.Text = "Ingrediente:";
            // 
            // lbl_ingrediente_2
            // 
            this.lbl_ingrediente_2.AutoSize = true;
            this.lbl_ingrediente_2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F);
            this.lbl_ingrediente_2.ForeColor = System.Drawing.Color.White;
            this.lbl_ingrediente_2.Location = new System.Drawing.Point(212, 24);
            this.lbl_ingrediente_2.Name = "lbl_ingrediente_2";
            this.lbl_ingrediente_2.Size = new System.Drawing.Size(125, 40);
            this.lbl_ingrediente_2.TabIndex = 5;
            this.lbl_ingrediente_2.Text = "Nombre";
            // 
            // lbl_cantidad_1
            // 
            this.lbl_cantidad_1.AutoSize = true;
            this.lbl_cantidad_1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F);
            this.lbl_cantidad_1.ForeColor = System.Drawing.Color.White;
            this.lbl_cantidad_1.Location = new System.Drawing.Point(502, 24);
            this.lbl_cantidad_1.Name = "lbl_cantidad_1";
            this.lbl_cantidad_1.Size = new System.Drawing.Size(149, 40);
            this.lbl_cantidad_1.TabIndex = 6;
            this.lbl_cantidad_1.Text = "Cantidad:";
            // 
            // lbl_cantidad_2
            // 
            this.lbl_cantidad_2.AutoSize = true;
            this.lbl_cantidad_2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F);
            this.lbl_cantidad_2.ForeColor = System.Drawing.Color.White;
            this.lbl_cantidad_2.Location = new System.Drawing.Point(657, 24);
            this.lbl_cantidad_2.Name = "lbl_cantidad_2";
            this.lbl_cantidad_2.Size = new System.Drawing.Size(125, 40);
            this.lbl_cantidad_2.TabIndex = 7;
            this.lbl_cantidad_2.Text = "Nombre";
            // 
            // lbl_provedor_1
            // 
            this.lbl_provedor_1.AutoSize = true;
            this.lbl_provedor_1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F);
            this.lbl_provedor_1.ForeColor = System.Drawing.Color.White;
            this.lbl_provedor_1.Location = new System.Drawing.Point(934, 24);
            this.lbl_provedor_1.Name = "lbl_provedor_1";
            this.lbl_provedor_1.Size = new System.Drawing.Size(167, 40);
            this.lbl_provedor_1.TabIndex = 8;
            this.lbl_provedor_1.Text = "Proveedor:";
            // 
            // lbl_provedor_2
            // 
            this.lbl_provedor_2.AutoSize = true;
            this.lbl_provedor_2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F);
            this.lbl_provedor_2.ForeColor = System.Drawing.Color.White;
            this.lbl_provedor_2.Location = new System.Drawing.Point(1090, 24);
            this.lbl_provedor_2.Name = "lbl_provedor_2";
            this.lbl_provedor_2.Size = new System.Drawing.Size(125, 40);
            this.lbl_provedor_2.TabIndex = 9;
            this.lbl_provedor_2.Text = "Nombre";
            // 
            // Ingredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.lbl_provedor_2);
            this.Controls.Add(this.lbl_provedor_1);
            this.Controls.Add(this.lbl_cantidad_2);
            this.Controls.Add(this.lbl_cantidad_1);
            this.Controls.Add(this.lbl_ingrediente_2);
            this.Controls.Add(this.lbl_ingrediente_1);
            this.Name = "Ingredientes";
            this.Size = new System.Drawing.Size(1374, 90);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ingrediente_1;
        private System.Windows.Forms.Label lbl_ingrediente_2;
        private System.Windows.Forms.Label lbl_cantidad_1;
        private System.Windows.Forms.Label lbl_cantidad_2;
        private System.Windows.Forms.Label lbl_provedor_1;
        private System.Windows.Forms.Label lbl_provedor_2;
    }
}
