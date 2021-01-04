using Quiz_2.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            dynamic result1 = BookController.GetAllBook2(id);
            if (result1 != null)
            {
                dataGridView1.DataSource = result1;
            }
            else
            {
                MessageBox.Show("No Books found");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var book = new
            {
                Id = Convert.ToInt32(textBox2.Text),
                Name = textBox3.Text,
                Author = textBox4.Text,
                Edition = textBox5.Text
            };
            var result = BookController.AddFood(book);
            if (result)
            {
                MessageBox.Show("Book Added");
            }
            else
            {
                MessageBox.Show("Book Couldnt't Added");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result2 = BookController.GetAllBook1();
            dataGridView2.DataSource = result2;
        }
    }
}
