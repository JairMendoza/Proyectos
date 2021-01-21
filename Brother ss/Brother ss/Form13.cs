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
    public partial class Form13 : Form
    {
        MySqlCommand Query = new MySqlCommand();
        MySqlConnection con = new MySqlConnection("Server=localhost; database=registrar_pro; Uid=root; pwd=sincara12345; sslmode=none;");
        MySqlDataAdapter ad;
        MySqlDataReader consultar;
        public Form13()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtid.Text = this.pedro.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = this.pedro.CurrentRow.Cells[1].Value.ToString();
            txtmarca.Text = this.pedro.CurrentRow.Cells[2].Value.ToString();
            txtprecio.Text = this.pedro.CurrentRow.Cells[3].Value.ToString();
            txtcosto.Text = this.pedro.CurrentRow.Cells[4].Value.ToString();
            txtcantidad.Text = this.pedro.CurrentRow.Cells[5].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dtdatos = new DataTable();
            ad = new MySqlDataAdapter("SELECT * FROM registrar_pro.producto ", con);
            ad.Fill(dtdatos);
            pedro.DataSource = dtdatos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ven2 = new Form2();
            ven2.Show();
        }
       

        private void button4_Click(object sender, EventArgs e)
        {
            editar();
        }
        void editar()
        {


            con.Open();
            MySqlCommand consulta = new MySqlCommand("update registrar_pro.producto set nombre='" + txtnombre.Text + "',marca='" + txtmarca.Text + "',precio=" + txtprecio.Text + ",costo=" + txtcosto.Text + ",cantidad=" + txtcantidad.Text +"", con);
            consulta.ExecuteNonQuery();
            MessageBox.Show("Registro Actualizado");
            con.Close();

        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }
    }
}
