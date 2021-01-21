using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Brother_ss
{
    public partial class Form3 : Form
    {
        public Form3(string role)
        {
            InitializeComponent();
            label1.Text = role; 
        }

        private void Form3_Load(object sender, EventArgs e)
        {
             if(label1.Text!="admin")
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 ventana4 = new Form4();
            ventana4.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ventana2 = new Form2();
            ventana2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 vent = new Form5();
            vent.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 venta = new Form6();
            venta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 venta7 = new Form7();
            venta7.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 venta8 = new Form8();
            venta8.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 venta9 = new Form9();
            venta9.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 venta10 = new Form10();
            venta10.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 ven11 = new Form11();
            ven11.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 eli = new Form12();
            eli.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 edi = new Form13();
            edi.Show();
        }
    }
}
