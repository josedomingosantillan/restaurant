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
    public partial class EditarInventario : Form
    {
        private DataTable resultTable;
        public EditarInventario()
        {
            InitializeComponent();
            try
            {
                ConectDB oracleDBManager = new ConectDB();
                string query = "SELECT id_producto as Id, nombre as Nombre, descripcion as Descripcion, cantidad_stock as Cantidad, precio_unitario as Precio FROM restaurant_inventario";

                resultTable = oracleDBManager.ExecuteQueryUsers(query);

                selectProductos.Items.Clear();
                foreach (DataRow row in resultTable.Rows)
                {
                    string clienteString = $"{row["Id"]} - {row["Nombre"]}";
                    selectProductos.Items.Add(clienteString);
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void menuprincipal_Click(object sender, EventArgs e)
        {
            MenuInventario menu = new MenuInventario();
            this.Hide();
            menu.Show();
        }

        private void selectProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectProductos.SelectedItem != null)
            {
                string productoString = selectProductos.SelectedItem.ToString();

                string[] productoData = productoString.Split('-');

                string nombreproducto = productoData[0].Trim();

                try
                {
                    DataRow[] selectedRows = resultTable.Select($"Id = '{nombreproducto}'");

                    if (selectedRows.Length > 0)
                    {

                        nombreProducto.Text = selectedRows[0]["Nombre"].ToString();

                        descProducto.Text = selectedRows[0]["Descripcion"].ToString();

                        cantProducto.Text = selectedRows[0]["Cantidad"].ToString();

                        precioProducto.Text = selectedRows[0]["Precio"].ToString();
                    }
                    else
                    {
                        MessageBox.Show($"No se encontraron datos para el usuario {productoData[1].Trim()}.");
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
            if (selectProductos.SelectedItem != null)
            {
                string productoString = selectProductos.SelectedItem.ToString(), nombre = nombreProducto.Text,
                    cantidad = cantProducto.Text, precio = precioProducto.Text, desc = descProducto.Text;

                string[] productoData = productoString.Split('-');

                if (nombre == "" || cantidad == "" || precio == "" || desc == "")
                {
                    MessageBox.Show("Debes de llenar todos los datos del formulario.");
                }
                try
                {

                    ConectDB oracleDBManager = new ConectDB();

                    string sqlUpdate = $"update restaurant_inventario set nombre= '{nombre}',descripcion='{desc}',cantidad_stock={cantidad},precio_unitario='{precio}' where id_producto = '{productoData[0].Trim()}'";

                    oracleDBManager.ExecuteNonQuery(sqlUpdate);

                    MessageBox.Show("Producto actualizado correctamente.");
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
                MessageBox.Show("Por favor selecciona un producto.");
            }
        }
    }
}
