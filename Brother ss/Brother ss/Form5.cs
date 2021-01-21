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
    public partial class Form5 : Form
    {
        MySqlCommand Query = new MySqlCommand();
        MySqlConnection con = new MySqlConnection("Server=localhost; database=registrar; Uid=root; pwd=sincara12345; sslmode=none;");
        MySqlDataAdapter ad;
        MySqlDataReader consultar;
        public Form5()
        {
            InitializeComponent();
            DataTable dtdatos = new DataTable();
            ad = new MySqlDataAdapter("SELECT * FROM registrar.usuario ", con);
            ad.Fill(dtdatos);
            pedro.DataSource = dtdatos;
        }

        private void pedro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ven2 = new Form2();
            ven2.Show();
        }
    }
}
