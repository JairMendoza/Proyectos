namespace Brother_ss
{
    partial class Form13
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pedro = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pedro)).BeginInit();
            this.SuspendLayout();
            // 
            // pedro
            // 
            this.pedro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pedro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pedro.Location = new System.Drawing.Point(0, 211);
            this.pedro.Name = "pedro";
            this.pedro.RowTemplate.Height = 28;
            this.pedro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pedro.Size = new System.Drawing.Size(1273, 483);
            this.pedro.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "Mostrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(307, 24);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(72, 26);
            this.txtid.TabIndex = 3;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(307, 71);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(257, 26);
            this.txtnombre.TabIndex = 4;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(307, 125);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(257, 26);
            this.txtmarca.TabIndex = 5;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(587, 24);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(257, 26);
            this.txtprecio.TabIndex = 6;
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(587, 71);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(257, 26);
            this.txtcosto.TabIndex = 7;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(587, 125);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(257, 26);
            this.txtcantidad.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(870, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(351, 56);
            this.button3.TabIndex = 9;
            this.button3.Text = "Oprima el boton para insertar los datos de la tabla";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(966, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 56);
            this.button4.TabIndex = 10;
            this.button4.Text = "Actualizar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 694);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pedro);
            this.Name = "Form13";
            this.Text = "Form13";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pedro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pedro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}