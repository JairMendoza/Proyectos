namespace Brother_ss
{
    partial class Form7
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
            this.txteliminar = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pedro)).BeginInit();
            this.SuspendLayout();
            // 
            // pedro
            // 
            this.pedro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pedro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pedro.Location = new System.Drawing.Point(0, 223);
            this.pedro.Name = "pedro";
            this.pedro.RowTemplate.Height = 28;
            this.pedro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pedro.Size = new System.Drawing.Size(1311, 479);
            this.pedro.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Mostrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txteliminar
            // 
            this.txteliminar.Location = new System.Drawing.Point(301, 77);
            this.txteliminar.Name = "txteliminar";
            this.txteliminar.Size = new System.Drawing.Size(540, 26);
            this.txteliminar.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(899, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(351, 56);
            this.button3.TabIndex = 10;
            this.button3.Text = "Oprima el boton para insertar los datos de la tabla";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1006, 105);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 56);
            this.button4.TabIndex = 11;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 702);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txteliminar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pedro);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pedro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pedro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txteliminar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}