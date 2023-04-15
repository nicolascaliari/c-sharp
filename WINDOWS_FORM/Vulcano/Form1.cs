using Temperaturas;


namespace Vulcano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_fahrenheit_Click(object sender, EventArgs e)
        {
            int valorFahrenheit = int.Parse(txt_fahrenheit.Text);

            txt_fahrenheitAkelvin.Text = Conversor.ConvertirFahrenheitAKelvin(valorFahrenheit).ToString();
            txt_fahrenheitAcelsius.Text = Conversor.ConvertirFahrenheitAClesius(valorFahrenheit).ToString();
            txt_fahrenheitAfarenheit.Text = valorFahrenheit.ToString();
        }

        private void btn_celsius_Click(object sender, EventArgs e)
        {
            int valorCelsius = int.Parse(txt_celsius.Text);

            txt_celsiusAfahrenheit.Text = Conversor.ConvertirCelsiusAFahrenheit(valorCelsius).ToString();
            txt_celsiusAcelsius.Text = valorCelsius.ToString();
            txt_celsiusAkelvin.Text = Conversor.ConvertirCelsiusAKelvin(valorCelsius).ToString();

        }

        private void btn_kelvin_Click(object sender, EventArgs e)
        {
            int valorKelvin = int.Parse(txt_kelvin.Text);

            txt_kelvinAkelvin.Text = valorKelvin.ToString();
            txt_kelvinAfahrenheit.Text = Conversor.ConvertirKelvinAFahrenheit(valorKelvin).ToString();
            txt_kelvinAcelsius.Text = Conversor.ConvertirKelvinACelsius(valorKelvin).ToString();

        }
    }
}