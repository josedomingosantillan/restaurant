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
    public partial class MenuEmpleados : Form
    {
        public MenuEmpleados()
        {
            InitializeComponent();
        }

        private void menuprincipal_Click(object sender, EventArgs e)
        {
            ConectDB conn = new ConectDB();
            conn.Menu();
            this.Hide();
        }

        private void consultar_emp_Click(object sender, EventArgs e)
        {
            ConsultarEmpleados cons = new ConsultarEmpleados();
            cons.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EliminarEmpleado eliminar = new EliminarEmpleado();
            eliminar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditarEmpleados editar = new EditarEmpleados();
            editar.Show();
            this.Hide();
        }
    }
}
