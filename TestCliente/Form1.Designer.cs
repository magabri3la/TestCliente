namespace TestCliente
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNumPlaca = new TextBox();
            btnConsultar = new Button();
            label2 = new Label();
            lblPropietario = new Label();
            lblMulta = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 49);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese Placa:";
            // 
            // txtNumPlaca
            // 
            txtNumPlaca.Location = new Point(132, 46);
            txtNumPlaca.Name = "txtNumPlaca";
            txtNumPlaca.Size = new Size(113, 23);
            txtNumPlaca.TabIndex = 1;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(272, 46);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 120);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "Propietario:";
            // 
            // lblPropietario
            // 
            lblPropietario.BorderStyle = BorderStyle.FixedSingle;
            lblPropietario.Location = new Point(132, 120);
            lblPropietario.Name = "lblPropietario";
            lblPropietario.Size = new Size(299, 29);
            lblPropietario.TabIndex = 4;
            // 
            // lblMulta
            // 
            lblMulta.BorderStyle = BorderStyle.FixedSingle;
            lblMulta.Location = new Point(132, 168);
            lblMulta.Name = "lblMulta";
            lblMulta.Size = new Size(146, 29);
            lblMulta.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 169);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 5;
            label5.Text = "Multa:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 304);
            Controls.Add(lblMulta);
            Controls.Add(label5);
            Controls.Add(lblPropietario);
            Controls.Add(label2);
            Controls.Add(btnConsultar);
            Controls.Add(txtNumPlaca);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consumiendo WEB Services desde IIS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumPlaca;
        private Button btnConsultar;
        private Label label2;
        private Label lblPropietario;
        private Label lblMulta;
        private Label label5;
    }
}