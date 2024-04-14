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
    public partial class MenuVentas : Form
    {
        public MenuVentas()
        {
            InitializeComponent();
        }

        private void menuprincipal_Click(object sender, EventArgs e)
        {
            ConectDB conn = new ConectDB();
            conn.Menu();
            this.Hide();
        }

        private void consultar_ven_Click(object sender, EventArgs e)
        {
            ConsultarVentas con = new ConsultarVentas();
            con.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EliminarVenta eliminar = new EliminarVenta();
            eliminar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditarVenta editar = new EditarVenta();
            editar.Show();
            this.Hide();
        }
    }
}
