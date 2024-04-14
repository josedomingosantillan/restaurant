using Oracle.ManagedDataAccess.Client;
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
    public partial class EliminarClientes : Form
    {
        private DataTable resultTable;
        public EliminarClientes()
        {
            InitializeComponent();
            try
            {
                ConectDB oracleDBManager = new ConectDB();
                string query = "SELECT id_cliente as Id, nombre as Nombre FROM restaurant_clientes";
                // Asignar el resultado de la consulta al DataTable resultTable
                resultTable = oracleDBManager.ExecuteQueryUsers(query);

                // Llenar el ComboBox con los nombres de usuario
                selectUsuarios.Items.Clear();
                foreach (DataRow row in resultTable.Rows)
                {
                    string clienteString = $"{row["Nombre"]}";
                    selectUsuarios.Items.Add(clienteString);
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void menuprincipal_Click(object sender, EventArgs e)
        {
            MenuClientes menu = new MenuClientes();
            menu.Show();
            this.Hide();
        }

        private void actualizaruser_Click(object sender, EventArgs e)
        {
            if (selectUsuarios.SelectedItem != null)
            {
                string usuarioString = selectUsuarios.SelectedItem.ToString();
                try
                {
                    ConectDB oracleDBManager = new ConectDB();

                    string sqlUpdate = $"delete from restaurant_clientes where nombre = '{usuarioString}'";

                    oracleDBManager.ExecuteNonQuery(sqlUpdate);

                    MessageBox.Show("Cliente eliminado correctamente.");
                    oracleDBManager.Menu();
                    this.Hide();
                }
                catch (OracleException ex)
                {
                    Console.WriteLine($"Error de Oracle: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona un cliente.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
