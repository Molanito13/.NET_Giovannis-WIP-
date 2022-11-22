namespace Giovannis
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rjDropdownMenu1 = new Objetos.RJControls.RJDropdownMenu(this.components);
            this.rjDropdownMenu2 = new Objetos.RJControls.RJDropdownMenu(this.components);
            this.rjDropdownMenu3 = new Objetos.RJControls.RJDropdownMenu(this.components);
            this.rjDropdownMenu4 = new Objetos.RJControls.RJDropdownMenu(this.components);
            this.panel_login_inicial = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_botoneras = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rjDropdownMenu1
            // 
            this.rjDropdownMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rjDropdownMenu1.IsMainMenu = false;
            this.rjDropdownMenu1.MenuItemHeight = 25;
            this.rjDropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Name = "rjDropdownMenu1";
            this.rjDropdownMenu1.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // rjDropdownMenu2
            // 
            this.rjDropdownMenu2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rjDropdownMenu2.IsMainMenu = false;
            this.rjDropdownMenu2.MenuItemHeight = 25;
            this.rjDropdownMenu2.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu2.Name = "rjDropdownMenu2";
            this.rjDropdownMenu2.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu2.Size = new System.Drawing.Size(61, 4);
            // 
            // rjDropdownMenu3
            // 
            this.rjDropdownMenu3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rjDropdownMenu3.IsMainMenu = false;
            this.rjDropdownMenu3.MenuItemHeight = 25;
            this.rjDropdownMenu3.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu3.Name = "rjDropdownMenu3";
            this.rjDropdownMenu3.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu3.Size = new System.Drawing.Size(61, 4);
            // 
            // rjDropdownMenu4
            // 
            this.rjDropdownMenu4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rjDropdownMenu4.IsMainMenu = false;
            this.rjDropdownMenu4.MenuItemHeight = 25;
            this.rjDropdownMenu4.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu4.Name = "rjDropdownMenu4";
            this.rjDropdownMenu4.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu4.Size = new System.Drawing.Size(61, 4);
            // 
            // panel_login_inicial
            // 
            this.panel_login_inicial.Location = new System.Drawing.Point(0, 0);
            this.panel_login_inicial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_login_inicial.Name = "panel_login_inicial";
            this.panel_login_inicial.Size = new System.Drawing.Size(2560, 1329);
            this.panel_login_inicial.TabIndex = 0;
            this.panel_login_inicial.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_login_inicial_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_login_inicial);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(11, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2128, 1281);
            this.panel1.TabIndex = 6;
            // 
            // pnl_botoneras
            // 
            this.pnl_botoneras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.pnl_botoneras.Location = new System.Drawing.Point(0, 0);
            this.pnl_botoneras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_botoneras.Name = "pnl_botoneras";
            this.pnl_botoneras.Size = new System.Drawing.Size(432, 1329);
            this.pnl_botoneras.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2139, 1281);
            this.Controls.Add(this.pnl_botoneras);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Objetos.RJControls.RJDropdownMenu rjDropdownMenu1;
        private Objetos.RJControls.RJDropdownMenu rjDropdownMenu2;
        private Objetos.RJControls.RJDropdownMenu rjDropdownMenu3;
        private Objetos.RJControls.RJDropdownMenu rjDropdownMenu4;
        private System.Windows.Forms.Panel panel_login_inicial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_botoneras;
    }
}

