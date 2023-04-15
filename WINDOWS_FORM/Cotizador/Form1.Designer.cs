namespace Cotizador
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEuro = new TextBox();
            txtDolar = new TextBox();
            txtPeso = new TextBox();
            btnConvertEuro = new Button();
            btnConvertDolar = new Button();
            btnConvertPeso = new Button();
            txtEuroAEuro = new TextBox();
            txtDolarAEuro = new TextBox();
            txtPesoAEuro = new TextBox();
            txtEuroADolar = new TextBox();
            txtDolarADolar = new TextBox();
            txtPesoADolar = new TextBox();
            txtEuroAPeso = new TextBox();
            txtDolarAPeso = new TextBox();
            txtPesoAPeso = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtEuroValor = new TextBox();
            txtDolarValor = new TextBox();
            txtPesoValor = new TextBox();
            btn_bloqueo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 110);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Euro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 165);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Dolar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 215);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "Peso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 42);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "Cotizacion";
            label4.Click += label4_Click;
            // 
            // txtEuro
            // 
            txtEuro.Location = new Point(74, 107);
            txtEuro.Name = "txtEuro";
            txtEuro.Size = new Size(100, 23);
            txtEuro.TabIndex = 4;
            // 
            // txtDolar
            // 
            txtDolar.Location = new Point(74, 162);
            txtDolar.Name = "txtDolar";
            txtDolar.Size = new Size(100, 23);
            txtDolar.TabIndex = 5;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(74, 212);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 6;
            // 
            // btnConvertEuro
            // 
            btnConvertEuro.Location = new Point(198, 110);
            btnConvertEuro.Name = "btnConvertEuro";
            btnConvertEuro.Size = new Size(75, 23);
            btnConvertEuro.TabIndex = 7;
            btnConvertEuro.Text = "---->";
            btnConvertEuro.UseVisualStyleBackColor = true;
            btnConvertEuro.Click += btnConvertEuro_Click;
            // 
            // btnConvertDolar
            // 
            btnConvertDolar.Location = new Point(198, 165);
            btnConvertDolar.Name = "btnConvertDolar";
            btnConvertDolar.Size = new Size(75, 23);
            btnConvertDolar.TabIndex = 8;
            btnConvertDolar.Text = "---->";
            btnConvertDolar.UseVisualStyleBackColor = true;
            btnConvertDolar.Click += btnConvertDolar_Click;
            // 
            // btnConvertPeso
            // 
            btnConvertPeso.Location = new Point(198, 212);
            btnConvertPeso.Name = "btnConvertPeso";
            btnConvertPeso.Size = new Size(75, 23);
            btnConvertPeso.TabIndex = 9;
            btnConvertPeso.Text = "---->";
            btnConvertPeso.UseVisualStyleBackColor = true;
            btnConvertPeso.Click += btnConvertPeso_Click;
            // 
            // txtEuroAEuro
            // 
            txtEuroAEuro.Location = new Point(298, 107);
            txtEuroAEuro.Name = "txtEuroAEuro";
            txtEuroAEuro.Size = new Size(100, 23);
            txtEuroAEuro.TabIndex = 10;
            // 
            // txtDolarAEuro
            // 
            txtDolarAEuro.Location = new Point(298, 166);
            txtDolarAEuro.Name = "txtDolarAEuro";
            txtDolarAEuro.Size = new Size(100, 23);
            txtDolarAEuro.TabIndex = 11;
            // 
            // txtPesoAEuro
            // 
            txtPesoAEuro.Location = new Point(298, 215);
            txtPesoAEuro.Name = "txtPesoAEuro";
            txtPesoAEuro.Size = new Size(100, 23);
            txtPesoAEuro.TabIndex = 12;
            // 
            // txtEuroADolar
            // 
            txtEuroADolar.Location = new Point(422, 107);
            txtEuroADolar.Name = "txtEuroADolar";
            txtEuroADolar.Size = new Size(100, 23);
            txtEuroADolar.TabIndex = 13;
            // 
            // txtDolarADolar
            // 
            txtDolarADolar.Location = new Point(422, 166);
            txtDolarADolar.Name = "txtDolarADolar";
            txtDolarADolar.Size = new Size(100, 23);
            txtDolarADolar.TabIndex = 14;
            // 
            // txtPesoADolar
            // 
            txtPesoADolar.Location = new Point(422, 215);
            txtPesoADolar.Name = "txtPesoADolar";
            txtPesoADolar.Size = new Size(100, 23);
            txtPesoADolar.TabIndex = 15;
            // 
            // txtEuroAPeso
            // 
            txtEuroAPeso.Location = new Point(542, 107);
            txtEuroAPeso.Name = "txtEuroAPeso";
            txtEuroAPeso.Size = new Size(100, 23);
            txtEuroAPeso.TabIndex = 16;
            // 
            // txtDolarAPeso
            // 
            txtDolarAPeso.Location = new Point(542, 165);
            txtDolarAPeso.Name = "txtDolarAPeso";
            txtDolarAPeso.Size = new Size(100, 23);
            txtDolarAPeso.TabIndex = 17;
            // 
            // txtPesoAPeso
            // 
            txtPesoAPeso.Location = new Point(542, 215);
            txtPesoAPeso.Name = "txtPesoAPeso";
            txtPesoAPeso.Size = new Size(100, 23);
            txtPesoAPeso.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(336, 78);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 19;
            label5.Text = "Euro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(462, 78);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 20;
            label6.Text = "Dolar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(574, 78);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 21;
            label7.Text = "Peso";
            // 
            // txtEuroValor
            // 
            txtEuroValor.Location = new Point(298, 33);
            txtEuroValor.Name = "txtEuroValor";
            txtEuroValor.Size = new Size(100, 23);
            txtEuroValor.TabIndex = 22;
            txtEuroValor.TextChanged += txtEuroValor_TextChanged;
            // 
            // txtDolarValor
            // 
            txtDolarValor.Location = new Point(422, 34);
            txtDolarValor.Name = "txtDolarValor";
            txtDolarValor.Size = new Size(100, 23);
            txtDolarValor.TabIndex = 23;
            // 
            // txtPesoValor
            // 
            txtPesoValor.Location = new Point(542, 34);
            txtPesoValor.Name = "txtPesoValor";
            txtPesoValor.Size = new Size(100, 23);
            txtPesoValor.TabIndex = 24;
            // 
            // btn_bloqueo
            // 
            btn_bloqueo.Location = new Point(198, 38);
            btn_bloqueo.Name = "btn_bloqueo";
            btn_bloqueo.Size = new Size(75, 23);
            btn_bloqueo.TabIndex = 25;
            btn_bloqueo.Text = "cambiar";
            btn_bloqueo.UseVisualStyleBackColor = true;
            btn_bloqueo.Click += btn_bloqueo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_bloqueo);
            Controls.Add(txtPesoValor);
            Controls.Add(txtDolarValor);
            Controls.Add(txtEuroValor);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPesoAPeso);
            Controls.Add(txtDolarAPeso);
            Controls.Add(txtEuroAPeso);
            Controls.Add(txtPesoADolar);
            Controls.Add(txtDolarADolar);
            Controls.Add(txtEuroADolar);
            Controls.Add(txtPesoAEuro);
            Controls.Add(txtDolarAEuro);
            Controls.Add(txtEuroAEuro);
            Controls.Add(btnConvertPeso);
            Controls.Add(btnConvertDolar);
            Controls.Add(btnConvertEuro);
            Controls.Add(txtPeso);
            Controls.Add(txtDolar);
            Controls.Add(txtEuro);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEuro;
        private TextBox txtDolar;
        private TextBox txtPeso;
        private Button btnConvertEuro;
        private Button btnConvertDolar;
        private Button btnConvertPeso;
        private TextBox txtEuroAEuro;
        private TextBox txtDolarAEuro;
        private TextBox txtPesoAEuro;
        private TextBox txtEuroADolar;
        private TextBox txtDolarADolar;
        private TextBox txtPesoADolar;
        private TextBox txtEuroAPeso;
        private TextBox txtDolarAPeso;
        private TextBox txtPesoAPeso;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtEuroValor;
        private TextBox txtDolarValor;
        private TextBox txtPesoValor;
        private Button btn_bloqueo;
    }
}