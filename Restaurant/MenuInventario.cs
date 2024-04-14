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
    public partial class MenuInventario : Form
    {
        public MenuInventario()
        {
            InitializeComponent();
        }

        private void menuprincipal_Click(object sender, EventArgs e)
        {
            ConectDB conn = new ConectDB();
            conn.Menu();
            this.Hide();
        }

        private void consultar_inv_Click(object sender, EventArgs e)
        {
            ConsultarInventario consultar = new ConsultarInventario();
            consultar.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EliminarInventario eliminar = new EliminarInventario();
            eliminar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditarInventario editar = new EditarInventario();
            editar.Show();
            this.Hide();
        }
    }
}
