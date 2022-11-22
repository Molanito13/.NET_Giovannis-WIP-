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

namespace Giovannis.Modelos.Provedores
{
    public partial class proveedores : UserControl
    {
        public proveedores()
        {
            InitializeComponent();
        }

        private void proveedores_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void populateItems()
        {
            proveedor[] p = new proveedor[30]; // CAMBIAR POR EL NUMEOR DE NOTIFICACIONES DEL USUARIO

            for (int i = 0; i < p.Length; i++)
            {
                p[i] = new proveedor();
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
