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
    public partial class Form2 : Form
    {
        MySqlDataAdapter ad;
        MySqlDataReader consultar;
        public Form2()
        {
            InitializeComponent();
            this.globomensaje.SetToolTip(this.txtusuario, "Ingrese un Usuario");
            this.globomensaje.SetToolTip(this.txtcontra, "Ingrese una Contraseña");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }    
        private bool is_validate()
        {
            bool bandera = true;
            if (txtusuario.Text == string.Empty)
            {
                error.SetError(txtusuario, "Ingrese el Usuario");
                bandera = false;
            }
            if (txtcontra.Text == string.Empty)
            {
                error.Clear();
                error.SetError(txtcontra, "Ingrese contraseña");
                bandera = false;
                return false;
            }
            return bandera;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MySqlConnection cnx = new MySqlConnection("Server=localhost; database=registrar; Uid=root; pwd=sincara12345; sslmode=none;");
            if (is_validate())
            {
                error.Clear();
                cnx.Open();
                ad = new MySqlDataAdapter("SELECT domi FROM registrar.usuario WHERE user='" + txtusuario.Text + "'AND contra='" + txtcontra.Text + "' ", cnx); //Realizamos una selecion de la tabla usuarios.
                DataTable dtdatos = new DataTable();
                ad.Fill(dtdatos);
                if (dtdatos.Rows.Count == 1)
                {
                    this.Hide();
                    Form3 NuevaVentan = new Form3(dtdatos.Rows[0][0].ToString());
                    NuevaVentan.Show();
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                }




                cnx.Close();
            }
        }
    }
}
