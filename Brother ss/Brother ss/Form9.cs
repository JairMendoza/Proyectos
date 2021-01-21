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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            this.globomensaje.SetToolTip(this.txtnombre, "Ingrese un Nombre");
            this.globomensaje.SetToolTip(this.txtmarca, "Ingrese una Marca");
            this.globomensaje.SetToolTip(this.txtprecio, "Ingrese un Precio");
            this.globomensaje.SetToolTip(this.txtcosto, "Ingrese la costo");
            this.globomensaje.SetToolTip(this.txtcantidad, "Ingrese la cantidad");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection("Server=localhost; database=registrar_pro; Uid=root; pwd=sincara12345; sslmode=none;");
            if (is_validate())
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("Insert into producto(nombre, marca,precio, costo, cantidad) VALUES ('" + txtnombre.Text + "','" + txtmarca.Text + "' , '" + Int32.Parse(txtprecio.Text) + "', '" + Int32.Parse(txtcosto.Text) + "' , '" + Int32.Parse(txtcantidad.Text) + "') ;", con);
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
        }


        private void Form9_Load(object sender, EventArgs e)
        {

        }
        private bool is_validate()
        {
            bool bandera = true;
            if (txtnombre.Text == string.Empty)
            {
                error.SetError(txtnombre, "Ingrese el Nombre");
                bandera = false;

            }
            if (txtmarca.Text == string.Empty)
            {
                error.Clear();
                error.SetError(txtmarca, "Ingrese la marca");
                bandera = false;
                return false;
            }
            if (txtprecio.Text == string.Empty)
            {
                error.Clear();
                error.SetError(txtprecio, "Ingrese precio");
                bandera = false;
                return false;
            }
            if (txtcosto.Text == string.Empty)
            {
                error.Clear();
                error.SetError(txtcosto, "Ingrese costo");
                bandera = false;
                return false;
            }
            if (txtcantidad.Text == string.Empty)
            {
                error.Clear();
                error.SetError(txtcantidad, "Ingrese cantidad");
                bandera = false;
                return false;
            }

            return bandera;
        }
    }

}