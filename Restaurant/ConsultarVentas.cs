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
    public partial class ConsultarVentas : Form
    {
        private DataTable data;
        public ConsultarVentas()
        {
            InitializeComponent();
        }

        private void menuprincipal_Click(object sender, EventArgs e)
        {
            MenuVentas menu = new MenuVentas();
            menu.Show();
            this.Hide();
        }

        private void consultarvent_Click(object sender, EventArgs e)
        {
            try
            {
                ConectDB oracleDBManager = new ConectDB();

                string query = $"select * from restaurant_ventas";

                data = oracleDBManager.ExecuteQueryUsers(query);

                ventas.DataSource = data;
                idventa.Text = "";

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void consultarventaesp_Click(object sender, EventArgs e)
        {
            try
            {
                if (idventa.Text == "")
                {
                    MessageBox.Show("Tienes que insertar un id");
                    return;
                }

                int idvent = Convert.ToInt32(idventa.Text);

                if (idvent > 0)
                {
                    ConectDB oracleDBManager = new ConectDB();

                    string query = $"select * from restaurant_ventas rv where rv.id_venta = '{idvent}'";

                    data = oracleDBManager.ExecuteQueryUsers(query);

                    ventas.DataSource = data;
                    idventa.Text = "";
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

                string query = $"SELECT sum(rv.subtotal) from restaurant_ventas rv";

                object result = oracleDBManager.ExecuteScalar(query);

                if (result != null && result != DBNull.Value)
                {
                    decimal suma = Convert.ToDecimal(result);
                    labelSuma.Text = "Total Ventas: " + suma.ToString();
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

                string query = $"SELECT avg(rv.subtotal) from restaurant_ventas rv";

                object result = oracleDBManager.ExecuteScalar(query);

                if (result != null && result != DBNull.Value)
                {
                    decimal suma = Convert.ToDecimal(result);
                    labelPromedio.Text = "Promedio Ventas: " + suma.ToString();
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

                string query = $"SELECT min(rv.subtotal) from restaurant_ventas rv";

                object result = oracleDBManager.ExecuteScalar(query);

                if (result != null && result != DBNull.Value)
                {
                    decimal suma = Convert.ToDecimal(result);
                    labelMinimo.Text = "Venta Mínima: " + suma.ToString();
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

                string query = $"SELECT max(rv.subtotal) from restaurant_ventas rv";

                object result = oracleDBManager.ExecuteScalar(query);

                if (result != null && result != DBNull.Value)
                {
                    decimal suma = Convert.ToDecimal(result);
                    labelMaximo.Text = "Venta Máxima: " + suma.ToString();
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

                string query = $"select * from restaurant_ventas";

                data = oracleDBManager.ExecuteQueryUsers(query);

                ConectDB.ExportDataTableToPdf(data, @"Ventas.pdf", "Lista de Ventas");

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }
    }
}
