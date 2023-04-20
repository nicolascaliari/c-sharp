namespace Biblioteca
{
    public class Moto: VehiculoTerrestre
    {

        //private short _cantidadRuedas;
        //private short _cantidadPuertas;
        // private Colores color;
        private short _cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, short cilindrada, Colores color) : base(cantidadRuedas , cantidadPuertas, color)
        {
            //CantidadRuedas = cantidadRuedas;
            //CantidadPuertas = cantidadPuertas;
            Cilindrada = cilindrada;
        }

        //public short CantidadRuedas
        //{
        //    get
        //    {
        //        return _cantidadRuedas;
        //    }
        //    set
        //    {
        //        _cantidadRuedas = value;
        //    }
        //}

        //public short CantidadPuertas
        //{
        //    get
        //    {
        //        return _cantidadPuertas;
        //    }
        //    set
        //    {
        //        _cantidadPuertas = value;
        //    }
        //}

        public short Cilindrada
        {
            get
            {
                return _cilindrada;
            }
            set
            {
                _cilindrada = value;
            }
        }

    }
}