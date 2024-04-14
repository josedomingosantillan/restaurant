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
    public partial class MenuProveedores : Form
    {
        public MenuProveedores()
        {
            InitializeComponent();
        }

        private void menuprincipal_Click(object sender, EventArgs e)
        {
            ConectDB conn = new ConectDB();
            conn.Menu();
            this.Hide();
        }

        private void consultar_prov_Click(object sender, EventArgs e)
        {
            ConsultarProveedores consultarProveedores = new ConsultarProveedores();
            consultarProveedores.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EliminarProveedor eliminar = new EliminarProveedor();
            eliminar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditarProveedor editar = new EditarProveedor();
            editar.Show();
            this.Hide();
        }
    }
}
