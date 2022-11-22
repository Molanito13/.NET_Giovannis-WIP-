using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giovannis.Modelos.Pedidos
{
    public partial class Pedidos_panel : UserControl
    {
        private string _idPedido;
        private string _fechaPedido;
        private string _tienda;
        private string _empleado;
        private string _cliente;
        private string _nomMenu;
        private string _precio;

        public Pedidos_panel()
        {
            InitializeComponent();
            _idPedido = "";
            _fechaPedido = "";
            _tienda = "";
            _empleado = "";
            _cliente = "";
            _nomMenu = "";
            _precio = "";

        }

        public string IdPedido
        {
            get { return _idPedido; }
            set { _idPedido = value; lbl_id_pedido.Text = value; }
        }

        public string FechaPedido
        {
            get { return _fechaPedido; }
            set { _fechaPedido = value; lbl_fecha.Text = value; }
        }
        public string Tienda
        {
            get { return _tienda; }
            set { _tienda = value; lbl_tienda.Text = value; }
        }
        public string Empleado
        {
            get { return _empleado; }
            set { _empleado = value; lbl_empleado.Text = value; }
        }
        public string Cliente
        {
            get { return _cliente; }
            set { _cliente = value; lbl_cliente.Text = value; }
        }
        public string NomMenu
        {
            get { return _nomMenu; }
            set { _nomMenu = value; lbl_nombre_menu.Text = value; }
        }
        public string Precio
        {
            get { return _precio; }
            set { _precio = value; lbl_precio.Text = value; }
        }

        private void Pedidos_panel_Load(object sender, EventArgs e)
        {

        }
    }
}
