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
    public partial class EliminarProveedor : Form
    {
        private DataTable resultTable;
        public EliminarProveedor()
        {
            InitializeComponent();
            try
            {
                ConectDB oracleDBManager = new ConectDB();
                string query = "SELECT id_proveedor as Id, nombre as Nombre FROM restaurant_proveedores";
                // Asignar el resultado de la consulta al DataTable resultTable
                resultTable = oracleDBManager.ExecuteQueryUsers(query);

                // Llenar el ComboBox con los nombres de usuario
                selectProveddores.Items.Clear();
                foreach (DataRow row in resultTable.Rows)
                {
                    string clienteString = $"{row["Nombre"]}";
                    selectProveddores.Items.Add(clienteString);
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void menuprincipal_Click(object sender, EventArgs e)
        {
            MenuProveedores menu = new MenuProveedores();
            menu.Show();
            this.Hide();
        }

        private void actualizaruser_Click(object sender, EventArgs e)
        {
            if (selectProveddores.SelectedItem != null)
            {
                string proveedorString = selectProveddores.SelectedItem.ToString();
                try
                {
                    ConectDB oracleDBManager = new ConectDB();

                    string sqlUpdate = $"delete from restaurant_proveedores where nombre = '{proveedorString}'";

                    oracleDBManager.ExecuteNonQuery(sqlUpdate);

                    MessageBox.Show("Proveedor eliminado correctamente.");
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
                MessageBox.Show("Por favor selecciona un Proveedor.");
            }
        }
    }
}
