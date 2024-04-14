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
    public partial class EditarVenta : Form
    {
        private DataTable resultTable;
        public EditarVenta()
        {
            InitializeComponent();
            try
            {
                ConectDB oracleDBManager = new ConectDB();
                string query = "SELECT id_venta as Id, producto as Producto, cantidad as Cantidad, precio_unitario as Precio, subtotal as Subtotal, descuento as Descuento FROM restaurant_ventas";

                resultTable = oracleDBManager.ExecuteQueryUsers(query);

                selectVentas.Items.Clear();
                foreach (DataRow row in resultTable.Rows)
                {
                    string ventaString = $"{row["Id"]} - {row["Producto"]}";
                    selectVentas.Items.Add(ventaString);
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void menuprincipal_Click(object sender, EventArgs e)
        {
            MenuVentas menu = new MenuVentas();
            menu.Show();
            this.Hide();
        }

        private void selectVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectVentas.SelectedItem != null)
            {
                string ventaString = selectVentas.SelectedItem.ToString();

                string[] ventaData = ventaString.Split('-');

                string productoventa = ventaData[0].Trim();

                try
                {
                    DataRow[] selectedRows = resultTable.Select($"Id = '{productoventa}'");

                    if (selectedRows.Length > 0)
                    {

                        productoVenta.Text = selectedRows[0]["Producto"].ToString();

                        cantidadVenta.Text = selectedRows[0]["Cantidad"].ToString();

                        precioVenta.Text = selectedRows[0]["Precio"].ToString();

                        subtotalVenta.Text = selectedRows[0]["Subtotal"].ToString();

                        descuentoVenta.Text = selectedRows[0]["Descuento"].ToString();
                    }
                    else
                    {
                        MessageBox.Show($"No se encontraron datos para la venta {productoventa}.");
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
            if (selectVentas.SelectedItem != null)
            {
                string ventaString = selectVentas.SelectedItem.ToString(), producto = productoVenta.Text,
                    cantidad = cantidadVenta.Text, precio = precioVenta.Text, subtotal = subtotalVenta.Text, descuento= descuentoVenta.Text;

                if (precio == "" || producto == "" || cantidad == "" || subtotal == ""||descuento=="")
                {
                    MessageBox.Show("Debes de llenar todos los datos del formulario.");
                }
                try
                {

                    ConectDB oracleDBManager = new ConectDB();

                    string sqlUpdate = $"update restaurant_ventas set producto= '{producto}',cantidad={cantidad},precio_unitario={precio},subtotal={subtotal}, descuento= {descuentoVenta} where id_venta = '{ventaString}'";

                    oracleDBManager.ExecuteNonQuery(sqlUpdate);

                    MessageBox.Show("Venta actualizado correctamente.");
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
                MessageBox.Show("Por favor selecciona una Venta.");
            }
        }
    }
}
