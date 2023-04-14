using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase_windows
{
    public partial class FormMostrarListacs : Form
    {
        private Persona _persona;


        public Persona Persona
        {
            get { return _persona; }
            set { _persona = value; }
        }

        public FormMostrarListacs()
        {
            InitializeComponent();
        }


        private void FormMostrarListacs_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
           
        }
    }
}
