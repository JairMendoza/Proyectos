namespace Brother_ss
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.globomensaje = new System.Windows.Forms.ToolTip(this.components);
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(37, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 1);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(37, 341);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(332, 1);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // txtusuario
            // 
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Location = new System.Drawing.Point(37, 226);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(332, 19);
            this.txtusuario.TabIndex = 2;
            // 
            // txtcontra
            // 
            this.txtcontra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontra.Location = new System.Drawing.Point(37, 316);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.PasswordChar = '*';
            this.txtcontra.Size = new System.Drawing.Size(332, 19);
            this.txtcontra.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(415, 522);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip globomensaje;
        private System.Windows.Forms.ErrorProvider error;
    }
}