using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giovannis.Modelos.Provedores.Gerente
{
    public partial class proveedores_gerente : UserControl
    {
        public proveedores_gerente()
        {
            InitializeComponent();
        }

        private void proveedores_gerente_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void populateItems()
        {
            proveedor_gerente[] p = new proveedor_gerente[30]; // CAMBIAR POR EL NUMEOR DE NOTIFICACIONES DEL USUARIO

            for (int i = 0; i < p.Length; i++)
            {
                p[i] = new proveedor_gerente();
                p[i].Nombre = "Sebastián";

                if (flw_proveedores.Controls.Count < 0)
                {

                    flw_proveedores.Controls.Clear();

                }
                else
                {

                    flw_proveedores.Controls.Add(p[i]);

                }

            }


        }
    }
}
