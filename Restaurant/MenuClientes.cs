using PersonaGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class MenuClientes : Form
    {
        public MenuClientes()
        {
            InitializeComponent();
        }

        private void menuprincipal_Click(object sender, EventArgs e)
        {
            ConectDB conn = new ConectDB();
            conn.Menu();
            this.Hide();
        }

        private void consultar_cli_Click(object sender, EventArgs e)
        {
            ConsultarClientes cons = new ConsultarClientes();
            cons.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EliminarClientes eliminarClientes = new EliminarClientes();
            eliminarClientes.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditarClientes editar= new EditarClientes();
            editar.Show();
            this.Hide();
        }
    }
}
