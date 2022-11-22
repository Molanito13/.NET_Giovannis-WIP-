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

namespace Giovannis.Modelos.Promociones.Gerente
{
    public partial class promociones_gerente : UserControl
    {
        public promociones_gerente()
        {
            InitializeComponent();
        }

        private void populateItems()
        {
            // CAMBIAR POR EL NUMEOR DE NOTIFICACIONES DEL USUARIO
            promo_gerente[] codigos = new promo_gerente[30];

            for (int i = 0; i < codigos.Length; i++)
            {
                codigos[i] = new promo_gerente();
                codigos[i].Codigo = "NANOSEXO";
                codigos[i].Estado = "Activo";
                codigos[i].Porcentaje = "33%";

                if (flw_promociones.Controls.Count < 0)
                {

                    flw_promociones.Controls.Clear();

                }
                else
                {
                    if (codigos[i].Estado == "Activo")
                    {
                        codigos[i].activar();
                    }

                    

                    flw_promociones.Controls.Add(codigos[i]);

                }

            }


        }

        //private void promociones_gerente_Load(object sender, EventArgs e)
        //{
        //    populateItems();
        //}

        private void promociones_gerente_Load_1(object sender, EventArgs e)
        {
            populateItems();
        }
    }
}
