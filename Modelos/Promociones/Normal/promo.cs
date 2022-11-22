using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giovannis.Modelos.Promociones
{
    public partial class promo : UserControl
    {

        private string _codigo;
        private string _estado;
        private string _porcentaje;

        public promo()
        {
            InitializeComponent();
            this._codigo = "";
            this._estado = "";
            this._porcentaje = "";
        }

        public string Codigo
        {

            get
            {

                return _codigo;

            }

            set
            {

                _codigo = value; lbl_codigo.Text = value;

            }

        }

        public string Estado
        {

            get
            {

                return _estado;

            }

            set
            {

                _estado = value; lbl_estado.Text = value;

            }

        }

        public string Porcentaje
        {

            get
            {

                return _porcentaje;

            }

            set
            {

                _porcentaje = value; lbl_porcentaje.Text = value;

            }

        }
    }
}
