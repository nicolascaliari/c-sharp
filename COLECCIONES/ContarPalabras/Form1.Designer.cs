namespace ContarPalabras
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
            txt_rich = new RichTextBox();
            btn_calciular = new Button();
            SuspendLayout();
            // 
            // txt_rich
            // 
            txt_rich.Location = new Point(213, 45);
            txt_rich.Name = "txt_rich";
            txt_rich.Size = new Size(336, 284);
            txt_rich.TabIndex = 0;
            txt_rich.Text = "";
            // 
            // btn_calciular
            // 
            btn_calciular.Location = new Point(607, 371);
            btn_calciular.Name = "btn_calciular";
            btn_calciular.Size = new Size(75, 23);
            btn_calciular.TabIndex = 1;
            btn_calciular.Text = "Calcular";
            btn_calciular.UseVisualStyleBackColor = true;
            btn_calciular.Click += btn_calciular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_calciular);
            Controls.Add(txt_rich);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txt_rich;
        private Button btn_calciular;
    }
}