namespace Brother_ss
{
    partial class Form12
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
            this.label1 = new System.Windows.Forms.Label();
            this.txteliminar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pedro)).BeginInit();
            this.SuspendLayout();
            // 
            // pedro
            // 
            this.pedro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pedro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pedro.Location = new System.Drawing.Point(0, 179);
            this.pedro.Name = "pedro";
            this.pedro.RowTemplate.Height = 28;
            this.pedro.Size = new System.Drawing.Size(1284, 530);
            this.pedro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el ID que desea eliminar:";
            // 
            // txteliminar
            // 
            this.txteliminar.Location = new System.Drawing.Point(451, 66);
            this.txteliminar.Name = "txteliminar";
            this.txteliminar.Size = new System.Drawing.Size(658, 26);
            this.txteliminar.TabIndex = 2;
            this.txteliminar.TextChanged += new System.EventHandler(this.txteliminar_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Mostrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 709);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txteliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pedro);
            this.Name = "Form12";
            this.Text = "Form12";
            ((System.ComponentModel.ISupportInitialize)(this.pedro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pedro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txteliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}