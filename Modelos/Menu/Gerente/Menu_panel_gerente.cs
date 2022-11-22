using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giovannis.Modelos.Menu.Gerente
{
    public partial class Menu_panel_gerente : UserControl
    {

        private string _titulo;
        private string _ingrediente1;
        private string _ingrediente2;
        private string _ingrediente3;
        private string _descripcion;
        private string _precio;

        public Menu_panel_gerente()
        {
            InitializeComponent();
            _titulo = "";
            _ingrediente1 = "";
            _ingrediente2 = "";
            _ingrediente3 = "";
            _descripcion = "";
            _precio = "";
        }

        public string Titulo
        {

            get
            {

                return _titulo;

            }

            set
            {

                _titulo = value; lbl_titulo.Text = value;

            }

        }
        public string Ingrediente1
        {

            get
            {

                return _ingrediente1;

            }

            set
            {

                _ingrediente1 = value; lbl_ingrediente1.Text = value;

            }

        }

        public string Ingrediente2
        {

            get
            {

                return _ingrediente2;

            }

            set
            {

                _ingrediente2 = value; lbl_ingrediente2.Text = value;

            }

        }

        public string Ingrediente3
        {

            get
            {

                return _ingrediente3;

            }

            set
            {

                _ingrediente3 = value; lbl_ingrediente3.Text = value;

            }

        }

        public string Descripcion
        {

            get
            {

                return _descripcion;

            }

            set
            {

                _descripcion = value; lbl_descripcion.Text = value;

            }

        }

        public string Precio
        {

            get
            {

                return _precio;

            }

            set
            {

                _precio = value; btt_precio.Text = value;

            }

        }
    }
}
