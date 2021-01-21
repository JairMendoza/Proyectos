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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.globomensaje.SetToolTip(this.txtnombre, "Ingrese un Nombre");
            this.globomensaje.SetToolTip(this.txtusuario, "Ingrese una Usuario");
            this.globomensaje.SetToolTip(this.txtcontra, "Ingrese contraseña");
            this.globomensaje.SetToolTip(this.comboBox1, "Ingrese un Tipo de usuario");
            this.globomensaje.SetToolTip(this.txtrcontra, "Ingrese un Contraseña");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost; database=registrar; Uid=root;  pwd=sincara12345; sslmode=none;");
            if (is_validate())
            {
                error.Clear();
                con.Open();
                MySqlCommand cmd = new MySqlCommand("Insert into usuario(nombre,user,contra,tele,domi,rcontra) VALUES ('" + txtnombre.Text + "','" + txtusuario.Text + "' , '" + txtcontra + "', '" + Int32.Parse(txttel.Text) + "' , '" + comboBox1.Text + "','" + txtrcontra.Text + "') ;", con);
                if (txtcontra.Text == txtrcontra.Text)
                {
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read()) //Si el usuario es correcto nos abrira la otra ventana.
                    {

                    }
                    else
                    {
                        MessageBox.Show("Usuario Registrado.");
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                }
            }
        }
        private bool is_validate()
        {
            bool bandera = true;
            if(txtnombre.Text==string.Empty)
            {
                error.SetError(txtusuario, "Ingrese el Nombre");
                bandera = false;

            }
            if (txtusuario.Text == string.Empty)
            {
                error.Clear();
                error.SetError(txtusuario, "Ingrese el Usuario");
                bandera = false;
                return false;
            }
            if (txtcontra.Text == string.Empty)
            {
                error.Clear();
                error.SetError(txtcontra, "Ingrese contraseña");
                bandera = false;
                return false;
            }
            if(comboBox1.Text==string.Empty)
            {
                error.Clear();
                error.SetError(txtcontra, "Ingrese Admin o empleado");
                bandera = false;
                return false;
            }
            if(txtrcontra.Text==string.Empty)
            {
                error.Clear();
                error.SetError(txtcontra, "Repita contraseña");
                bandera = false;
                return false;
            }
            if(txtcontra.Text!=txtrcontra.Text)
            {
                error.Clear();
                error.SetError(txtcontra, "Las contraseñas no coinciden");
                bandera = false;
                return false;
            }
            return bandera;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ventana2 = new Form2();
            ventana2.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        
    }
}
