using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giovannis.Modelos.Clases
{
    internal class Refresco
    {
        private string _id_refresco;
        private string _refresco_nombre;

        public Refresco(string id_refresco, string refresco_nombre)
        {
            _id_refresco = id_refresco;
            _refresco_nombre = refresco_nombre;
        }

        public string Id_refresco { get => _id_refresco; set => _id_refresco = value; }
        public string Refresco_nombre { get => _refresco_nombre; set => _refresco_nombre = value; }
    }


}
