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
    public partial class proveedor : UserControl
    {

        private string _nombre;


        public proveedor()
        {
            InitializeComponent();
            this._nombre = "";
        }

        public string Nombre
        {

            get
            {

                return _nombre;

            }

            set
            {

                _nombre = value; lbl_nombre.Text = value;

            }

        }
    }
}
