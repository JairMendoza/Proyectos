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
    public partial class Form12 : Form
    {
        MySqlCommand Query = new MySqlCommand();
        MySqlConnection con = new MySqlConnection("Server=localhost; database=registrar_pro; Uid=root; pwd=sincara12345; sslmode=none;");
        MySqlDataAdapter ad;
        MySqlDataReader consultar;
        public Form12()
        {
            InitializeComponent();
           
        }

        private void txteliminar_TextChanged(object sender, EventArgs e)
        {
            eliminar();
        }
        void eliminar()
        {
            try
            {
                if (txteliminar.Text == "")
                {
                    MessageBox.Show("Debe de llenar el campo de filtro para realizar la busqueda", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txteliminar.Focus();
                }
                else
                {
                    MySqlCommand consulta = new MySqlCommand("DELETE FROM registrar_pro.producto where idproducto="+txteliminar.Text+"", con);
                    MySqlDataAdapter da = new MySqlDataAdapter(consulta);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    pedro.DataSource = dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La consulta no arrojo resultados" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ven2 = new Form2();
            ven2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dtdatos = new DataTable();
            ad = new MySqlDataAdapter("SELECT * FROM registrar_pro.producto ", con);
            ad.Fill(dtdatos);
            pedro.DataSource = dtdatos;
        }
    }
}
