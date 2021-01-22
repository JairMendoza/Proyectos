namespace Detectar
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtapellidom = new System.Windows.Forms.TextBox();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcarrera = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.enrolar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.nobuscar = new System.Windows.Forms.Button();
            this.conteid = new System.Windows.Forms.Label();
            this.txtinvisible = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 303);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 28);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // serialPort2
            // 
            this.serialPort2.BaudRate = 57600;
            this.serialPort2.PortName = "COM14";
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Conectar Arduino";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "Leer Datos de la huella";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(193, 306);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(55, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.Visible = false;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(116, 27);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(108, 29);
            this.txtnombre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellido Materno:";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(172, 85);
            this.txtapellido.Multiline = true;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(116, 26);
            this.txtapellido.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Apellido Materno:";
            // 
            // txtapellidom
            // 
            this.txtapellidom.Location = new System.Drawing.Point(174, 140);
            this.txtapellidom.Multiline = true;
            this.txtapellidom.Name = "txtapellidom";
            this.txtapellidom.Size = new System.Drawing.Size(116, 26);
            this.txtapellidom.TabIndex = 10;
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(125, 199);
            this.txtmatricula.Multiline = true;
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(149, 26);
            this.txtmatricula.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Matricula:";
            // 
            // txtcarrera
            // 
            this.txtcarrera.Location = new System.Drawing.Point(424, 27);
            this.txtcarrera.Multiline = true;
            this.txtcarrera.Name = "txtcarrera";
            this.txtcarrera.Size = new System.Drawing.Size(149, 26);
            this.txtcarrera.TabIndex = 14;
            this.txtcarrera.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Carrera";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(450, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 53);
            this.button3.TabIndex = 15;
            this.button3.Text = "Registrar a base de datos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(424, 202);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(149, 26);
            this.textBox8.TabIndex = 16;
            this.textBox8.Text = "Registrada";
            this.textBox8.Visible = false;
            // 
            // enrolar
            // 
            this.enrolar.Location = new System.Drawing.Point(649, 367);
            this.enrolar.Name = "enrolar";
            this.enrolar.Size = new System.Drawing.Size(75, 23);
            this.enrolar.TabIndex = 17;
            this.enrolar.Text = "Enrolar";
            this.enrolar.UseVisualStyleBackColor = true;
            this.enrolar.Click += new System.EventHandler(this.button4_Click);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(651, 280);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 18;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // nobuscar
            // 
            this.nobuscar.Location = new System.Drawing.Point(651, 328);
            this.nobuscar.Name = "nobuscar";
            this.nobuscar.Size = new System.Drawing.Size(75, 23);
            this.nobuscar.TabIndex = 19;
            this.nobuscar.Text = "Dejar de Buscar";
            this.nobuscar.UseVisualStyleBackColor = true;
            this.nobuscar.Click += new System.EventHandler(this.nobuscar_Click);
            // 
            // conteid
            // 
            this.conteid.AutoSize = true;
            this.conteid.Location = new System.Drawing.Point(447, 286);
            this.conteid.Name = "conteid";
            this.conteid.Size = new System.Drawing.Size(46, 17);
            this.conteid.TabIndex = 20;
            this.conteid.Text = "label7";
            this.conteid.Click += new System.EventHandler(this.conteid_Click);
            // 
            // txtinvisible
            // 
            this.txtinvisible.Location = new System.Drawing.Point(503, 117);
            this.txtinvisible.Name = "txtinvisible";
            this.txtinvisible.Size = new System.Drawing.Size(100, 22);
            this.txtinvisible.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtinvisible);
            this.Controls.Add(this.conteid);
            this.Controls.Add(this.nobuscar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.enrolar);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtcarrera);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtapellidom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtapellidom;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcarrera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button enrolar;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button nobuscar;
        private System.Windows.Forms.Label conteid;
        private System.Windows.Forms.TextBox txtinvisible;
    }
}

