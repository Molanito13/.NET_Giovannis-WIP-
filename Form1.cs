using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Giovannis.Modelos;
using Giovannis.Modelos.Pedidos;
using Giovannis.Modelos.Menu.Gerente;
using Giovannis.Modelos.Menu;
using Giovannis.Modelos.Botoneras.Gerente;
namespace Giovannis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1 f1 = (Form1)this.FindForm();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            panel_login_inicial.Controls.Add(new Login());
            //panel1.Controls.Add(new Menus());
            //pnl_botoneras.Controls.Add(new botonera());
        }

        public void load_panel(UserControl u) {

            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(u);
        
        }

        public void gerente_cambiar_botonera(UserControl u) {

            this.pnl_botoneras.Controls.Clear();
            this.pnl_botoneras.Controls.Add(u);
             
        }

        public void iniciar_sesion(int tipo) {

            switch (tipo) {

                case 1:
                    this.panel1.Controls.Clear();
                    this.panel1.Controls.Add(new Menus());
                    this.pnl_botoneras.Controls.Clear();
                    this.pnl_botoneras.Controls.Add(new botonera());
                    
                    break;

                case 2:
                    this.panel1.Controls.Clear();
                    this.panel1.Controls.Add(new Menus_gerente());
                    this.pnl_botoneras.Controls.Clear();
                    this.pnl_botoneras.Controls.Add(new botonera_gerente());
                    
                    break;
                case 3:
                    this.panel1.Controls.Clear();
                    this.panel1.Controls.Clear();
                    this.panel1.Controls.Add(new Menus_gerente());
                    this.pnl_botoneras.Controls.Clear();
                    this.pnl_botoneras.Controls.Add(new botonera_gerente());
                    break;

            }
            
        }

        private void panel_login_inicial_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
