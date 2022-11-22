using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giovannis.Modelos.Clases
{
    internal class Menu
    {

        private string _id_menu;
        private double _menu_precio;
        private string _id_pizza;
        private string _id_entrante;
        private string _id_refresco;

        public Menu(string id_menu, double menu_precio, string id_pizza, string id_entrante, string id_refresco)
        {
            _id_menu = id_menu;
            _menu_precio = menu_precio;
            _id_pizza = id_pizza;
            _id_entrante = id_entrante;
            _id_refresco = id_refresco;
        }

        public string Id_menu { get => _id_menu; set => _id_menu = value; }
        public double Menu_precio { get => _menu_precio; set => _menu_precio = value; }
        public string Id_pizza { get => _id_pizza; set => _id_pizza = value; }
        public string Id_entrante { get => _id_entrante; set => _id_entrante = value; }
        public string Id_refresco { get => _id_refresco; set => _id_refresco = value; }
    }
}
