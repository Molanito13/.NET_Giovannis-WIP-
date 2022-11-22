using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giovannis.Modelos.Clases
{
    internal class Stock
    {
        private string _id_ingrediente;
        private string _stock_nombre;
        private string _stock_cantidad;
        private string _id_proveedor;

        public Stock(string id_ingrediente, string stock_nombre, string stock_cantidad, string id_proveedor)
        {
            _id_ingrediente = id_ingrediente;
            _stock_nombre = stock_nombre;
            _stock_cantidad = stock_cantidad;
            _id_proveedor = id_proveedor;
        }

        public string Id_ingrediente { get => _id_ingrediente; set => _id_ingrediente = value; }
        public string Stock_nombre { get => _stock_nombre; set => _stock_nombre = value; }
        public string Stock_cantidad { get => _stock_cantidad; set => _stock_cantidad = value; }
        public string Id_proveedor { get => _id_proveedor; set => _id_proveedor = value; }
    }


}
