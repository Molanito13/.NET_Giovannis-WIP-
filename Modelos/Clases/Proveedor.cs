using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giovannis.Modelos.Clases
{
    internal class Proveedor
    {
        private string _id_proveedor;
        private string _proveedor_nombre;

        public Proveedor(string id_proveedor, string proveedor_nombre)
        {
            _id_proveedor = id_proveedor;
            this._proveedor_nombre = proveedor_nombre;
        }

        public string Id_proveedor { get => _id_proveedor; set => _id_proveedor = value; }
        public string Proveedor_nombre { get => _proveedor_nombre; set => _proveedor_nombre = value; }
    }


}
