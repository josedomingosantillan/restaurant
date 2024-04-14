using PersonaGUI;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = username.Text, password = passw.Text;
            if (user == "" || password == "")
            {
                MessageBox.Show("Todos los campos deben estar llenos.");
                return;
            }

            ConectDB bd = new ConectDB();

            if (bd.ValidateUser(user, password))
            {
                this.Hide();
                bd.Menu();
                return;
            }

            MessageBox.Show("Datos inválidos.");
        }
    }
}
