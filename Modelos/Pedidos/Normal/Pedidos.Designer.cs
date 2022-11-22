namespace Giovannis.Modelos.Pedidos
{
    partial class Pedidos
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
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
            this.lbl_titulo.Location = new System.Drawing.Point(50, 50);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(446, 120);
            this.lbl_titulo.TabIndex = 8;
            this.lbl_titulo.Text = "Pedidos";
            // 
            // flw_pedidos
            // 
            this.flw_pedidos.AutoScroll = true;
            this.flw_pedidos.Location = new System.Drawing.Point(50, 150);
            this.flw_pedidos.Name = "flw_pedidos";
            this.flw_pedidos.Size = new System.Drawing.Size(1500, 881);
            this.flw_pedidos.TabIndex = 9;
            this.flw_pedidos.Paint += new System.Windows.Forms.PaintEventHandler(this.flw_pedidos_Paint);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Controls.Add(this.flw_pedidos);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Pedidos";
            this.Size = new System.Drawing.Size(1596, 1080);
            this.Load += new System.EventHandler(this.Pedidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.FlowLayoutPanel flw_pedidos;
    }
}
