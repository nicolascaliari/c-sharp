using Billetes;
using System.Windows.Forms;

namespace Cotizador
{
    public partial class Form1 : Form
    {
        public bool _controloSoloLectura = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EstablecerEstadoControles(_controloSoloLectura);
            txtEuroValor.Text = "0,89";
            txtDolarValor.Text = "1";
            txtPesoValor.Text = "0,023";
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {


            float cotizacionEuro = float.Parse(txtEuroValor.Text);
            float cotizacionPeso = float.Parse(txtPesoValor.Text);

            int valorDolar = int.Parse(txtDolar.Text);
            Dolar dolar = new Dolar(valorDolar);
            dolar._cotzRespectoDolar = float.Parse(txtDolarValor.Text);
            Euro euro = new(valorDolar, cotizacionEuro);
            Peso peso = new(valorDolar, cotizacionPeso);
           

           

            Euro euroValor = (Euro)dolar;
            Peso pesoValor = (Peso)euro;


            txtDolarADolar.Text = valorDolar.ToString();
            txtDolarAPeso.Text = pesoValor.GetCantidad().ToString();
            txtDolarAEuro.Text = euroValor.GetCantidad().ToString();


        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {

            float cotizacionEuro = float.Parse(txtEuroValor.Text);
            float cotizacionPeso = float.Parse(txtPesoValor.Text);

            int valorEuro = int.Parse(txtEuro.Text);


            Euro euro = new(valorEuro, cotizacionEuro);
            Peso peso = new(valorEuro, cotizacionPeso);
            Dolar dolar = (Dolar)euro;
            peso = (Peso)euro;


            txtEuroAEuro.Text = euro.GetCantidad().ToString();
            txtEuroADolar.Text = dolar.GetCantidad().ToString();
            txtEuroAPeso.Text = peso.GetCantidad().ToString();

        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {

            float cotizacionEuro = float.Parse(txtEuroValor.Text);
            float cotizacionPeso = float.Parse(txtPesoValor.Text);
            int valorPeso = int.Parse(txtPeso.Text);

            Peso peso = new(valorPeso, cotizacionPeso);
            Euro euro = new(valorPeso, cotizacionEuro);
            Dolar dolar = (Dolar)peso;
            euro = (Euro)peso;



            txtPesoAPeso.Text = valorPeso.ToString();
            txtPesoADolar.Text = dolar.GetCantidad().ToString();
            txtPesoAEuro.Text = euro.GetCantidad().ToString();



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtEuroValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_bloqueo_Click(object sender, EventArgs e)
        {
            _controloSoloLectura = !_controloSoloLectura;
            EstablecerEstadoControles(_controloSoloLectura);

        }

        public void EstablecerEstadoControles(bool soloLectura)
        {
            txtEuroValor.ReadOnly = soloLectura;
            txtDolarValor.ReadOnly = soloLectura;
            txtPesoValor.ReadOnly = soloLectura;
        }
    }
}