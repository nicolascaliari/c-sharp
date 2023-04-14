namespace registrate
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
            groupBox1 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            txtBox_direccion = new TextBox();
            label1 = new Label();
            txtBox_nombre = new TextBox();
            groupBox2 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox3 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            listBox1 = new ListBox();
            btn_ingresar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBox_direccion);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtBox_nombre);
            groupBox1.Location = new Point(50, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(223, 182);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles del Usuario";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(99, 141);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(100, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 149);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 1;
            label3.Text = "Edad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 95);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Direccion";
            // 
            // txtBox_direccion
            // 
            txtBox_direccion.Location = new Point(99, 87);
            txtBox_direccion.Name = "txtBox_direccion";
            txtBox_direccion.Size = new Size(100, 23);
            txtBox_direccion.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 42);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtBox_nombre
            // 
            txtBox_nombre.Location = new Point(99, 34);
            txtBox_nombre.Name = "txtBox_nombre";
            txtBox_nombre.Size = new Size(100, 23);
            txtBox_nombre.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Location = new Point(348, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(172, 140);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Genero";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(39, 100);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(81, 19);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "No binario";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(39, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(80, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Masculino";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(39, 61);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Femenino";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBox3);
            groupBox3.Controls.Add(checkBox1);
            groupBox3.Controls.Add(checkBox2);
            groupBox3.Location = new Point(348, 234);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(172, 131);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cursos";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(39, 106);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(77, 19);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "Javascript";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(39, 31);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(41, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "C#";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(39, 70);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(53, 19);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "C ++";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Argentina", "Chile", "Uruguay" });
            listBox1.Location = new Point(50, 271);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(223, 94);
            listBox1.TabIndex = 0;
            // 
            // btn_ingresar
            // 
            btn_ingresar.Location = new Point(445, 398);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(75, 23);
            btn_ingresar.TabIndex = 3;
            btn_ingresar.Text = "Ingresar";
            btn_ingresar.UseVisualStyleBackColor = true;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_ingresar);
            Controls.Add(listBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label label2;
        private TextBox txtBox_direccion;
        private Label label1;
        private TextBox txtBox_nombre;
        private GroupBox groupBox2;
        private RadioButton radioButton3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox3;
        private CheckBox checkBox3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private ListBox listBox1;
        private Button btn_ingresar;
    }
}