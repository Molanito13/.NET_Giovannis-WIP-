using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giovannis.Modelos.Menu.Gerente
{
    public partial class Menus_gerente : UserControl
    {
        public Menus_gerente()
        {
            InitializeComponent();
        }

        private void populateItems()
        {
            Menu_panel_gerente[] menus = new Menu_panel_gerente[10]; // CAMBIAR POR EL NUMEOR DE NOTIFICACIONES DEL USUARIO

            for (int i = 0; i < menus.Length; i++)
            {
                menus[i] = new Menu_panel_gerente();
                menus[i].Titulo = "Jamón y queso";
                menus[i].Ingrediente1 = "Jamón York";
                menus[i].Ingrediente2 = "Tomate";
                menus[i].Ingrediente3 = "Queso";
                menus[i].Descripcion = "Muy rica crack";
                menus[i].Precio = "17.99€";

                if (flw_menus.Controls.Count < 0)
                {

                    flw_menus.Controls.Clear();

                }
                else
                {

                    flw_menus.Controls.Add(menus[i]);

                }

            }


        }

        private void Menus_gerente_Load(object sender, EventArgs e)
        {
            populateItems();
        }
    }
}
