using System.Text;

namespace Hola_Windows_form
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public bool Validar()
        {

            bool valido = true;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Se deben completar todos los campos");

            if(string.IsNullOrEmpty(txtBox_nombre.Text))
            {
                valido = false;
            }

            if (string.IsNullOrEmpty(txtBox_apellido.Text))
            {
                valido = false;
            }


            if(valido == false )
            {
                MessageBox.Show("Ingresaste algo mas");
            }

            return valido;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if(Validar() == false)
            {
                MessageBox.Show("Algo salio mal");
            }
            else
            {
                string titulo = "Hola windows form";
                string apellido = $"Soy {txtBox_nombre.Text} {txtBox_apellido.Text} y mi materia favorita es {comboBox1.Text}";

                FormPersona form = new FormPersona(titulo, apellido);

                form.ShowDialog();
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Programacion");
            comboBox1.Items.Add("pepe");
        }
    }
}