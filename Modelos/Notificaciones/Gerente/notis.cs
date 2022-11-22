using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giovannis.Modelos.Notificaciones
{
    public partial class flw_notis : UserControl
    {

        private string _emisor;
        private string _cuerpo;

        public flw_notis()
        {
            InitializeComponent();
            this._emisor = "";
            this._cuerpo = "";
        }

        public string Emisor
        {

            get
            {

                return _emisor;

            }

            set
            {

                _emisor = value; txt_nombre.Texts = value;

            }

        }

        public string Cuerpo
        {

            get
            {

                return _cuerpo;

            }

            set
            {

                _cuerpo = value; txt_cuerpo.Texts = value;

            }

        }
    }
}
