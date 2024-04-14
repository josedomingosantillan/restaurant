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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restaurant
{
    public partial class EditarClientes : Form
    {
        private DataTable resultTable;
        public EditarClientes()
        {
            InitializeComponent();
            try
            {
                ConectDB oracleDBManager = new ConectDB();
                string query = "SELECT id_cliente as Id, nombre as Nombre, apellido as Apellido, telefono as Telefono, email as Email FROM restaurant_clientes";

                resultTable = oracleDBManager.ExecuteQueryUsers(query);

                selectClientes.Items.Clear();
                foreach (DataRow row in resultTable.Rows)
                {
                    string clienteString = $"{row["Id"]} - {row["Nombre"]} {row["Apellido"]}";
                    selectClientes.Items.Add(clienteString);
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void selectUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectClientes.SelectedItem != null)
            {
                string clienteString = selectClientes.SelectedItem.ToString();

                string[] clienteData = clienteString.Split('-');

                string nombrecliente = clienteData[0].Trim();

                try
                {
                    DataRow[] selectedRows = resultTable.Select($"Id = '{nombrecliente}'");

                    if (selectedRows.Length > 0)
                    {

                        nombreCliente.Text = selectedRows[0]["Nombre"].ToString();

                        apeCliente.Text = selectedRows[0]["Apellido"].ToString();

                        telCliente.Text = selectedRows[0]["Telefono"].ToString();

                        emailcliente.Text = selectedRows[0]["Email"].ToString();
                    }
                    else
                    {
                        MessageBox.Show($"No se encontraron datos para el usuario {clienteData[1].Trim()}.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private void menuprincipal_Click(object sender, EventArgs e)
        {
            MenuClientes menu = new MenuClientes();
            menu.Show();
            this.Hide();
        }

        private void actualizarCliente_Click(object sender, EventArgs e)
        {
            if (selectClientes.SelectedItem != null)
            {
                string clienteString = selectClientes.SelectedItem.ToString(), nombre = nombreCliente.Text,
                    apellido= apeCliente.Text, tel= telCliente.Text,email= emailcliente.Text;

                string[] clienteData = clienteString.Split('-');

                if (nombre=="" || apellido == "" || tel == "" || email == "")
                {
                    MessageBox.Show("Debes de llenar todos los datos del formulario.");
                }
                    try
                    {

                        ConectDB oracleDBManager = new ConectDB();

                        string sqlUpdate = $"update restaurant_clientes set nombre= '{nombre}',apellido='{apellido}',telefono='{tel}',email='{email}' where id_cliente = '{clienteData[0].Trim()}'";

                        oracleDBManager.ExecuteNonQuery(sqlUpdate);

                        MessageBox.Show("Cliente actualizado correctamente.");
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
                MessageBox.Show("Por favor selecciona un cliente.");
            }
        }
    }
}
