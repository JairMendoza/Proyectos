namespace Brother_ss
{
    partial class Form11
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
            this.txtconsulta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pedro)).BeginInit();
            this.SuspendLayout();
            // 
            // pedro
            // 
            this.pedro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pedro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pedro.Location = new System.Drawing.Point(0, 166);
            this.pedro.Name = "pedro";
            this.pedro.RowTemplate.Height = 28;
            this.pedro.Size = new System.Drawing.Size(1252, 534);
            this.pedro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese nombre de la consulta:";
            // 
            // txtconsulta
            // 
            this.txtconsulta.Location = new System.Drawing.Point(387, 50);
            this.txtconsulta.Name = "txtconsulta";
            this.txtconsulta.Size = new System.Drawing.Size(560, 26);
            this.txtconsulta.TabIndex = 2;
            this.txtconsulta.TextChanged += new System.EventHandler(this.txtconsulta_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1012, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 700);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtconsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pedro);
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pedro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pedro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtconsulta;
        private System.Windows.Forms.Button button1;
    }
}