using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAlCliente
{
    public class PuestoAtencion
    {

        public enum Puesto
        {
            Caja1, Caja2
        }


        private int numeroActual;
        private Puesto puesto;


        public int NumeroActual
        {
            get { return this.numeroActual; }
        }

        private PuestoAtencion()
        {
            this.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }



        public bool Atender(Cliente cli)
        {
            System.Threading.Thread.Sleep(2000);
            return true;
        }
    }
}
