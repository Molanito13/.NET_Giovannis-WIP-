using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giovannis.Modelos.Clases
{
    internal class Empleado
    {

        private string _id_empleado;
        private string _empleado_nombre;
        private string _empleado_apellidos;
        private string _empleado_dni;
        private DateTime _empleado_fecha_nac;
        private string _id_tienda;
        private char _empleado_tipo;
        private double _empleado_salario;
        private int _empleado_bloqueado;

        public Empleado(string id_empleado, string empleado_nombre, string empleado_apellidos, string empleado_dni, DateTime empleado_fecha_nac
                        ,string id_tienda, char empleado_tipo, double empleado_salario, int empleado_bloqueado)
        {
            _id_empleado = id_empleado;
            _empleado_nombre = empleado_nombre;
            _empleado_apellidos = empleado_apellidos;
            _empleado_dni = empleado_dni;
            this._empleado_fecha_nac = empleado_fecha_nac;
            _id_tienda = id_tienda;
            _empleado_tipo = empleado_tipo;
            _empleado_salario = empleado_salario;
            _empleado_bloqueado = empleado_bloqueado;
        }

        public string Id_empleado { get => _id_empleado; set => _id_empleado = value; }
        public string Empleado_nombre { get => _empleado_nombre; set => _empleado_nombre = value; }
        public string Empleado_apellidos { get => _empleado_apellidos; set => _empleado_apellidos = value; }
        public string Empleado_dni { get => _empleado_dni; set => _empleado_dni = value; }
        public DateTime Empleado_fecha_nac { get => _empleado_fecha_nac; set => _empleado_fecha_nac = value; }
        public string Id_tienda { get => _id_tienda; set => _id_tienda = value; }
        public char Empleado_tipo { get => _empleado_tipo; set => _empleado_tipo = value; }
        public double Empleado_salario { get => _empleado_salario; set => _empleado_salario = value; }
        public int Empleado_bloqueado { get => _empleado_bloqueado; set => _empleado_bloqueado = value; }
    }
}
