using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giovannis.Modelos.Clases
{
    internal class Pizza
    {
        private string _id_pizza;
        private string _pizza_ingrediente_1;
        private string _pizza_ingrediente_2;
        private string _pizza_ingrediente_3;
        private string _pizza_nombre;

        public Pizza(string id_pizza, string pizza_ingrediente_1, string pizza_ingrediente_2, string pizza_ingrediente_3, string pizza_nombre)
        {
            _id_pizza = id_pizza;
            _pizza_ingrediente_1 = pizza_ingrediente_1;
            _pizza_ingrediente_2 = pizza_ingrediente_2;
            _pizza_ingrediente_3 = pizza_ingrediente_3;
            _pizza_nombre = pizza_nombre;
        }

        public string Id_pizza { get => _id_pizza; set => _id_pizza = value; }
        public string Pizza_ingrediente_1 { get => _pizza_ingrediente_1; set => _pizza_ingrediente_1 = value; }
        public string Pizza_ingrediente_2 { get => _pizza_ingrediente_2; set => _pizza_ingrediente_2 = value; }
        public string Pizza_ingrediente_3 { get => _pizza_ingrediente_3; set => _pizza_ingrediente_3 = value; }
        public string Pizza_nombre { get => _pizza_nombre; set => _pizza_nombre = value; }
    }


}
