namespace Hola_Windows_form
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
            button1 = new Button();
            lbl_ingresarNombre = new Label();
            txtBox_nombre = new TextBox();
            label1 = new Label();
            txtBox_apellido = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(304, 128);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Saludar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl_ingresarNombre
            // 
            lbl_ingresarNombre.AutoSize = true;
            lbl_ingresarNombre.Location = new Point(200, 46);
            lbl_ingresarNombre.Name = "lbl_ingresarNombre";
            lbl_ingresarNombre.Size = new Size(51, 15);
            lbl_ingresarNombre.TabIndex = 1;
            lbl_ingresarNombre.Text = "Nombre";
            lbl_ingresarNombre.Click += label1_Click;
            // 
            // txtBox_nombre
            // 
            txtBox_nombre.Location = new Point(200, 74);
            txtBox_nombre.Name = "txtBox_nombre";
            txtBox_nombre.PlaceholderText = "Ingresar nombre";
            txtBox_nombre.Size = new Size(100, 23);
            txtBox_nombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(396, 46);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Apellido";
            // 
            // txtBox_apellido
            // 
            txtBox_apellido.Location = new Point(380, 74);
            txtBox_apellido.Name = "txtBox_apellido";
            txtBox_apellido.PlaceholderText = "Ingrese apellido";
            txtBox_apellido.Size = new Size(100, 23);
            txtBox_apellido.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "programacion", "matematica", "ingles", "metodologia", "laboratorio" });
            comboBox1.Location = new Point(25, 74);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "Materia";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(txtBox_apellido);
            Controls.Add(label1);
            Controls.Add(txtBox_nombre);
            Controls.Add(lbl_ingresarNombre);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lbl_ingresarNombre;
        private TextBox txtBox_nombre;
        private Label label1;
        private TextBox txtBox_apellido;
        private ComboBox comboBox1;
    }
}