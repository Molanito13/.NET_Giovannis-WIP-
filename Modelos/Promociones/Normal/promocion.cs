using Giovannis.Modelos.Notificaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Giovannis.Modelos.Promociones;

namespace Giovannis.Modelos.Promociones
{
    public partial class promocion : UserControl
    {
        public promocion()
        {
            InitializeComponent();
        }

        private void populateItems()
        {
            promo[] codigos = new promo[30]; // CAMBIAR POR EL NUMEOR DE NOTIFICACIONES DEL USUARIO

            for (int i = 0; i < codigos.Length; i++)
            {
                codigos[i] = new promo();
                codigos[i].Codigo = "NANOSEXO";
                codigos[i].Estado = "Activo";
                codigos[i].Porcentaje = "33%";

                if (flw_promociones.Controls.Count < 0)
                {

                    flw_promociones.Controls.Clear();

                }
                else
                {

                    flw_promociones.Controls.Add(codigos[i]);

                }

            }


        }

        private void promocion_Load(object sender, EventArgs e)
        {
            populateItems();
        }
    }
}
