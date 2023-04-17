using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace altaJugador
{
    public partial class MostrarJugadores : Form
    {
        public MostrarJugadores()
        {
            InitializeComponent();
        }

        private void txtMostrarNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMostrarApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMostrarDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in Jugador.jugadores)
            {

                listBox1.Items.Add(item.NombreJugador);
                listBox1.Items.Add(item.ApellidoJugador);
                listBox1.Items.Add(item.Dni.ToString());
            }

        }
    }
}
