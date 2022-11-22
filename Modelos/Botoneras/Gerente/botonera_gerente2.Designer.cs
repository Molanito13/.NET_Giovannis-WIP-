namespace Giovannis.Modelos.Botoneras.Gerente
{
    partial class botonera_gerente2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(botonera_gerente2));
            this.img_cambio = new System.Windows.Forms.PictureBox();
            this.bto_logo = new Objetos.RJControls.RJCircularPictureBox();
            this.bto_1 = new Objetos.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.img_cambio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bto_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // img_cambio
            // 
            this.img_cambio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.img_cambio.Image = ((System.Drawing.Image)(resources.GetObject("img_cambio.Image")));
            this.img_cambio.Location = new System.Drawing.Point(114, 978);
            this.img_cambio.Name = "img_cambio";
            this.img_cambio.Size = new System.Drawing.Size(100, 50);
            this.img_cambio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_cambio.TabIndex = 15;
            this.img_cambio.TabStop = false;
            this.img_cambio.Click += new System.EventHandler(this.img_cambio_Click);
            // 
            // bto_logo
            // 
            this.bto_logo.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.bto_logo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(34)))), ((int)(((byte)(24)))));
            this.bto_logo.BorderColor2 = System.Drawing.Color.Black;
            this.bto_logo.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.bto_logo.BorderSize = 2;
            this.bto_logo.GradientAngle = 50F;
            this.bto_logo.Image = ((System.Drawing.Image)(resources.GetObject("bto_logo.Image")));
            this.bto_logo.Location = new System.Drawing.Point(57, 74);
            this.bto_logo.Name = "bto_logo";
            this.bto_logo.Size = new System.Drawing.Size(204, 204);
            this.bto_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bto_logo.TabIndex = 11;
            this.bto_logo.TabStop = false;
            // 
            // bto_1
            // 
            this.bto_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(34)))), ((int)(((byte)(24)))));
            this.bto_1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(34)))), ((int)(((byte)(24)))));
            this.bto_1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bto_1.BorderRadius = 19;
            this.bto_1.BorderSize = 0;
            this.bto_1.FlatAppearance.BorderSize = 0;
            this.bto_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bto_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bto_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.bto_1.Location = new System.Drawing.Point(32, 534);
            this.bto_1.Name = "bto_1";
            this.bto_1.Size = new System.Drawing.Size(247, 79);
            this.bto_1.TabIndex = 10;
            this.bto_1.Text = "Horarios";
            this.bto_1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.bto_1.UseVisualStyleBackColor = false;
            this.bto_1.Click += new System.EventHandler(this.bto_1_Click);
            // 
            // botonera_gerente2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.img_cambio);
            this.Controls.Add(this.bto_logo);
            this.Controls.Add(this.bto_1);
            this.Name = "botonera_gerente2";
            this.Size = new System.Drawing.Size(324, 1080);
            ((System.ComponentModel.ISupportInitialize)(this.img_cambio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bto_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img_cambio;
        private Objetos.RJControls.RJCircularPictureBox bto_logo;
        private Objetos.RJControls.RJButton bto_1;
    }
}
