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
    public partial class EditarEmpleados : Form
    {
        private DataTable resultTable;
        public EditarEmpleados()
        {
            InitializeComponent();
            try
            {
                ConectDB oracleDBManager = new ConectDB();
                string query = "SELECT id_empleado as Id, nombre as Nombre, apellido as Apellido, puesto as Puesto, salario as Salario FROM restaurant_empleados";

                resultTable = oracleDBManager.ExecuteQueryUsers(query);

                selectEmpleados.Items.Clear();
                foreach (DataRow row in resultTable.Rows)
                {
                    string clienteString = $"{row["Id"]} - {row["Nombre"]} {row["Apellido"]}";
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
            this.Hide();
            menu.Show();
        }

        private void selectEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectEmpleados.SelectedItem != null)
            {
                string empleadoString = selectEmpleados.SelectedItem.ToString();

                string[] empleadoData = empleadoString.Split('-');

                string nombreempleado = empleadoData[0].Trim();

                try
                {
                    DataRow[] selectedRows = resultTable.Select($"Id = '{nombreempleado}'");

                    if (selectedRows.Length > 0)
                    {

                        nombreEmpleados.Text = selectedRows[0]["Nombre"].ToString();

                        apeEmpleados.Text = selectedRows[0]["Apellido"].ToString();

                        puestoEmpleados.Text = selectedRows[0]["Puesto"].ToString();

                        salarioEmpleados.Text = selectedRows[0]["Salario"].ToString();
                    }
                    else
                    {
                        MessageBox.Show($"No se encontraron datos para el empleado {empleadoData[1].Trim()}.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private void actualizarCliente_Click(object sender, EventArgs e)
        {
            if (selectEmpleados.SelectedItem != null)
            {
                string empleadoString = selectEmpleados.SelectedItem.ToString(), nombre = nombreEmpleados.Text,
                    apellido = apeEmpleados.Text, puesto = puestoEmpleados.Text, salario = selectEmpleados.Text;

                string[] empleadoData = empleadoString.Split('-');

                if (nombre == "" || apellido == "" || puesto == "" || salario == "")
                {
                    MessageBox.Show("Debes de llenar todos los datos del formulario.");
                }
                try
                {

                    ConectDB oracleDBManager = new ConectDB();

                    string sqlUpdate = $"update restaurant_empleados set nombre= '{nombre}',apellido='{apellido}',puesto='{puesto}',salario={salario} where id_empleado = '{empleadoData[0].Trim()}'";

                    oracleDBManager.ExecuteNonQuery(sqlUpdate);

                    MessageBox.Show("Empleado actualizado correctamente.");
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
