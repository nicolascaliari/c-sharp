using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hola_Windows_form
{
    public partial class FormPersona : Form
    {
        private Persona _persona;

        public Persona persona
        {
            get { return _persona; }
            set { _persona = value; }

        }
        public FormPersona(string titulo, string mensaje)
        {
            InitializeComponent();
            lblTitulo.Text = titulo;
            lblMnesaje.Text = mensaje;


        }
        private void CerrarFormulario()
        {
            DialogResult = DialogResult.Cancel;
        }


        private void CerrarFormulario(DialogResult dg)
        {
            DialogResult = dg;
        }


        private void btn_cargar_Click(object sender, EventArgs e)
        {
            _persona = new Persona("juan", 123);
            CerrarFormulario(DialogResult.OK);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void txtBox_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_legajo_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormPersona_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }
    }
}
