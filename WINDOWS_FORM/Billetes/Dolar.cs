namespace Billetes
{
    public class Dolar
    {
        public double Cantidad
        {
            get => _cantidad;
            set => _cantidad = value;
        }
        private double _cantidad;


        //=======================
        public static double CotzRespectoDolar
        {
            get => _cotzRespectoDolar;
            set => _cotzRespectoDolar = value;
        }
        private static double _cotzRespectoDolar;

        static Dolar()
        {
            Dolar._cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            _cantidad = cantidad;
        }

        //En resumen, las sobrecargas implícitas permiten la conversión automática entre objetos
        //del mismo tipo, mientras que las sobrecargas explícitas permiten la conversión entre objetos
        //de tipos diferentes, pero solo de manera explícita.
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d._cantidad * Euro.cotzRespectoDolar);
        }

        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d._cantidad * Peso.cotzRespectoDolar);
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        //=======================

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d._cantidad == e.cantidad);
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d._cantidad == p.cantidad);
        }


        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1._cantidad == d2._cantidad);
        }


        //=======================================

        public static bool operator ==(Dolar d, Euro e)
        {
            return d._cantidad == e.cantidad;
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            return d._cantidad == p.cantidad;
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1._cantidad == d2._cantidad;
        }


        //===========================================

        //public static bool operator -(Dolar d, Euro p)
        //{
        //    return
        //}

        //public static bool operator -(Dolar d, Peso p)
        //{
        //    return
        //}
    }
}