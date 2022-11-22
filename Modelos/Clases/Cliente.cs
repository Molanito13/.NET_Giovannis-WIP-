using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giovannis.Modelos.Clases
{
    internal class Cliente
    {

        private string _id_cliente;
        private string _cliente_nombre;
        private string _cliente_apellido;
        private DateTime _fecha_nac;
        private string _email;

        public Cliente(string id_cliente, string cliente_nombre, string cliente_apellido, DateTime fecha_nac, string email)
        {
            _id_cliente = id_cliente;
            _cliente_nombre = cliente_nombre;
            _cliente_apellido = cliente_apellido;
            _fecha_nac = fecha_nac;
            _email = email;
        }

        public string Id_cliente { get => _id_cliente; set => _id_cliente = value; }
        public string Cliente_nombre { get => _cliente_nombre; set => _cliente_nombre = value; }
        public string Cliente_apellido { get => _cliente_apellido; set => _cliente_apellido = value; }
        public DateTime Fecha_nac { get => _fecha_nac; set => _fecha_nac = value; }
        public string Email { get => _email; set => _email = value; }
    }
}
