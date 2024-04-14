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
    public partial class ConsultarInventario : Form
    {
        private DataTable data;
        public ConsultarInventario()
        {
            InitializeComponent();
        }

        private void menuprincipal_Click(object sender, EventArgs e)
        {
            MenuInventario menu = new MenuInventario();
            menu.Show();
            this.Hide();
        }

        private void consultarinv_Click(object sender, EventArgs e)
        {
            try
            {
                ConectDB oracleDBManager = new ConectDB();

                string query = $"select ri.id_producto, ri.nombre, ri.descripcion, ri.cantidad_stock, ri.precio_unitario, rp.nombre as Proveedor from restaurant_inventario ri inner join restaurant_proveedores rp on rp.id_proveedor = ri.id_proveedor";

                data = oracleDBManager.ExecuteQueryUsers(query);

                inventario.DataSource = data;
                idproducto.Text = "";

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void consultarinvesp_Click(object sender, EventArgs e)
        {
            try
            {
                if (idproducto.Text == "")
                {
                    MessageBox.Show("Tienes que insertar un id");
                    return;
                }

                int idpro = Convert.ToInt32(idproducto.Text);

                if (idpro > 0)
                {
                    ConectDB oracleDBManager = new ConectDB();

                    string query = $"select ri.id_producto, ri.nombre, ri.descripcion, ri.cantidad_stock, ri.precio_unitario, rp.nombre as Proveedor from restaurant_inventario ri inner join restaurant_proveedores rp on rp.id_proveedor = ri.id_proveedor where ri.id_producto = '{idpro}'";

                    data = oracleDBManager.ExecuteQueryUsers(query);

                    inventario.DataSource = data;
                    idproducto.Text = "";
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

                string query = $"SELECT sum(ri.cantidad_stock) from restaurant_inventario ri";

                object result = oracleDBManager.ExecuteScalar(query);

                if (result != null && result != DBNull.Value)
                {
                    decimal suma = Convert.ToDecimal(result);
                    labelSuma.Text = "Total Existencia: " + suma.ToString();
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

                string query = $"SELECT avg(ri.cantidad_stock) from restaurant_inventario ri";

                object result = oracleDBManager.ExecuteScalar(query);

                if (result != null && result != DBNull.Value)
                {
                    decimal suma = Convert.ToDecimal(result);
                    labelPromedio.Text = "Promedio Existencia: " + suma.ToString();
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

                string query = $"SELECT min(ri.cantidad_stock) from restaurant_inventario ri";

                object result = oracleDBManager.ExecuteScalar(query);

                if (result != null && result != DBNull.Value)
                {
                    decimal suma = Convert.ToDecimal(result);
                    labelMinimo.Text = "Mínimo Existencia: " + suma.ToString();
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

                string query = $"SELECT max(ri.cantidad_stock) from restaurant_inventario ri";

                object result = oracleDBManager.ExecuteScalar(query);

                if (result != null && result != DBNull.Value)
                {
                    decimal suma = Convert.ToDecimal(result);
                    labelMaximo.Text = "Máximo Existencia: " + suma.ToString();
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

        private void labelSuma_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ConectDB oracleDBManager = new ConectDB();

                string query = $"select ri.id_producto, ri.nombre, ri.descripcion, ri.cantidad_stock, ri.precio_unitario, rp.nombre as Proveedor from restaurant_inventario ri inner join restaurant_proveedores rp on rp.id_proveedor = ri.id_proveedor";

                data = oracleDBManager.ExecuteQueryUsers(query);

                ConectDB.ExportDataTableToPdf(data, @"Inventario.pdf", "Lista de Productos");

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }
    }
}
