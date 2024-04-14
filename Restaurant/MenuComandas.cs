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
    public partial class MenuComandas : Form
    {
        public MenuComandas()
        {
            InitializeComponent();
        }

        private void menuprincipal_Click(object sender, EventArgs e)
        {
            ConectDB conn = new ConectDB();
            conn.Menu();
            this.Hide();
        }

        private void consultar_com_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultarComandas consultarComandas = new ConsultarComandas();
            consultarComandas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EliminarComandas eliminar = new EliminarComandas();
            this.Hide();
            eliminar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditarComandas editar= new EditarComandas();
            editar.Show();
            this.Hide();
        }
    }
}
