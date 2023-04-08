using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGeometria
{
    internal class Punto
    {
        private readonly int x;
        private readonly int y;


        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X { get { return x; } }
        public int Y { get { return y; } }
    }
}
