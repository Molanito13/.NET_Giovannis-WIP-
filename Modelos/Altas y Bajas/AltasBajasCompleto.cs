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
using Giovannis.Modelos.Altas_y_Bajas;

namespace Giovannis.Modelos.Altas_y_Bajas
{
    public partial class AltasBajasCompleto : UserControl
    {
        public AltasBajasCompleto()
        {
            InitializeComponent();
        }

        private void AltasBajasCompleto_Load(object sender, EventArgs e)
        {
            populateItems();
        }
        private void populateItems()
        {
            flw_alt_bajas.Controls.Add(new flw_AltasBajas());

        }
    }
}
