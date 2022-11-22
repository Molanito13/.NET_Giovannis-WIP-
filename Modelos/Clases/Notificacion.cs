using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giovannis.Modelos.Clases
{
    internal class Notificacion
    {
        private string _id_emisor;
        private string _id_remitente;
        private string _mensaje;

        public Notificacion(string id_emisor, string id_remitente, string mensaje)
        {
            _id_emisor = id_emisor;
            _id_remitente = id_remitente;
            _mensaje = mensaje;
        }

        public string Id_emisor { get => _id_emisor; set => _id_emisor = value; }
        public string Id_remitente { get => _id_remitente; set => _id_remitente = value; }
        public string Mensaje { get => _mensaje; set => _mensaje = value; }
    }


}
