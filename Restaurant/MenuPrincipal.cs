using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restaurant
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void empleados_Click(object sender, EventArgs e)
        {
            MenuEmpleados menu = new MenuEmpleados();
            this.Hide();
            menu.Show();
        }

        private void clientes_Click(object sender, EventArgs e)
        {
            MenuClientes menu = new MenuClientes();
            this.Hide();
            menu.Show();
        }

        private void comandas_Click(object sender, EventArgs e)
        {
            MenuComandas menu = new MenuComandas();
            this.Hide();
            menu.Show();
        }

        private void ventas_Click(object sender, EventArgs e)
        {
            MenuVentas menu = new MenuVentas();
            this.Hide();
            menu.Show();
        }

        private void proveedores_Click(object sender, EventArgs e)
        {
            MenuProveedores menu = new MenuProveedores();
            this.Hide();
            menu.Show();
        }

        private void inventario_Click(object sender, EventArgs e)
        {
            MenuInventario menu = new MenuInventario();
            this.Hide();
            menu.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 login= new Form1();
            this.Hide();
            login.Show();
        }
    }
}
