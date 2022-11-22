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
using Giovannis.Modelos.Menu;
using Giovannis.Modelos.Stock;
using Giovannis.Modelos;

namespace Giovannis
{
    public partial class botonera : UserControl
    {
        public botonera()
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
                f1.load_panel(new Menus());
            } else
            {
                bto_1.Text = "Menús";
                bto_2.Text = "Promociones";
                bto_3.Text = "Stock";
                f1.load_panel(new Pedidos());
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
                f1.load_panel(new promocion());

            } else
            {
                bto_1.Text = "Menús";
                bto_2.Text = "Promociones";
                bto_3.Text = "Stock";
                f1.load_panel(new Pedidos());
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
                f1.load_panel(new promocion());

            }
            else
            {
                bto_1.Text = "Menús";
                bto_2.Text = "Pedidos";
                bto_3.Text = "Promociones";
                f1.load_panel(new Stock());
            }
        }
    }
}
