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
            string contrase�a = "5toBachA";

            if (textBox1.Text == usuario && textBox2.Text == contrase�a)
            {
                MessageBox.Show("Usuario y contrase�a correcta");
                BaseDatos baseDatos = new BaseDatos();
                baseDatos.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Usuario o contrase�a incorrectas.");
            }
        }
    }
}
