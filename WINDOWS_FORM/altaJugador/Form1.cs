using System.Windows.Forms;

namespace altaJugador
{
    public partial class Form1 : Form
    {
        //public List<Jugador> jugadores;
        public Form1()
        {
            InitializeComponent();
            //jugadores = new List<Jugador>();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDni.Text;

            int dniParseado = int.Parse(dni);

            Jugador jugador = new Jugador(nombre, apellido, dniParseado);


            Jugador.jugadores.Add(jugador);


            //jugadores.Add(jugador);


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            //MostrarJugadores mostrarJugadores = new MostrarJugadores();
            //mostrarJugadores.Show();

            foreach (var item in Jugador.jugadores)
            {

                listBox1.Items.Add(item.NombreJugador);
                listBox1.Items.Add(item.ApellidoJugador);
                listBox1.Items.Add(item.Dni.ToString());
            }

        }
    }
}