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
    public partial class Horarios : UserControl
    {
        public Horarios()
        {
            InitializeComponent();
        }

        private void populateItems()
        {
            Empleados[] empleado = new Empleados[30];

            for(int i = 0; i < empleado.Length; i++)
            {
                empleado[i] = new Empleados();
                empleado[i].Nombre = "sdfghjkl";
                empleado[i].ID = "00023";
                empleado[i].Llegada = DateTime.Parse("15/11/2022 8:34:01");
                empleado[i].Salida = DateTime.Now;
                empleado[i].TotalTrabajado = Math.Floor((empleado[i].Salida - empleado[i].Llegada).TotalHours);
                if(flw_Horarios.Controls.Count < 0)
                {
                    flw_Horarios.Controls.Clear();
                }
                else
                {
                    flw_Horarios.Controls.Add(empleado[i]);
                }
            }
        }

        private void Horarios_Load(object sender, EventArgs e)
        {
            populateItems();
        }
    }
}
