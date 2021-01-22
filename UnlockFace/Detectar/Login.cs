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

namespace Detectar
{
    public partial class Login : Form
    {
        MySqlDataAdapter ad;
        MySqlDataReader consultar;
        public Login()
        {
            InitializeComponent();
            this.globomensaje.SetToolTip(this.txtusuario, "Ingrese un Usuario");
            this.globomensaje.SetToolTip(this.txtcontra, "Ingrese una Contraseña");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtusuario.Focus();
            txtusuario.Text = "Introduzca Usuario";
            txtusuario.ForeColor = Color.Gray;
            txtcontra.Text = "Introduzca Contraseña";
            txtcontra.ForeColor = Color.Gray;
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

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            txtusuario.Text = "";
            txtusuario.ForeColor = Color.Black;
        }

        private void txtcontra_Enter(object sender, EventArgs e)
        {
            txtcontra.Text = "";
            txtcontra.ForeColor = Color.Black;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MySqlConnection cnx = new MySqlConnection("Server=localhost; database=conector1; Uid=root; pwd=sincara12345; sslmode=none;");
            if (is_validate())
            {
                error.Clear();
                cnx.Open();
                ad = new MySqlDataAdapter("SELECT Rango FROM Usuarios WHERE Usuario='" + txtusuario.Text + "'AND Contraseña='" + txtcontra.Text + "' ", cnx); //Realizamos una selecion de la tabla usuarios.
                DataTable dtdatos = new DataTable();
                ad.Fill(dtdatos);
                if (dtdatos.Rows.Count == 1)
                {
                    this.Hide();
                    //Form2 nuevo = new Form2(dtdatos.Rows[0][0].ToString());
                    //nuevo.Show();
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                    txtusuario.Focus();//Te manda directo a text box para poder escribir
                    txtusuario.Clear();
                    txtcontra.Clear();
                }
                cnx.Close();
            }
        }
    }
}
