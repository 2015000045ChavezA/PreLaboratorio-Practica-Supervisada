using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioChristianChavez
{
    public partial class BaseDatos : Form
    {
        public BaseDatos()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Creditos creditos = new Creditos();
            creditos.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
        textBox1.Text,
        textBox2.Text,
        textBox3.Text,
        textBox4.Text,
        textBox5.Text,
        textBox6.Text
    );
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

  
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

               
                row.Cells[0].Value = textBox1.Text;
                row.Cells[1].Value = textBox2.Text;
                row.Cells[2].Value = textBox3.Text;
                row.Cells[3].Value = textBox4.Text;
                row.Cells[4].Value = textBox5.Text;
                row.Cells[5].Value = textBox6.Text;

                
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();

                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Selecciona una fila para editar.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

            }
            else
            {
                MessageBox.Show("Por favor selecciona una fila para eliminar.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells[0].Value?.ToString();
                textBox2.Text = row.Cells[1].Value?.ToString();
                textBox3.Text = row.Cells[2].Value?.ToString();
                textBox4.Text = row.Cells[3].Value?.ToString();
                textBox5.Text = row.Cells[4].Value?.ToString();
                textBox6.Text = row.Cells[5].Value?.ToString();
            }
        }
    }
}
