namespace Billetes
{
    internal class Euro
    {
        public double cantidad;
        public static double cotzRespectoDolar { get; set; } 
        

        static Euro()
        {
            cotzRespectoDolar = 1;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion): this(cantidad)
        {
            cotzRespectoDolar = cotizacion;
        }
    }
}