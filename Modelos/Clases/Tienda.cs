using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giovannis.Modelos.Clases
{
    internal class Tienda
    {
        private string _id_tienda;
        private string _tienda_nombre;
        private string _tienda_direccion;

        public Tienda(string id_tienda, string tienda_nombre, string tienda_direccion)
        {
            _id_tienda = id_tienda;
            _tienda_nombre = tienda_nombre;
            _tienda_direccion = tienda_direccion;
        }

        public string Id_tienda { get => _id_tienda; set => _id_tienda = value; }
        public string Tienda_nombre { get => _tienda_nombre; set => _tienda_nombre = value; }
        public string Tienda_direccion { get => _tienda_direccion; set => _tienda_direccion = value; }
    }


}
