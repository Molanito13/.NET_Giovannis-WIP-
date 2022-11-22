using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giovannis.Modelos.Horarios.Gerente
{
    public partial class Empleados : UserControl
    {
        private string _nombre;
        private string _id_trabajador;
        private DateTime _llegada;
        private DateTime _salida;
        private double _totalTrabajado; //es la unidad para la resta de fechas

        public Empleados()
        {
            InitializeComponent();
            this._nombre = "";
            this._id_trabajador = "";
            this._llegada = DateTime.Parse("04/05/2022 8:34:01"); //La fecha la sacamos de la bb.dd
            this._salida = DateTime.Now; //Pongo la fecha de ahora como ejemplo
            this._totalTrabajado = 0;
        }
        public string Nombre 
        { 
            get { return this._nombre; } 
            set { this._nombre = value; lbl_nombreEmpleado.Text = value; } 
        }

        public string ID
        {
            get { return this._id_trabajador; }
            set { this._id_trabajador = value; lbl_Nombre.Text = value; }
        }

        public DateTime Llegada
        {
            get { return this._llegada; }
            set { this._llegada = value; lbl_llegada.Text = value.ToString(); }
        }
        public DateTime Salida
        {
            get { return this._salida; }
            set { this._salida = value; lbl_salida.Text = value.ToString(); }
        }
        public Double TotalTrabajado
        {
            get { return this._totalTrabajado; }
            set { this._totalTrabajado = value; lbl_total.Text = value.ToString(); }
        }

        private void Empleado_Load(object sender, EventArgs e)
        {

        }

        private void lbl_nEmpleado_Click(object sender, EventArgs e)
        {

        }
    }
}
