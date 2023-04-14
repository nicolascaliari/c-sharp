namespace ClassLibrary4
{
    public class NumeroBinario
    {
        private string numeroBinario;

        private NumeroBinario(string numero)
        {
            numeroBinario = numero;
        }


        public static implicit operator NumeroBinario(string palabra)
        {
            return new NumeroBinario(palabra);
        }




        public static explicit operator string(NumeroBinario numero)
        {
            return numero.numeroBinario;
        }


        public static double operator +(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return numeroBinario + numeroDecimal;
        }

        public static double operator -(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return numeroBinario - numeroDecimal;
        }

        public static bool operator ==(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return (numeroBinario == numeroDecimal);
        }

        public static bool operator !=(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return !(numeroBinario == numeroDecimal);
        }
    }
}