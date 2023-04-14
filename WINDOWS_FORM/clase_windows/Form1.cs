using System.Text;

namespace clase_windows
{
    public partial class Form1 : Form
    {
        private Persona _persona;

        public Persona persona
        {
            get { return _persona; }
            set { _persona = value; }

        }

        List<Persona> lista = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
        }



        private void btn_mostrar_Click(object sender, EventArgs e)
        {

            var formPersona = new FormMostrarListacs();

            if (formPersona.ShowDialog() == DialogResult.OK)
            {
                // tengo que recibir persona
                lista.Add(formPersona.Persona);
                StringBuilder sb = new StringBuilder();
                foreach (Persona persona in lista)
                {
                    sb.AppendLine($"Nombre: {persona.Nombre} y legajo: {persona.Legajo}");
                }
                label1.Text = sb.ToString();
            }
            else
            {
                MessageBox.Show("sali mal");
            }
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }
    }
}