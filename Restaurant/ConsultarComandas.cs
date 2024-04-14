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
    public partial class ConsultarComandas : Form
    {
        private DataTable data;
        public ConsultarComandas()
        {
            InitializeComponent();
        }

        private void menuprincipal_Click(object sender, EventArgs e)
        {
            MenuComandas menu = new MenuComandas();
            menu.Show();
            this.Hide();
        }

        private void consultarcomanda_Click(object sender, EventArgs e)
        {
            try
            {
                ConectDB oracleDBManager = new ConectDB();

                string query = $"SELECT \r\n    rc.id_comanda,\r\n    CONCAT(rcl.nombre, ' ', rcl.apellido) AS Cliente,\r\n    CONCAT(re.nombre, ' ', re.apellido) AS Empleado,\r\n    rc.fecha_comanda AS \"Fecha de Comanda\",\r\n    rc.total,\r\n    rc.estado,\r\n    rc.observaciones \r\nFROM \r\n    restaurant_comandas rc \r\nINNER JOIN \r\n    restaurant_clientes rcl ON rcl.id_cliente = rc.id_cliente \r\nINNER JOIN \r\n    restaurant_empleados re ON re.id_empleado = rc.id_empleado";

                data = oracleDBManager.ExecuteQueryUsers(query);

                comandas.DataSource = data;
                idcomanda.Text = "";

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void consultarcomandaesp_Click(object sender, EventArgs e)
        {
            try
            {
                if (idcomanda.Text == "")
                {
                    MessageBox.Show("Tienes que insertar un id");
                    return;
                }

                int idcom = Convert.ToInt32(idcomanda.Text);

                if (idcom > 0)
                {
                    ConectDB oracleDBManager = new ConectDB();

                    string query = $"SELECT \r\n    rc.id_comanda,\r\n    CONCAT(rcl.nombre, ' ', rcl.apellido) AS Cliente,\r\n    CONCAT(re.nombre, ' ', re.apellido) AS Empleado,\r\n    rc.fecha_comanda AS \"Fecha de Comanda\",\r\n    rc.total,\r\n    rc.estado,\r\n    rc.observaciones \r\nFROM \r\n    restaurant_comandas rc \r\nINNER JOIN \r\n    restaurant_clientes rcl ON rcl.id_cliente = rc.id_cliente \r\nINNER JOIN \r\n    restaurant_empleados re ON re.id_empleado = rc.id_empleado where rc.id_comanda = '{idcom}'";

                    data = oracleDBManager.ExecuteQueryUsers(query);

                    comandas.DataSource = data;
                    idcomanda.Text = "";
                }


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

                string query = $"SELECT sum(rc.total) from restaurant_comandas rc";

                object result = oracleDBManager.ExecuteScalar(query);

                if (result != null && result != DBNull.Value)
                {
                    decimal suma = Convert.ToDecimal(result);
                    labelSuma.Text = "Total Comandas: " + suma.ToString();
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

                string query = $"SELECT avg(rc.total) from restaurant_comandas rc";

                object result = oracleDBManager.ExecuteScalar(query);

                if (result != null && result != DBNull.Value)
                {
                    decimal suma = Convert.ToDecimal(result);
                    labelPromedio.Text = "Promedio Comandas: " + suma.ToString();
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

                string query = $"SELECT min(rc.total) from restaurant_comandas rc";

                object result = oracleDBManager.ExecuteScalar(query);

                if (result != null && result != DBNull.Value)
                {
                    decimal suma = Convert.ToDecimal(result);
                    labelMinimo.Text = "Comanda Mínima: " + suma.ToString();
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

                string query = $"SELECT max(rc.total) from restaurant_comandas rc";

                object result = oracleDBManager.ExecuteScalar(query);

                if (result != null && result != DBNull.Value)
                {
                    decimal suma = Convert.ToDecimal(result);
                    labelMaximo.Text = "Comanda Máxima: " + suma.ToString();
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ConectDB oracleDBManager = new ConectDB();

                string query = $"SELECT \r\n    rc.id_comanda,\r\n    CONCAT(rcl.nombre, ' ', rcl.apellido) AS Cliente,\r\n    CONCAT(re.nombre, ' ', re.apellido) AS Empleado,\r\n    rc.fecha_comanda AS \"Fecha de Comanda\",\r\n    rc.total,\r\n    rc.estado,\r\n    rc.observaciones \r\nFROM \r\n    restaurant_comandas rc \r\nINNER JOIN \r\n    restaurant_clientes rcl ON rcl.id_cliente = rc.id_cliente \r\nINNER JOIN \r\n    restaurant_empleados re ON re.id_empleado = rc.id_empleado";

                data = oracleDBManager.ExecuteQueryUsers(query);

                ConectDB.ExportDataTableToPdf(data, @"Comandas.pdf", "Lista de Comandas");

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }
    }
}
