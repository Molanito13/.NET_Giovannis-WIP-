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
    public partial class proveedor_gerente : UserControl
    {

        private string _nombre;

        public proveedor_gerente()
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
