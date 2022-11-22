namespace Giovannis.Modelos.Menu
{
    partial class Menus
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
            this.label16 = new System.Windows.Forms.Label();
            this.flw_menus = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(50, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(378, 120);
            this.label16.TabIndex = 6;
            this.label16.Text = "Menús";
            // 
            // flw_menus
            // 
            this.flw_menus.AutoScroll = true;
            this.flw_menus.Location = new System.Drawing.Point(50, 150);
            this.flw_menus.Name = "flw_menus";
            this.flw_menus.Size = new System.Drawing.Size(1500, 881);
            this.flw_menus.TabIndex = 7;
            // 
            // Menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Controls.Add(this.flw_menus);
            this.Controls.Add(this.label16);
            this.Name = "Menus";
            this.Size = new System.Drawing.Size(1596, 1080);
            this.Load += new System.EventHandler(this.Menus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.FlowLayoutPanel flw_menus;
    }
}
