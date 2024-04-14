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
    public partial class EliminarEmpleado : Form
    {
        private DataTable resultTable;
        public EliminarEmpleado()
        {
            InitializeComponent();
            try
            {
                ConectDB oracleDBManager = new ConectDB();
                string query = "SELECT id_empleado as Id, nombre as Nombre FROM restaurant_empleados";
                // Asignar el resultado de la consulta al DataTable resultTable
                resultTable = oracleDBManager.ExecuteQueryUsers(query);

                // Llenar el ComboBox con los nombres de usuario
                selectEmpleados.Items.Clear();
                foreach (DataRow row in resultTable.Rows)
                {
                    string clienteString = $"{row["Nombre"]}";
                    selectEmpleados.Items.Add(clienteString);
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void menuprincipal_Click(object sender, EventArgs e)
        {
            MenuEmpleados menu = new MenuEmpleados();
            menu.Show();
            this.Hide();
        }

        private void actualizaruser_Click(object sender, EventArgs e)
        {
            if (selectEmpleados.SelectedItem != null)
            {
                string empleadoString = selectEmpleados.SelectedItem.ToString();
                try
                {
                    ConectDB oracleDBManager = new ConectDB();

                    string sqlUpdate = $"delete from restaurant_empleados where nombre = '{empleadoString}'";

                    oracleDBManager.ExecuteNonQuery(sqlUpdate);

                    MessageBox.Show("Empleado eliminado correctamente.");
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
                MessageBox.Show("Por favor selecciona un empleado.");
            }
        }
    }
}
