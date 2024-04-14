using Oracle.ManagedDataAccess.Client;
using PersonaGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Restaurant
{
    public partial class ConsultarClientes : Form
    {
        private DataTable data;
        public ConsultarClientes()
        {
            InitializeComponent();
        }

        private void consultar_clientes_Click(object sender, EventArgs e)
        {
            try
            {
                ConectDB oracleDBManager = new ConectDB();

                string query = $"select rc.id_cliente as \"No. de Cliente\", rc.nombre, rc.apellido, rc.direccion, rc.telefono, rc.email as \"Correo Electrónico\" from restaurant_clientes rc";

                data = oracleDBManager.ExecuteQueryUsers(query);

                clientes.DataSource = data;
                idcliente.Text = "";

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void consultar_clientes_esp_Click(object sender, EventArgs e)
        {
            try
            {
                if (idcliente.Text == "")
                {
                    MessageBox.Show("Tienes que insertar un id");
                    return;
                }

                int idemp = Convert.ToInt32(idcliente.Text);

                if (idemp > 0)
                {
                    ConectDB oracleDBManager = new ConectDB();

                    string query = $"select rc.id_cliente as \"No. de Cliente\", rc.nombre, rc.apellido, rc.direccion, rc.telefono, rc.email as \"Correo Electrónico\" from restaurant_clientes rc where rc.id_cliente = '{idemp}'";

                    data = oracleDBManager.ExecuteQueryUsers(query);

                    clientes.DataSource = data;
                    idcliente.Text = "";
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
            MenuClientes menu = new MenuClientes();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConectDB oracleDBManager = new ConectDB();

                string query = $"SELECT count(*) from restaurant_clientes rc";

                object result = oracleDBManager.ExecuteScalar(query);

                if (result != null && result != DBNull.Value)
                {
                    decimal suma = Convert.ToDecimal(result);
                    labelSuma.Text = "Total Clientes: " + suma.ToString();
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

                string query = $"SELECT avg(LENGTH(re.email)) from restaurant_clientes re";

                object result = oracleDBManager.ExecuteScalar(query);

                if (result != null && result != DBNull.Value)
                {
                    decimal suma = Convert.ToDecimal(result);
                    labelPromedio.Text = "Promedio de Letras Email: " + suma.ToString();
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

                string query = $"SELECT min(LENGTH(re.email)) from restaurant_clientes re";

                object result = oracleDBManager.ExecuteScalar(query);

                if (result != null && result != DBNull.Value)
                {
                    decimal suma = Convert.ToDecimal(result);
                    labelMinimo.Text = "Mínimo Letras Email: " + suma.ToString();
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

                string query = $"SELECT max(LENGTH(re.email)) from restaurant_clientes re";

                object result = oracleDBManager.ExecuteScalar(query);

                if (result != null && result != DBNull.Value)
                {
                    decimal suma = Convert.ToDecimal(result);
                    labelMaximo.Text = "Máximo Letras Email: " + suma.ToString();
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

                string query = $"select rc.id_cliente as \"No. de Cliente\", rc.nombre, rc.apellido, rc.direccion, rc.telefono, rc.email as \"Correo Electrónico\" from restaurant_clientes rc";

                data = oracleDBManager.ExecuteQueryUsers(query);

                ConectDB.ExportDataTableToPdf(data, @"Clientes.pdf", "Lista de Clientes");

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }
    }
}
