namespace Cotizador
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            string valorDolar = txtDolar.Text;


            txtDolarADolar.Text = valorDolar;   

        }
    }
}