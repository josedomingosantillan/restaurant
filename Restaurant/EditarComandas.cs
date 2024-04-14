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
    public partial class EditarComandas : Form
    {
        private DataTable resultTable;
        public EditarComandas()
        {
            InitializeComponent();
            try
            {
                ConectDB oracleDBManager = new ConectDB();
                string query = "SELECT id_comanda as Id, total as Total, estado as Estado, observaciones as Observaciones FROM restaurant_comandas";

                resultTable = oracleDBManager.ExecuteQueryUsers(query);

                selectComandas.Items.Clear();
                foreach (DataRow row in resultTable.Rows)
                {
                    string comandaString = $"{row["Id"]}";
                    selectComandas.Items.Add(comandaString);
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void menuprincipal_Click(object sender, EventArgs e)
        {
            MenuComandas menu = new MenuComandas();
            menu.Show();
            this.Hide();
        }

        private void actualizarCliente_Click(object sender, EventArgs e)
        {
            if (selectComandas.SelectedItem != null)
            {
                string comandaString = selectComandas.SelectedItem.ToString(), total = totaComanda.Text,
                    estado = estadoComanda.Text, obse = observacionesComanda.Text;

                if (total == "" || estado == "" || obse == "")
                {
                    MessageBox.Show("Debes de llenar todos los datos del formulario.");
                }
                try
                {

                    ConectDB oracleDBManager = new ConectDB();

                    string sqlUpdate = $"update restaurant_comandas set total= {total},estado='{estado}',observaciones='{obse}' where id_comanda = '{comandaString}'";

                    oracleDBManager.ExecuteNonQuery(sqlUpdate);

                    MessageBox.Show("Comanda actualizada correctamente.");
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
                MessageBox.Show("Por favor selecciona una comanda.");
            }
        }

        private void selectComandas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectComandas.SelectedItem != null)
            {
                string comandaString = selectComandas.SelectedItem.ToString();

                try
                {
                    DataRow[] selectedRows = resultTable.Select($"Id = '{comandaString}'");

                    if (selectedRows.Length > 0)
                    {

                        totaComanda.Text = selectedRows[0]["Total"].ToString();

                        estadoComanda.Text = selectedRows[0]["Estado"].ToString();

                        observacionesComanda.Text = selectedRows[0]["Observaciones"].ToString();

                    }
                    else
                    {
                        MessageBox.Show($"No se encontraron datos para la comanda {comandaString}.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
