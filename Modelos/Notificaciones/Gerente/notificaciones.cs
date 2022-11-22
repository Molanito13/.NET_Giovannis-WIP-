using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Giovannis.Modelos.Notificaciones;

namespace Giovannis.Modelos
{
    public partial class notificaciones : UserControl
    {
        public notificaciones()
        {
            InitializeComponent();
        }

        private void populateItems()
        {
            flw_notis[] notificaciones = new flw_notis[10]; // CAMBIAR POR EL NUMEOR DE NOTIFICACIONES DEL USUARIO

            for (int i = 0; i < notificaciones.Length; i++)
            {
                notificaciones[i] = new flw_notis();
                notificaciones[i].Emisor = "Isabel Diaz Ayuso";
                notificaciones[i].Cuerpo = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\r\n\r\n";

                if (flw_notisP.Controls.Count < 0)
                {

                    flw_notisP.Controls.Clear();

                }
                else
                {

                    flw_notisP.Controls.Add(notificaciones[i]);

                }

            }
        
        
        }

        private void populateNombres()
        {
            string[] nombres = new string[10]; // CAMBIAR POR EL NUMEOR DE NOTIFICACIONES DEL USUARIO

            for (int i = 0; i < nombres.Length; i++)
            {
                nombres[i] = "Nombre #" + i.ToString();
                lst_nombres.Items.Add(nombres[i]);

            }
        }

        private void notificaciones_Load(object sender, EventArgs e)
        {
            populateItems();
            populateNombres();
        }
    }
}
