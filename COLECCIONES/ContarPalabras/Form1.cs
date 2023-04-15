using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ContarPalabras
{
    public partial class Form1 : Form
    {

        private Dictionary<string, int> diccionario;
        private List<string> palabrasLista;
        public Form1()
        {
            InitializeComponent();
            diccionario = new Dictionary<string, int>();    
        }

        private void btn_calciular_Click(object sender, EventArgs e)
        {

            ContarPalabras(txt_rich.Text);
            MessageBox.Show(Mostrar()); 

        }

        public void ContarPalabras(string texto)
        {
            char[] separacion = new char[] { ' ', ',', '.', ':', '\t' };
            palabrasLista.AddRange(texto.Split(separacion, StringSplitOptions.RemoveEmptyEntries));

            foreach (string palabra in palabrasLista)
            {
                if (!diccionario.ContainsKey(palabra) && palabra != " ")
                {
                    diccionario.Add(palabra, 1);
                }
                else
                {
                    diccionario[palabra] += 1;
                }
            }
        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            string eliminar = "";

            while (i < 3)
            {
                foreach (KeyValuePair<string, int> elemento in diccionario)
                {
                    if (diccionario.Values.Max() == elemento.Value && i < 3)
                    {
                        eliminar = elemento.Key;
                        sb.AppendLine($"{elemento.Key}   {elemento.Value}");
                        break;
                    }
                }

                if (diccionario.Remove(eliminar))
                {
                    i++;
                }
            }

            return sb.ToString();
        }
    }
}