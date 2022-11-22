namespace Giovannis.Modelos.Notificaciones
{
    partial class flw_notis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flw_notis));
            this.txt_nombre = new Objetos.RJControls.RJTextBox();
            this.img_nombre = new Objetos.RJControls.RJCircularPictureBox();
            this.txt_cuerpo = new Objetos.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_nombre)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.txt_nombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(35)))), ((int)(((byte)(22)))));
            this.txt_nombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_nombre.BorderRadius = 9;
            this.txt_nombre.BorderSize = 2;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.Black;
            this.txt_nombre.Location = new System.Drawing.Point(123, 38);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(50);
            this.txt_nombre.Multiline = false;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Padding = new System.Windows.Forms.Padding(7);
            this.txt_nombre.PasswordChar = false;
            this.txt_nombre.PlaceholderColor = System.Drawing.Color.Black;
            this.txt_nombre.PlaceholderText = "";
            this.txt_nombre.Size = new System.Drawing.Size(200, 35);
            this.txt_nombre.TabIndex = 0;
            this.txt_nombre.Texts = "";
            this.txt_nombre.UnderlinedStyle = false;
            
            
            // 
            // img_nombre
            // 
            this.img_nombre.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.img_nombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.img_nombre.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(35)))), ((int)(((byte)(22)))));
            this.img_nombre.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.img_nombre.BorderSize = 2;
            this.img_nombre.GradientAngle = 50F;
            this.img_nombre.Image = ((System.Drawing.Image)(resources.GetObject("img_nombre.Image")));
            this.img_nombre.Location = new System.Drawing.Point(38, 22);
            this.img_nombre.Name = "img_nombre";
            this.img_nombre.Size = new System.Drawing.Size(66, 66);
            this.img_nombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_nombre.TabIndex = 1;
            this.img_nombre.TabStop = false;
            // 
            // txt_cuerpo
            // 
            this.txt_cuerpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.txt_cuerpo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(35)))), ((int)(((byte)(22)))));
            this.txt_cuerpo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_cuerpo.BorderRadius = 9;
            this.txt_cuerpo.BorderSize = 2;
            this.txt_cuerpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuerpo.ForeColor = System.Drawing.Color.Black;
            this.txt_cuerpo.Location = new System.Drawing.Point(123, 118);
            this.txt_cuerpo.Margin = new System.Windows.Forms.Padding(50);
            this.txt_cuerpo.Multiline = true;
            this.txt_cuerpo.Name = "txt_cuerpo";
            this.txt_cuerpo.Padding = new System.Windows.Forms.Padding(7);
            this.txt_cuerpo.PasswordChar = false;
            this.txt_cuerpo.PlaceholderColor = System.Drawing.Color.Black;
            this.txt_cuerpo.PlaceholderText = "";
            this.txt_cuerpo.Size = new System.Drawing.Size(1217, 133);
            this.txt_cuerpo.TabIndex = 2;
            this.txt_cuerpo.Texts = "";
            this.txt_cuerpo.UnderlinedStyle = false;
            // 
            // flw_notis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.txt_cuerpo);
            this.Controls.Add(this.img_nombre);
            this.Controls.Add(this.txt_nombre);
            this.Name = "flw_notis";
            this.Size = new System.Drawing.Size(1429, 300);
            ((System.ComponentModel.ISupportInitialize)(this.img_nombre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Objetos.RJControls.RJTextBox txt_nombre;
        private Objetos.RJControls.RJCircularPictureBox img_nombre;
        private Objetos.RJControls.RJTextBox txt_cuerpo;
    }
}
