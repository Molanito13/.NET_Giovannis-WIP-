using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giovannis.Modelos.Stock.Gerente
{
    public partial class stock_gerente : UserControl
    {
        public stock_gerente()
        {
            InitializeComponent();
        }

        private void populateItems()
        {
            ingredientes_gerente[] ingrediente = new ingredientes_gerente[30];

            for (int i = 0; i < ingrediente.Length; i++)
            {
                ingrediente[i] = new ingredientes_gerente();
                ingrediente[i].Cantidad = "4";
                ingrediente[i].Ingrediente = "Queso";
                ingrediente[i].Provedor = "Garcia Vaquero";

                if (flw_stock.Controls.Count < 0)
                {

                    flw_stock.Controls.Clear();

                }
                else
                {

                    flw_stock.Controls.Add(ingrediente[i]);

                }
            }



        }

        private void stock_gerente_Load(object sender, EventArgs e)
        {
            populateItems();
        }
    }
}
