using Giovannis.Modelos.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Giovannis.Modelos.Pedidos;
using Giovannis.Modelos.Promociones;
using Giovannis.Modelos.Stock;
using Giovannis.Modelos.Menu;
using Giovannis.Modelos.Provedores;

namespace Giovannis.Modelos.Botoneras.Gerente
{
    public partial class botonera_gerente : UserControl
    {
        public botonera_gerente()
        {
            InitializeComponent();
        }

        private void bto_1_Click(object sender, EventArgs e)
        {
            string variable = bto_1.Text;
            Form1 f1 = (Form1)this.FindForm();

            if (variable == "Menús")
            {
                bto_1.Text = "Pedidos";
                bto_2.Text = "Promociones";
                bto_3.Text = "Stock";
                bto_4.Text = "Proveedores";
                f1.load_panel(new Menu.Gerente.Menus_gerente());
            }
            else
            {
                bto_1.Text = "Menús";
                bto_2.Text = "Promociones";
                bto_3.Text = "Stock";
                bto_4.Text = "Proveedores";
                f1.load_panel(new Pedidos.Gerente.pedidos_gerente());
            }
        }

        private void bto_2_Click(object sender, EventArgs e)
        {
            string variable = bto_2.Text;
            Form1 f1 = (Form1)this.FindForm();

            if (variable == "Promociones")
            {
                bto_1.Text = "Menús";
                bto_2.Text = "Pedidos";
                bto_3.Text = "Stock";
                bto_4.Text = "Proveedores";
                f1.load_panel(new Promociones.Gerente.promociones_gerente());

            }
            else
            {
                bto_1.Text = "Menús";
                bto_2.Text = "Promociones";
                bto_3.Text = "Stock";
                bto_4.Text = "Proveedores";
                f1.load_panel(new Pedidos.Gerente.pedidos_gerente());
            }
        }

        private void bto_3_Click(object sender, EventArgs e)
        {
            string variable = bto_3.Text;
            Form1 f1 = (Form1)this.FindForm();

            if (variable == "Promociones")
            {
                bto_1.Text = "Menús";
                bto_2.Text = "Pedidos";
                bto_3.Text = "Stock";
                bto_4.Text = "Proveedores";
                f1.load_panel(new Promociones.Gerente.promociones_gerente());

            }
            else
            {
                bto_1.Text = "Menús";
                bto_2.Text = "Pedidos";
                bto_3.Text = "Promociones";
                bto_4.Text = "Proveedores";
                f1.load_panel(new Stock.Gerente.stock_gerente());
            }
        }

        private void bto_4_Click(object sender, EventArgs e)
        {
            string variable = bto_4.Text;
            Form1 f1 = (Form1)this.FindForm();

            if (variable == "Stock")
            {
                bto_1.Text = "Menús";
                bto_2.Text = "Pedidos";
                bto_3.Text = "Stock";
                bto_4.Text = "Proveedores";
                f1.load_panel(new Stock.Gerente.stock_gerente());

            }
            else
            {
                bto_1.Text = "Menús";
                bto_2.Text = "Pedidos";
                bto_3.Text = "Promociones";
                bto_4.Text = "Stock";
                f1.load_panel(new Provedores.Gerente.proveedores_gerente());
            }
        }

        private void img_cambio_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)this.FindForm();
            f1.gerente_cambiar_botonera(new botonera_gerente2());
        }

        private void botonera_gerente_Load(object sender, EventArgs e)
        {

        }
    }
}
