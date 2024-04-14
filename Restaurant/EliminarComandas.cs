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
    public partial class EliminarComandas : Form
    {
        private DataTable resultTable;
        public EliminarComandas()
        {
            InitializeComponent();
            try
            {
                ConectDB oracleDBManager = new ConectDB();
                string query = "SELECT id_comanda as Id from restaurant_comandas";
                // Asignar el resultado de la consulta al DataTable resultTable
                resultTable = oracleDBManager.ExecuteQueryUsers(query);

                // Llenar el ComboBox con los nombres de usuario
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

        private void actualizaruser_Click(object sender, EventArgs e)
        {
            if (selectComandas.SelectedItem != null)
            {
                string comandaString = selectComandas.SelectedItem.ToString();
                try
                {
                    ConectDB oracleDBManager = new ConectDB();

                    string sqlUpdate = $"delete from restaurant_comandas where id_comanda = '{comandaString}'";

                    oracleDBManager.ExecuteNonQuery(sqlUpdate);

                    MessageBox.Show("Comanda eliminada correctamente.");
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

        private void menuprincipal_Click(object sender, EventArgs e)
        {
            MenuComandas men_co= new MenuComandas();
            men_co.Show();
            this.Hide();
        }
    }
}
