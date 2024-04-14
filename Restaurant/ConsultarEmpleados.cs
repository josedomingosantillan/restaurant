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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Restaurant
{
    public partial class ConsultarEmpleados : Form
    {
        private DataTable data;
        public ConsultarEmpleados()
        {
            InitializeComponent();
        }

        private void insertar_emp_Click(object sender, EventArgs e)
        {
            try
            {
                ConectDB oracleDBManager = new ConectDB();

                string query = $"select re.id_empleado as \"No. de Empleado\",re.nombre, re.apellido, re.puesto, re.salario, re.fecha_contrato as \"Fecha de Contratación\", rr.nombre as \"Restaurante\" from restaurant_empleados re inner join restaurant_restaurantes rr on rr.id_restaurante = re.id_restaurante";

                data = oracleDBManager.ExecuteQueryUsers(query);

                empleados.DataSource = data;
                idempleado.Text = "";

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConectDB oracleDBManager = new ConectDB();

                string query = $"select re.id_empleado as \"No. de Empleado\",re.nombre, re.apellido, re.puesto, re.salario, re.fecha_contrato as \"Fecha de Contratación\", rr.nombre as \"Restaurante\" from restaurant_empleados re inner join restaurant_restaurantes rr on rr.id_restaurante = re.id_restaurante";

                data = oracleDBManager.ExecuteQueryUsers(query);

                empleados.DataSource = data;
                idempleado.Text = "";

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (idempleado.Text == "")
                {
                    MessageBox.Show("Tienes que insertar un id");
                    return;
                }

                int idemp = Convert.ToInt32(idempleado.Text);

                if (idemp > 0)
                {
                    ConectDB oracleDBManager = new ConectDB();

                    string query = $"select re.id_empleado as \"No. de Empleado\",re.nombre, re.apellido, re.puesto, re.salario, re.fecha_contrato as \"Fecha de Contratación\", rr.nombre as \"Restaurante\" from restaurant_empleados re inner join restaurant_restaurantes rr on rr.id_restaurante = re.id_restaurante where re.id_empleado = '{idemp}'";

                    data = oracleDBManager.ExecuteQueryUsers(query);

                    empleados.DataSource = data;
                    idempleado.Text = "";
                }


            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void menuprincipal_Click(object sender, EventArgs e)
        {
            MenuEmpleados menu = new MenuEmpleados();
            menu.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ConectDB oracleDBManager = new ConectDB();

                string query = $"SELECT sum(re.salario) from restaurant_empleados re";

                object result = oracleDBManager.ExecuteScalar(query);

                if (result != null && result != DBNull.Value)
                {
                    decimal suma = Convert.ToDecimal(result);
                    labelSuma.Text = "Total Sueldos: " + suma.ToString();
                }
                else
                {

                    labelSuma.Text = "Sin Datos";
                }

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ConectDB oracleDBManager = new ConectDB();

                string query = $"SELECT avg(re.salario) from restaurant_empleados re";

                object result = oracleDBManager.ExecuteScalar(query);

                if (result != null && result != DBNull.Value)
                {
                    decimal suma = Convert.ToDecimal(result);
                    labelPromedio.Text = "Promedio Sueldos: " + suma.ToString();
                }
                else
                {

                    labelPromedio.Text = "Sin Datos";
                }

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ConectDB oracleDBManager = new ConectDB();

                string query = $"SELECT min(re.salario) from restaurant_empleados re";

                object result = oracleDBManager.ExecuteScalar(query);

                if (result != null && result != DBNull.Value)
                {
                    decimal suma = Convert.ToDecimal(result);
                    labelMinimo.Text = "Sueldo Mínimo: " + suma.ToString();
                }
                else
                {

                    labelMinimo.Text = "Sin Datos";
                }

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ConectDB oracleDBManager = new ConectDB();

                string query = $"SELECT max(re.salario) from restaurant_empleados re";

                object result = oracleDBManager.ExecuteScalar(query);

                if (result != null && result != DBNull.Value)
                {
                    decimal suma = Convert.ToDecimal(result);
                    labelMaximo.Text = "Sueldo Máximo: " + suma.ToString();
                }
                else
                {

                    labelMaximo.Text = "Sin Datos";
                }

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                ConectDB oracleDBManager = new ConectDB();

                string query = $"select re.id_empleado as \"No. de Empleado\",re.nombre, re.apellido, re.puesto, re.salario, re.fecha_contrato as \"Fecha de Contratación\", rr.nombre as \"Restaurante\" from restaurant_empleados re inner join restaurant_restaurantes rr on rr.id_restaurante = re.id_restaurante";

                data = oracleDBManager.ExecuteQueryUsers(query);

                ConectDB.ExportDataTableToPdf(data, @"Empleados.pdf", "Lista de Empleados");

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }
    }
}
