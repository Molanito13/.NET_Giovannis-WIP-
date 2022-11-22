using Giovannis.Modelos.Notificaciones;
using System.Drawing;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Giovannis.Modelos
{
    partial class notificaciones
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
            this.flw_notisP = new System.Windows.Forms.FlowLayoutPanel();
            this.lst_nombres = new System.Windows.Forms.ListBox();
            this.rjTextBox1 = new Objetos.RJControls.RJTextBox();
            this.bttn_enviar = new Objetos.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // lbl_notificaciones
            // 
            this.lbl_notificaciones.AutoSize = true;
            this.lbl_notificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold);
            this.lbl_notificaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lbl_notificaciones.Location = new System.Drawing.Point(50, 50);
            this.lbl_notificaciones.Name = "lbl_notificaciones";
            this.lbl_notificaciones.Size = new System.Drawing.Size(735, 120);
            this.lbl_notificaciones.TabIndex = 0;
            this.lbl_notificaciones.Text = "Notificaciones";
            // 
            // flw_notisP
            // 
            this.flw_notisP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flw_notisP.AutoScroll = true;
            this.flw_notisP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flw_notisP.Location = new System.Drawing.Point(70, 210);
            this.flw_notisP.Name = "flw_notisP";
            this.flw_notisP.Size = new System.Drawing.Size(1468, 680);
            this.flw_notisP.TabIndex = 1;
            this.flw_notisP.WrapContents = false;
            // 
            // lst_nombres
            // 
            this.lst_nombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.lst_nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lst_nombres.ForeColor = System.Drawing.SystemColors.Info;
            this.lst_nombres.FormattingEnabled = true;
            this.lst_nombres.ItemHeight = 20;
            this.lst_nombres.Location = new System.Drawing.Point(70, 917);
            this.lst_nombres.Name = "lst_nombres";
            this.lst_nombres.Size = new System.Drawing.Size(182, 84);
            this.lst_nombres.TabIndex = 2;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.rjTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(35)))), ((int)(((byte)(22)))));
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(35)))), ((int)(((byte)(22)))));
            this.rjTextBox1.BorderRadius = 9;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.White;
            this.rjTextBox1.Location = new System.Drawing.Point(278, 917);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = true;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(1134, 82);
            this.rjTextBox1.TabIndex = 3;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // bttn_enviar
            // 
            this.bttn_enviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.bttn_enviar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.bttn_enviar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(35)))), ((int)(((byte)(22)))));
            this.bttn_enviar.BorderRadius = 9;
            this.bttn_enviar.BorderSize = 2;
            this.bttn_enviar.FlatAppearance.BorderSize = 0;
            this.bttn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_enviar.ForeColor = System.Drawing.Color.White;
            this.bttn_enviar.Location = new System.Drawing.Point(1419, 917);
            this.bttn_enviar.Name = "bttn_enviar";
            this.bttn_enviar.Size = new System.Drawing.Size(119, 82);
            this.bttn_enviar.TabIndex = 4;
            this.bttn_enviar.Text = "Enviar";
            this.bttn_enviar.TextColor = System.Drawing.Color.White;
            this.bttn_enviar.UseVisualStyleBackColor = false;
            // 
            // notificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Controls.Add(this.bttn_enviar);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.lst_nombres);
            this.Controls.Add(this.flw_notisP);
            this.Controls.Add(this.lbl_notificaciones);
            this.Name = "notificaciones";
            this.Size = new System.Drawing.Size(1596, 1080);
            this.Load += new System.EventHandler(this.notificaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_notificaciones;
        private System.Windows.Forms.FlowLayoutPanel flw_notisP;
        private ListBox lst_nombres;
        private Objetos.RJControls.RJTextBox rjTextBox1;
        private Objetos.RJControls.RJButton bttn_enviar;
    }
}
