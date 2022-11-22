namespace Giovannis.Modelos.Horarios.Gerente
{
    partial class Empleados
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
            this.lbl_nombreEmpleado = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_llegada = new System.Windows.Forms.Label();
            this.lbl_salida = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_nombreEmpleado
            // 
            this.lbl_nombreEmpleado.AutoSize = true;
            this.lbl_nombreEmpleado.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F);
            this.lbl_nombreEmpleado.ForeColor = System.Drawing.Color.White;
            this.lbl_nombreEmpleado.Location = new System.Drawing.Point(25, 24);
            this.lbl_nombreEmpleado.Name = "lbl_nombreEmpleado";
            this.lbl_nombreEmpleado.Size = new System.Drawing.Size(125, 40);
            this.lbl_nombreEmpleado.TabIndex = 4;
            this.lbl_nombreEmpleado.Text = "Roberto";
            this.lbl_nombreEmpleado.Click += new System.EventHandler(this.lbl_nEmpleado_Click);
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F);
            this.lbl_Nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_Nombre.Location = new System.Drawing.Point(174, 24);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(101, 40);
            this.lbl_Nombre.TabIndex = 5;
            this.lbl_Nombre.Text = "0023";
            // 
            // lbl_llegada
            // 
            this.lbl_llegada.AutoSize = true;
            this.lbl_llegada.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F);
            this.lbl_llegada.ForeColor = System.Drawing.Color.White;
            this.lbl_llegada.Location = new System.Drawing.Point(317, 24);
            this.lbl_llegada.Name = "lbl_llegada";
            this.lbl_llegada.Size = new System.Drawing.Size(111, 40);
            this.lbl_llegada.TabIndex = 6;
            this.lbl_llegada.Text = "08:30";
            // 
            // lbl_salida
            // 
            this.lbl_salida.AutoSize = true;
            this.lbl_salida.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F);
            this.lbl_salida.ForeColor = System.Drawing.Color.White;
            this.lbl_salida.Location = new System.Drawing.Point(740, 24);
            this.lbl_salida.Name = "lbl_salida";
            this.lbl_salida.Size = new System.Drawing.Size(111, 40);
            this.lbl_salida.TabIndex = 7;
            this.lbl_salida.Text = "17:30";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F);
            this.lbl_total.ForeColor = System.Drawing.Color.White;
            this.lbl_total.Location = new System.Drawing.Point(1215, 24);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(90, 40);
            this.lbl_total.TabIndex = 8;
            this.lbl_total.Text = "9:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(141, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = ":";
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_salida);
            this.Controls.Add(this.lbl_llegada);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_nombreEmpleado);
            this.Name = "Empleados";
            this.Size = new System.Drawing.Size(1470, 90);
            this.Load += new System.EventHandler(this.Empleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombreEmpleado;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_llegada;
        private System.Windows.Forms.Label lbl_salida;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label1;
    }
}
