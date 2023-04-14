using ClassLibrary1;

namespace registrate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string nombre = txtBox_nombre.Text;
            string direccion = txtBox_direccion.Text;
            int edad = int.Parse(numericUpDown1.Text);
            string? genero = groupBox2.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked)?.Text;
            string pais = listBox1.Text;
            string[] cursos = groupBox3.Controls.OfType<CheckBox>().Where(cb => cb.Checked).Select(cb => cb.Text).ToArray();


            Ingresante ingresante = new Ingresante(nombre, direccion, genero, pais, cursos, edad);

            MessageBox.Show(ingresante.Mostrar());

        }
    }
}