using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giovannis.Modelos.Clases
{
    internal class Pedido
    {
        private string _id_pedido;
        private string _id_menu;
        private string _id_empleado;
        private string _id_tienda;
        private string _id_cliente;
        private double _pedido_precio;
        private DateTime _pedido_fecha;

        public Pedido(string id_pedido, string id_menu, string id_empleado, string id_tienda, string id_cliente, double pedido_precio, DateTime pedido_fecha)
        {
            _id_pedido = id_pedido;
            _id_menu = id_menu;
            _id_empleado = id_empleado;
            _id_tienda = id_tienda;
            _id_cliente = id_cliente;
            _pedido_precio = pedido_precio;
            _pedido_fecha = pedido_fecha;
        }

        public string Id_pedido { get => _id_pedido; set => _id_pedido = value; }
        public string Id_menu { get => _id_menu; set => _id_menu = value; }
        public string Id_empleado { get => _id_empleado; set => _id_empleado = value; }
        public string Id_tienda { get => _id_tienda; set => _id_tienda = value; }
        public string Id_cliente { get => _id_cliente; set => _id_cliente = value; }
        public double Pedido_precio { get => _pedido_precio; set => _pedido_precio = value; }
        public DateTime Pedido_fecha { get => _pedido_fecha; set => _pedido_fecha = value; }
    }
}
