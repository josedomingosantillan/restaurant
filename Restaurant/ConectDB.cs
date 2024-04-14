using System;
using System.Data;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Oracle.ManagedDataAccess.Client;
using Restaurant;

namespace PersonaGUI
{
    internal class ConectDB
    {

        private readonly string _connectionString;
        private OracleConnection _connection;

        public ConectDB()
        {

            _connectionString = "User Id=SYSTEM;Password=chivasDE1;Data Source=localhost:1521/FREE;";
        }

        public void OpenConnection()
        {
            if (_connection == null)
            {
                _connection = new OracleConnection(_connectionString);
            }

            if (_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Open();
                Console.WriteLine("Conexión abierta");
            }
        }

        public void CloseConnection()
        {
            if (_connection != null && _connection.State != System.Data.ConnectionState.Closed)
            {
                _connection.Close();
                Console.WriteLine("Conexión cerrada");
            }
        }

        public DataTable ExecuteQueryUsers(string sql)
        {
            OpenConnection();

            using (OracleCommand cmd = new OracleCommand(sql, _connection))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
        }

        public object ExecuteScalar(string sql)
        {
            OpenConnection();

            using (OracleCommand cmd = new OracleCommand(sql, _connection))
            {
                try
                {
                    object result = cmd.ExecuteScalar();
                    return result;
                }
                catch (OracleException ex)
                {
                    throw ex;
                }
            }
        }

        public void Menu()
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }

        public bool ValidateUser(string username, string password)
        {
            try
            {
                OpenConnection();

                string sql = "SELECT COUNT(*) FROM usuarios WHERE USERNAME = :USERNAME AND contrasena = :CONTRASENA";

                using (OracleCommand command = new OracleCommand(sql, _connection))
                {
                    command.Parameters.Add(new OracleParameter("USERNAME", username));
                    command.Parameters.Add(new OracleParameter("CONTRASEA", password));

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count == 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine("Error al validar el usuario: " + ex.Message);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool ExecuteNonQuery(string sql)
        {
            try
            {
                OpenConnection();

                using (OracleCommand command = new OracleCommand(sql, _connection))
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected == 1;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public static void ExportDataTableToPdf(DataTable dt, string filePath, string title)
        {
            Document document = new Document(PageSize.A4, 50, 50, 25, 25);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

            // Añadir el logo
            string imagePath = @"C:\Users\MSI PRENDAMEX\source\repos\Restaurant\Restaurant\imagenes\logo.png"; 
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(imagePath);
            logo.ScaleToFit(140f, 120f); 
            logo.Alignment = iTextSharp.text.Image.ALIGN_CENTER; 
            document.Add(logo);

            Paragraph paragraph = new Paragraph(new Phrase(14f, title, FontFactory.GetFont("Arial", 18, iTextSharp.text.Font.BOLD)));
            paragraph.Alignment = Element.ALIGN_CENTER;
            document.Add(paragraph);

            document.Add(new Paragraph("\n"));

            PdfPTable pdfTable = new PdfPTable(dt.Columns.Count);
            pdfTable.WidthPercentage = 100;

            foreach (DataColumn column in dt.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                pdfTable.AddCell(cell);
            }

            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    pdfTable.AddCell(item.ToString());
                }
            }

            document.Add(pdfTable);
            document.Close();
            writer.Close();

            MessageBox.Show("Exportación a PDF realizada con éxito.");
        }

    }
}
