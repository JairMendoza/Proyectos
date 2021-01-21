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
    public partial class Form8 : Form
    {
        MySqlCommand Query = new MySqlCommand();
        MySqlConnection con = new MySqlConnection("Server=localhost; database=registrar; Uid=root; pwd=sincara12345; sslmode=none;");
        MySqlDataAdapter ad;
        MySqlDataReader consultar;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dtdatos = new DataTable();
            ad = new MySqlDataAdapter("SELECT * FROM registrar.usuario ", con);
            ad.Fill(dtdatos);
            pedro.DataSource = dtdatos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtid.Text = this.pedro.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = this.pedro.CurrentRow.Cells[1].Value.ToString();
            txtcontra.Text = this.pedro.CurrentRow.Cells[2].Value.ToString();
            txtprecio.Text = this.pedro.CurrentRow.Cells[3].Value.ToString();
            txtcosto.Text = this.pedro.CurrentRow.Cells[4].Value.ToString();
            txtcantidad.Text = this.pedro.CurrentRow.Cells[5].Value.ToString();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            editar();
        }
        void editar()
        {
            con.Open();
            MySqlCommand consulta = new MySqlCommand("update usuario set nombre='" + txtnombre.Text + "',user='" + txtcontra.Text + "',contra='" + txtcontra.Text + "',tele=" + txtcosto.Text + ",rcontra='" + txtcantidad.Text + "'", con);
            consulta.ExecuteNonQuery();
            MessageBox.Show("Registro Actualizado");
            con.Close();
        }
    }
}
