using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exerciseDataSet.Data_Kontrakan' table. You can move, or remove it, as needed.
            this.data_KontrakanTableAdapter.Fill(this.exerciseDataSet.Data_Kontrakan);
            // TODO: This line of code loads data into the 'exerciseDataSet.Data_Kontrakan' table. You can move, or remove it, as needed.
            this.data_KontrakanTableAdapter.Fill(this.exerciseDataSet.Data_Kontrakan);

        }

        private void txtNk_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}
