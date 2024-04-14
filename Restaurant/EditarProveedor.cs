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
    public partial class EditarProveedor : Form
    {
        private DataTable resultTable;
        public EditarProveedor()
        {
            InitializeComponent();
            try
            {
                ConectDB oracleDBManager = new ConectDB();
                string query = "SELECT id_proveedor as Id, nombre as Nombre, telefono as Telefono, contacto as Contacto FROM restaurant_proveedores";

                resultTable = oracleDBManager.ExecuteQueryUsers(query);

                selectProveedores.Items.Clear();
                foreach (DataRow row in resultTable.Rows)
                {
                    string clienteString = $"{row["Id"]} - {row["Nombre"]}";
                    selectProveedores.Items.Add(clienteString);
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
            this.Hide();
            menu.Show();
        }

        private void selectProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectProveedores.SelectedItem != null)
            {
                string proveedorString = selectProveedores.SelectedItem.ToString();

                string[] proveedorData = proveedorString.Split('-');

                string nombreproveedor = proveedorData[0].Trim();

                try
                {
                    DataRow[] selectedRows = resultTable.Select($"Id = '{nombreproveedor}'");

                    if (selectedRows.Length > 0)
                    {

                        nombreProveedor.Text = selectedRows[0]["Nombre"].ToString();

                        telProveedor.Text = selectedRows[0]["Telefono"].ToString();

                        contactoProveedor.Text = selectedRows[0]["Contacto"].ToString();
                    }
                    else
                    {
                        MessageBox.Show($"No se encontraron datos para el proveedor {proveedorData[1].Trim()}.");
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
            if (selectProveedores.SelectedItem != null)
            {
                string proveedorString = selectProveedores.SelectedItem.ToString(), nombre = nombreProveedor.Text,
                    tel = telProveedor.Text, contacto = contactoProveedor.Text;

                string[] proveedorData = proveedorString.Split('-');

                if (nombre == "" || tel == "" || contacto == "")
                {
                    MessageBox.Show("Debes de llenar todos los datos del formulario.");
                }
                try
                {

                    ConectDB oracleDBManager = new ConectDB();

                    string sqlUpdate = $"update restaurant_proveedores set nombre= '{nombre}',telefono='{tel}',contacto='{contacto}' where id_cliente = '{proveedorData[0].Trim()}'";

                    oracleDBManager.ExecuteNonQuery(sqlUpdate);

                    MessageBox.Show("Proveedor actualizado correctamente.");
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
                MessageBox.Show("Por favor selecciona un proveedor.");
            }
        }
    }
}
