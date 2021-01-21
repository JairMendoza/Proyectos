namespace Brother_ss
{
    partial class Form9
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.globomensaje = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(469, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Costo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(831, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(247, 154);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(802, 26);
            this.txtnombre.TabIndex = 6;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(247, 221);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(802, 26);
            this.txtmarca.TabIndex = 7;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(214, 294);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(218, 26);
            this.txtprecio.TabIndex = 8;
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(570, 295);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(234, 26);
            this.txtcosto.TabIndex = 9;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(975, 293);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(235, 26);
            this.txtcantidad.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "Registrar Producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 633);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.ToolTip globomensaje;
    }
}