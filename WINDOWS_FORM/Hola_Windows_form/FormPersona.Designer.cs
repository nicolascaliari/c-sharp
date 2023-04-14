namespace Hola_Windows_form
{
    partial class FormPersona
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
            lblTitulo = new Label();
            lblMnesaje = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(220, 66);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(0, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Click += label1_Click;
            // 
            // lblMnesaje
            // 
            lblMnesaje.AutoSize = true;
            lblMnesaje.Location = new Point(220, 181);
            lblMnesaje.Name = "lblMnesaje";
            lblMnesaje.Size = new Size(38, 15);
            lblMnesaje.TabIndex = 1;
            lblMnesaje.Text = "label1";
            // 
            // FormPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMnesaje);
            Controls.Add(lblTitulo);
            Name = "FormPersona";
            Text = "FormPersona";
            Load += FormPersona_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblMnesaje;
    }
}