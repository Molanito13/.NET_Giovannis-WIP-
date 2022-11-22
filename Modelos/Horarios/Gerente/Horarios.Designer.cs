namespace Giovannis.Modelos.Horarios.Gerente
{
    partial class Horarios
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
            this.flw_Horarios = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_hEntrada = new System.Windows.Forms.Label();
            this.lbl_hSalida = new System.Windows.Forms.Label();
            this.lbl_NyC = new System.Windows.Forms.Label();
            this.lbl_TotalHoras = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_notificaciones
            // 
            this.lbl_notificaciones.AutoSize = true;
            this.lbl_notificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold);
            this.lbl_notificaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lbl_notificaciones.Location = new System.Drawing.Point(51, 50);
            this.lbl_notificaciones.Name = "lbl_notificaciones";
            this.lbl_notificaciones.Size = new System.Drawing.Size(582, 153);
            this.lbl_notificaciones.TabIndex = 0;
            this.lbl_notificaciones.Text = "Horarios";
            // 
            // flw_Horarios
            // 
            this.flw_Horarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flw_Horarios.AutoScroll = true;
            this.flw_Horarios.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flw_Horarios.Location = new System.Drawing.Point(69, 303);
            this.flw_Horarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flw_Horarios.Name = "flw_Horarios";
            this.flw_Horarios.Size = new System.Drawing.Size(2000, 835);
            this.flw_Horarios.TabIndex = 1;
            this.flw_Horarios.WrapContents = false;
            // 
            // lbl_hEntrada
            // 
            this.lbl_hEntrada.AutoSize = true;
            this.lbl_hEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lbl_hEntrada.Location = new System.Drawing.Point(754, 249);
            this.lbl_hEntrada.Name = "lbl_hEntrada";
            this.lbl_hEntrada.Size = new System.Drawing.Size(227, 39);
            this.lbl_hEntrada.TabIndex = 2;
            this.lbl_hEntrada.Text = "Hora entrada";
            // 
            // lbl_hSalida
            // 
            this.lbl_hSalida.AutoSize = true;
            this.lbl_hSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lbl_hSalida.Location = new System.Drawing.Point(1235, 249);
            this.lbl_hSalida.Name = "lbl_hSalida";
            this.lbl_hSalida.Size = new System.Drawing.Size(201, 39);
            this.lbl_hSalida.TabIndex = 3;
            this.lbl_hSalida.Text = "Hora salida";
            // 
            // lbl_NyC
            // 
            this.lbl_NyC.AutoSize = true;
            this.lbl_NyC.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NyC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lbl_NyC.Location = new System.Drawing.Point(70, 249);
            this.lbl_NyC.Name = "lbl_NyC";
            this.lbl_NyC.Size = new System.Drawing.Size(361, 49);
            this.lbl_NyC.TabIndex = 4;
            this.lbl_NyC.Text = "Nombre y código";
            // 
            // lbl_TotalHoras
            // 
            this.lbl_TotalHoras.AutoSize = true;
            this.lbl_TotalHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lbl_TotalHoras.Location = new System.Drawing.Point(1665, 249);
            this.lbl_TotalHoras.Name = "lbl_TotalHoras";
            this.lbl_TotalHoras.Size = new System.Drawing.Size(248, 49);
            this.lbl_TotalHoras.TabIndex = 5;
            this.lbl_TotalHoras.Text = "Total horas";
            // 
            // Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Controls.Add(this.lbl_TotalHoras);
            this.Controls.Add(this.lbl_NyC);
            this.Controls.Add(this.lbl_hSalida);
            this.Controls.Add(this.lbl_hEntrada);
            this.Controls.Add(this.flw_Horarios);
            this.Controls.Add(this.lbl_notificaciones);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Horarios";
            this.Size = new System.Drawing.Size(2128, 1329);
            this.Load += new System.EventHandler(this.Horarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_notificaciones;
        private System.Windows.Forms.FlowLayoutPanel flw_Horarios;
        private System.Windows.Forms.Label lbl_hEntrada;
        private System.Windows.Forms.Label lbl_hSalida;
        private System.Windows.Forms.Label lbl_NyC;
        private System.Windows.Forms.Label lbl_TotalHoras;
    }
}
