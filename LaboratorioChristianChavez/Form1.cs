namespace LaboratorioChristianChavez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = "ChristianChavez11";
            string contraseña = "5toBachA";

            if (textBox1.Text == usuario && textBox2.Text == contraseña)
            {
                MessageBox.Show("Usuario y contraseña correcta");
                BaseDatos baseDatos = new BaseDatos();
                baseDatos.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Usuario o contraseña incorrectas.");
            }
        }
    }
}
