namespace Giovannis.Modelos.Altas_y_Bajas
{
    partial class flw_AltasBajas
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

            this.listaEmpleados = new System.Windows.Forms.ListBox();
            this.txt_backLista = new Objetos.RJControls.RJTextBox();
            this.bttBaja = new Objetos.RJControls.RJButton();
            this.bttAlta = new Objetos.RJControls.RJButton();
            this.txt_backAlta = new Objetos.RJControls.RJTextBox();
            this.txtNombre = new Objetos.RJControls.RJTextBox();
            this.txtApellidos = new Objetos.RJControls.RJTextBox();
            this.txtDNI = new Objetos.RJControls.RJTextBox();
            this.txtPuesto = new Objetos.RJControls.RJTextBox();
            this.SuspendLayout();

            // 
            // listaEmpleados
            // 
            this.listaEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.listaEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.listaEmpleados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listaEmpleados.FormattingEnabled = true;
            this.listaEmpleados.ItemHeight = 25;
            this.listaEmpleados.Location = new System.Drawing.Point(69, 97);
            this.listaEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.listaEmpleados.Name = "listaEmpleados";
            this.listaEmpleados.Size = new System.Drawing.Size(392, 279);
            this.listaEmpleados.TabIndex = 3;
            // 
            // txt_backLista
            // 
            this.txt_backLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.txt_backLista.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(35)))), ((int)(((byte)(22)))));
            this.txt_backLista.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_backLista.BorderRadius = 9;
            this.txt_backLista.BorderSize = 2;
            this.txt_backLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_backLista.ForeColor = System.Drawing.Color.Black;
            this.txt_backLista.Location = new System.Drawing.Point(39, 64);
            this.txt_backLista.Margin = new System.Windows.Forms.Padding(67, 62, 67, 62);
            this.txt_backLista.Multiline = true;
            this.txt_backLista.Name = "txt_backLista";
            this.txt_backLista.Padding = new System.Windows.Forms.Padding(9);
            this.txt_backLista.PasswordChar = false;
            this.txt_backLista.PlaceholderColor = System.Drawing.Color.Black;
            this.txt_backLista.PlaceholderText = "";
            this.txt_backLista.Size = new System.Drawing.Size(449, 346);
            this.txt_backLista.TabIndex = 4;
            this.txt_backLista.Texts = "";
            this.txt_backLista.UnderlinedStyle = false;
            // 
            // bttBaja
            // 
            this.bttBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(34)))), ((int)(((byte)(24)))));
            this.bttBaja.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(34)))), ((int)(((byte)(24)))));
            this.bttBaja.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttBaja.BorderRadius = 19;
            this.bttBaja.BorderSize = 0;
            this.bttBaja.FlatAppearance.BorderSize = 0;
            this.bttBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttBaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.bttBaja.Location = new System.Drawing.Point(497, 180);
            this.bttBaja.Margin = new System.Windows.Forms.Padding(4);
            this.bttBaja.Name = "bttBaja";
            this.bttBaja.Size = new System.Drawing.Size(240, 67);
            this.bttBaja.TabIndex = 5;
            this.bttBaja.Text = "Dar de Baja";
            this.bttBaja.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.bttBaja.UseVisualStyleBackColor = false;
            this.bttBaja.Click += new System.EventHandler(this.bto_Horarios_Click);
            // 
            // bttAlta
            // 
            this.bttAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(64)))));
            this.bttAlta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(64)))));
            this.bttAlta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttAlta.BorderRadius = 19;
            this.bttAlta.BorderSize = 0;
            this.bttAlta.FlatAppearance.BorderSize = 0;
            this.bttAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAlta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.bttAlta.Location = new System.Drawing.Point(745, 180);
            this.bttAlta.Margin = new System.Windows.Forms.Padding(4);
            this.bttAlta.Name = "bttAlta";
            this.bttAlta.Size = new System.Drawing.Size(240, 67);
            this.bttAlta.TabIndex = 6;
            this.bttAlta.Text = "Dar de Alta";
            this.bttAlta.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.bttAlta.UseVisualStyleBackColor = false;
            // 
            // txt_backAlta
            // 
            this.txt_backAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.txt_backAlta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(35)))), ((int)(((byte)(22)))));
            this.txt_backAlta.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_backAlta.BorderRadius = 9;
            this.txt_backAlta.BorderSize = 2;
            this.txt_backAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_backAlta.ForeColor = System.Drawing.Color.Black;
            this.txt_backAlta.Location = new System.Drawing.Point(992, 64);
            this.txt_backAlta.Margin = new System.Windows.Forms.Padding(67, 62, 67, 62);
            this.txt_backAlta.Multiline = true;
            this.txt_backAlta.Name = "txt_backAlta";
            this.txt_backAlta.Padding = new System.Windows.Forms.Padding(9);
            this.txt_backAlta.PasswordChar = false;
            this.txt_backAlta.PlaceholderColor = System.Drawing.Color.Black;
            this.txt_backAlta.PlaceholderText = "";
            this.txt_backAlta.Size = new System.Drawing.Size(449, 346);
            this.txt_backAlta.TabIndex = 7;
            this.txt_backAlta.Texts = "";
            this.txt_backAlta.UnderlinedStyle = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(35)))), ((int)(((byte)(22)))));
            this.txtNombre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(35)))), ((int)(((byte)(22)))));
            this.txtNombre.BorderRadius = 13;
            this.txtNombre.BorderSize = 3;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(1024, 97);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(7);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.Size = new System.Drawing.Size(401, 52);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.Texts = "Nombre";
            this.txtNombre.UnderlinedStyle = false;
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.txtApellidos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(35)))), ((int)(((byte)(22)))));
            this.txtApellidos.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(35)))), ((int)(((byte)(22)))));
            this.txtApellidos.BorderRadius = 13;
            this.txtApellidos.BorderSize = 3;
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.txtApellidos.ForeColor = System.Drawing.Color.White;
            this.txtApellidos.Location = new System.Drawing.Point(1024, 195);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(7);
            this.txtApellidos.Multiline = false;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Padding = new System.Windows.Forms.Padding(7);
            this.txtApellidos.PasswordChar = false;
            this.txtApellidos.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtApellidos.PlaceholderText = "";
            this.txtApellidos.Size = new System.Drawing.Size(401, 52);
            this.txtApellidos.TabIndex = 9;
            this.txtApellidos.Texts = "Apellidos";
            this.txtApellidos.UnderlinedStyle = false;
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.txtDNI.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(35)))), ((int)(((byte)(22)))));
            this.txtDNI.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(35)))), ((int)(((byte)(22)))));
            this.txtDNI.BorderRadius = 13;
            this.txtDNI.BorderSize = 3;
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.txtDNI.ForeColor = System.Drawing.Color.White;
            this.txtDNI.Location = new System.Drawing.Point(1024, 304);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(7);
            this.txtDNI.Multiline = false;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Padding = new System.Windows.Forms.Padding(7);
            this.txtDNI.PasswordChar = false;
            this.txtDNI.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDNI.PlaceholderText = "";
            this.txtDNI.Size = new System.Drawing.Size(194, 52);
            this.txtDNI.TabIndex = 10;
            this.txtDNI.Texts = "DNI";
            this.txtDNI.UnderlinedStyle = false;
            // 
            // txtPuesto
            // 
            this.txtPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.txtPuesto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(35)))), ((int)(((byte)(22)))));
            this.txtPuesto.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(35)))), ((int)(((byte)(22)))));
            this.txtPuesto.BorderRadius = 13;
            this.txtPuesto.BorderSize = 3;
            this.txtPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.txtPuesto.ForeColor = System.Drawing.Color.White;
            this.txtPuesto.Location = new System.Drawing.Point(1244, 304);
            this.txtPuesto.Margin = new System.Windows.Forms.Padding(7);
            this.txtPuesto.Multiline = false;
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Padding = new System.Windows.Forms.Padding(7);
            this.txtPuesto.PasswordChar = false;
            this.txtPuesto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPuesto.PlaceholderText = "";
            this.txtPuesto.Size = new System.Drawing.Size(181, 52);
            this.txtPuesto.TabIndex = 11;
            this.txtPuesto.Texts = "Puesto";
            this.txtPuesto.UnderlinedStyle = false;
            // 
            // flw_AltasBajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.bttAlta);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txt_backAlta);
            this.Controls.Add(this.bttBaja);
            this.Controls.Add(this.listaEmpleados);
            this.Controls.Add(this.txt_backLista);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "flw_AltasBajas";
            this.Size = new System.Drawing.Size(1483, 529);
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.ListBox listaEmpleados;
        private Objetos.RJControls.RJTextBox txt_backLista;
        private Objetos.RJControls.RJButton bttBaja;
        private Objetos.RJControls.RJButton bttAlta;
        private Objetos.RJControls.RJTextBox txt_backAlta;
        private Objetos.RJControls.RJTextBox txtNombre;
        private Objetos.RJControls.RJTextBox txtApellidos;
        private Objetos.RJControls.RJTextBox txtDNI;
        private Objetos.RJControls.RJTextBox txtPuesto;
    }
}
