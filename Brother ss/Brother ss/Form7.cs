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
    public partial class Form7 : Form
    {
        MySqlCommand Query = new MySqlCommand();
        MySqlConnection con = new MySqlConnection("Server=localhost; database=registrar; Uid=root; pwd=sincara12345; sslmode=none;");
        MySqlDataAdapter ad;
        MySqlDataReader consultar;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dtdatos = new DataTable();
            ad = new MySqlDataAdapter("SELECT * FROM registrar.usuario ", con);
            ad.Fill(dtdatos);
            pedro.DataSource = dtdatos;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txteliminar.Text = this.pedro.CurrentRow.Cells[0].Value.ToString();

        }
        void eliminar()
        {
            con.Open();
            MySqlCommand consulta = new MySqlCommand("delete from registrar.usuario where idusuario="+txteliminar.Text+"", con);
            consulta.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado");
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ve = new Form2();
            ve.Show();
        }
    }
}
