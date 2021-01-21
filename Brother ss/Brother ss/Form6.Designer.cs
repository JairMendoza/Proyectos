namespace Brother_ss
{
    partial class Form6
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
            this.txtconsulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pedro)).BeginInit();
            this.SuspendLayout();
            // 
            // pedro
            // 
            this.pedro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pedro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pedro.Location = new System.Drawing.Point(0, 169);
            this.pedro.Name = "pedro";
            this.pedro.RowTemplate.Height = 28;
            this.pedro.Size = new System.Drawing.Size(1230, 499);
            this.pedro.TabIndex = 0;
            // 
            // txtconsulta
            // 
            this.txtconsulta.Location = new System.Drawing.Point(268, 64);
            this.txtconsulta.Name = "txtconsulta";
            this.txtconsulta.Size = new System.Drawing.Size(727, 26);
            this.txtconsulta.TabIndex = 1;
            this.txtconsulta.TextChanged += new System.EventHandler(this.txtconsulta_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese la Busqueda:";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 668);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtconsulta);
            this.Controls.Add(this.pedro);
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.pedro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pedro;
        private System.Windows.Forms.TextBox txtconsulta;
        private System.Windows.Forms.Label label1;
    }
}