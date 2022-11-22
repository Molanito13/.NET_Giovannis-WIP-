using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giovannis.Modelos.Clases
{
    internal class Entrante
    {

        private string _id_entrante;
        private string _entrante_ingrediente;
        private string _entrante_salsa;
        private string _entrante_nombre;

        public Entrante(string id_entrante, string entrante_ingrediente, string entrante_salsa, string entrante_nombre)
        {
            _id_entrante = id_entrante;
            _entrante_ingrediente = entrante_ingrediente;
            _entrante_salsa = entrante_salsa;
            _entrante_nombre = entrante_nombre;
        }

        public string Id_entrante { get => _id_entrante; set => _id_entrante = value; }
        public string Entrante_ingrediente { get => _entrante_ingrediente; set => _entrante_ingrediente = value; }
        public string Entrante_salsa { get => _entrante_salsa; set => _entrante_salsa = value; }
        public string Entrante_nombre { get => _entrante_nombre; set => _entrante_nombre = value; }
    }
}
