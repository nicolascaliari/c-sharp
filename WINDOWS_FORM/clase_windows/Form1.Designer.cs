namespace clase_windows
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
            btn_mostrar = new Button();
            btn_guardar = new Button();
            txtBox_nombre = new TextBox();
            SuspendLayout();
            // 
            // btn_mostrar
            // 
            btn_mostrar.Location = new Point(333, 240);
            btn_mostrar.Name = "btn_mostrar";
            btn_mostrar.Size = new Size(75, 23);
            btn_mostrar.TabIndex = 0;
            btn_mostrar.Text = "Mostrar lista";
            btn_mostrar.UseVisualStyleBackColor = true;
            btn_mostrar.Click += btn_mostrar_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(492, 240);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(75, 23);
            btn_guardar.TabIndex = 1;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // txtBox_nombre
            // 
            txtBox_nombre.Location = new Point(400, 169);
            txtBox_nombre.Name = "txtBox_nombre";
            txtBox_nombre.PlaceholderText = "Nombre";
            txtBox_nombre.Size = new Size(100, 23);
            txtBox_nombre.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 558);
            Controls.Add(txtBox_nombre);
            Controls.Add(btn_guardar);
            Controls.Add(btn_mostrar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_mostrar;
        private Button btn_guardar;
        private TextBox txtBox_nombre;
    }
}