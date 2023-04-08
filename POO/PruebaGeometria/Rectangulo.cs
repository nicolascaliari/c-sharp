using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGeometria
{
    internal class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;


        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;

            int baseRectangulo = Math.Abs(vertice1.X - vertice3.X);
            int alturaRectangulo = Math.Abs(vertice1.Y - vertice3.Y);

            this.vertice2 = new Punto(vertice3.X, vertice1.Y);
            this.vertice4 = new Punto(vertice1.X, vertice3.Y);

            this.area = baseRectangulo * alturaRectangulo;
            this.perimetro = (baseRectangulo + alturaRectangulo) * 2;

        }

        public float getArea()
        {
            return area;
        }
        public float GetPerimetro()
        {
            return perimetro;
        }

        public Punto GetVertice1()
        {
            return vertice1;
        }

        public Punto GetVertice2()
        {
            return vertice2;
        }

        public Punto GetVertice3()
        {
            return vertice3;
        }

        public Punto GetVertice4()
        {
            return vertice4;
        }
    }
}
