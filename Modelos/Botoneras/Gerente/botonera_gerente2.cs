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
using Giovannis.Modelos.Horarios;
using Giovannis.Modelos.Horarios.Gerente;

namespace Giovannis.Modelos.Botoneras.Gerente
{
    public partial class botonera_gerente2 : UserControl
    {
        public botonera_gerente2()
        {
            InitializeComponent();
        }

        private void bto_1_Click(object sender, EventArgs e)
        {
            string variable = bto_1.Text;
            Form1 f1 = (Form1)this.FindForm();

            if (variable == "Horarios")
            {
                bto_1.Text = "Notificaciones";
                f1.load_panel(new Horarios.Gerente.Horarios());

            }
            else
            {
                bto_1.Text = "Horarios";
                f1.load_panel(new notificaciones());
            }
        }

        private void img_cambio_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)this.FindForm();
            f1.gerente_cambiar_botonera(new botonera_gerente());
        }
    }
}
