namespace Giovannis.Modelos.Pedidos.Gerente
{
    partial class pedido_gerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pedido_gerente));
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_empleado = new System.Windows.Forms.Label();
            this.lbl_nombre_menu = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_tienda = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_id_pedido = new System.Windows.Forms.Label();
            this.editar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.editar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.ForeColor = System.Drawing.Color.White;
            this.lbl_precio.Location = new System.Drawing.Point(999, 355);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(64, 24);
            this.lbl_precio.TabIndex = 27;
            this.lbl_precio.Text = "Precio";
            // 
            // lbl_empleado
            // 
            this.lbl_empleado.AutoSize = true;
            this.lbl_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empleado.ForeColor = System.Drawing.Color.White;
            this.lbl_empleado.Location = new System.Drawing.Point(999, 214);
            this.lbl_empleado.Name = "lbl_empleado";
            this.lbl_empleado.Size = new System.Drawing.Size(97, 24);
            this.lbl_empleado.TabIndex = 26;
            this.lbl_empleado.Text = "Empleado";
            // 
            // lbl_nombre_menu
            // 
            this.lbl_nombre_menu.AutoSize = true;
            this.lbl_nombre_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_menu.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre_menu.Location = new System.Drawing.Point(999, 306);
            this.lbl_nombre_menu.Name = "lbl_nombre_menu";
            this.lbl_nombre_menu.Size = new System.Drawing.Size(133, 24);
            this.lbl_nombre_menu.TabIndex = 25;
            this.lbl_nombre_menu.Text = "Nombre menú";
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.ForeColor = System.Drawing.Color.White;
            this.lbl_cliente.Location = new System.Drawing.Point(1000, 261);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(68, 24);
            this.lbl_cliente.TabIndex = 24;
            this.lbl_cliente.Text = "Cliente";
            // 
            // lbl_tienda
            // 
            this.lbl_tienda.AutoSize = true;
            this.lbl_tienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tienda.ForeColor = System.Drawing.Color.White;
            this.lbl_tienda.Location = new System.Drawing.Point(999, 169);
            this.lbl_tienda.Name = "lbl_tienda";
            this.lbl_tienda.Size = new System.Drawing.Size(69, 24);
            this.lbl_tienda.TabIndex = 23;
            this.lbl_tienda.Text = "Tienda";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.White;
            this.lbl_fecha.Location = new System.Drawing.Point(999, 124);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(186, 24);
            this.lbl_fecha.TabIndex = 22;
            this.lbl_fecha.Text = "Fecha de realización";
            // 
            // lbl_id_pedido
            // 
            this.lbl_id_pedido.AutoSize = true;
            this.lbl_id_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_pedido.ForeColor = System.Drawing.Color.White;
            this.lbl_id_pedido.Location = new System.Drawing.Point(997, 59);
            this.lbl_id_pedido.Name = "lbl_id_pedido";
            this.lbl_id_pedido.Size = new System.Drawing.Size(291, 31);
            this.lbl_id_pedido.TabIndex = 21;
            this.lbl_id_pedido.Text = "Pedido: Nº(id pedido)";
            // 
            // editar
            // 
            this.editar.Image = ((System.Drawing.Image)(resources.GetObject("editar.Image")));
            this.editar.InitialImage = null;
            this.editar.Location = new System.Drawing.Point(1283, 59);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(110, 41);
            this.editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editar.TabIndex = 28;
            this.editar.TabStop = false;
            // 
            // pedido_gerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.editar);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.lbl_empleado);
            this.Controls.Add(this.lbl_nombre_menu);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.lbl_tienda);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_id_pedido);
            this.Name = "pedido_gerente";
            this.Size = new System.Drawing.Size(1429, 440);
            ((System.ComponentModel.ISupportInitialize)(this.editar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_empleado;
        private System.Windows.Forms.Label lbl_nombre_menu;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label lbl_tienda;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_id_pedido;
        private System.Windows.Forms.PictureBox editar;
    }
}
