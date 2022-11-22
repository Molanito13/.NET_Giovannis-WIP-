using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giovannis.Modelos.Clases
{
    internal class Fichaje
    {

        private string _id_fichaje;
        private string _id_empleado;
        private DateTime _empleado_hora_entrada;
        private DateTime _empleado_hora_salida;

        public Fichaje(string id_fichaje, string id_empleado, DateTime empleado_hora_entrada, DateTime empleado_hora_salida)
        {
            _id_fichaje = id_fichaje;
            _id_empleado = id_empleado;
            _empleado_hora_entrada = empleado_hora_entrada;
            _empleado_hora_salida = empleado_hora_salida;
        }

        public string Id_fichaje { get => _id_fichaje; set => _id_fichaje = value; }
        public string Id_empleado { get => _id_empleado; set => _id_empleado = value; }
        public DateTime Empleado_hora_entrada { get => _empleado_hora_entrada; set => _empleado_hora_entrada = value; }
        public DateTime Empleado_hora_salida { get => _empleado_hora_salida; set => _empleado_hora_salida = value; }
    }
}
