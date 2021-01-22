using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using MySql.Data.MySqlClient;
using System.IO;


namespace Detectar
{
    public partial class Form1 : Form
    {
        int elID = 0,nobus=0;
        int contador=0;
        MySqlConnection con = new MySqlConnection("Server=127.0.0.1; database=conector1; Uid=root; pwd=1234567890; sslmode=none;");
        MySqlDataReader consultar;
        public string mensaje;
        public Form1()
        {
            InitializeComponent();
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
        }
        private delegate void LineReceivedEvent(string line);
        private void LineReceived(string line)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!serialPort2.IsOpen)
                serialPort2.Open();
            serialPort2.Write(textBox1.Text);
            var sel =  String.Format("SELECT count(*) FROM arduino1");
            {
                MySqlCommand cmd = new MySqlCommand(sel, con);
                con.Open();
                elID = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            conteid.Text = Convert.ToString(elID);

           

        }

        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
           mensaje = serialPort2.ReadLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = mensaje;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand ima = new MySqlCommand("insert into arduino1(Nombre,Am,Ap,Matricula,Carrera,Huella,idmodulo) values('" + txtnombre.Text + "','"+ txtapellido.Text+ "','" + txtapellidom.Text + "','" + txtmatricula.Text + "','" + txtcarrera.Text + "','" + textBox8.Text + "','"+ Convert.ToString(elID) +"' )", con);
            MySqlDataReader leer = ima.ExecuteReader();
            if (leer.Read()) //Si el usuario es correcto nos abrira la otra ventana.
            {

            }
            else
            {
                MessageBox.Show("Datos Guardados.");
            }
            con.Close();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            serialPort2.WriteLine("E");
            serialPort2.WriteLine(Convert.ToString(elID));
        }

        public void Buscar_Click(object sender, EventArgs e)
        {
 

                con.Open();
                serialPort2.WriteLine("B");
                MySqlCommand ad = new MySqlCommand("SELECT * FROM arduino1 where idmodulo= @ID", con);
                ad.Parameters.AddWithValue("@ID", txtinvisible.Text);
                MySqlDataReader buscar = ad.ExecuteReader();
                string id = Convert.ToString(serialPort2.ReadLine());
                conteid.Text = id;
                txtinvisible.Text = id;
                DataTable dtdatos = new DataTable();

                if (buscar.Read())
                {
                    txtnombre.Text = buscar["Nombre"].ToString();
                    txtapellido.Text = buscar["Am"].ToString();
                    txtapellidom.Text = buscar["Ap"].ToString();
                    txtmatricula.Text = buscar["Matricula"].ToString();
                    txtcarrera.Text = buscar["Carrera"].ToString();
                }

                con.Close();
            if(nobus==0)
            {
                buscar1();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void nobuscar_Click(object sender, EventArgs e)
        {
            nobus = 0;
            serialPort2.WriteLine("X");
            nobus = 1;


        }

        private void conteid_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void buscar1()
        {
            con.Open();
            serialPort2.WriteLine("B");
            MySqlCommand ad = new MySqlCommand("SELECT * FROM arduino1 where idmodulo= @ID", con);
            ad.Parameters.AddWithValue("@ID", txtinvisible.Text);
            MySqlDataReader buscar = ad.ExecuteReader();
            string id = Convert.ToString(serialPort2.ReadLine());
            conteid.Text = id;
            txtinvisible.Text = id;
            DataTable dtdatos = new DataTable();

            if (buscar.Read())
            {
                txtnombre.Text = buscar["Nombre"].ToString();
                txtapellido.Text = buscar["Am"].ToString();
                txtapellidom.Text = buscar["Ap"].ToString();
                txtmatricula.Text = buscar["Matricula"].ToString();
                txtcarrera.Text = buscar["Carrera"].ToString();
            }

            con.Close();
        }
    }
}
