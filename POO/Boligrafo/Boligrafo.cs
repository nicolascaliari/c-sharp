using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoArgentino
{
    internal class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color = color;
            this.tinta = tinta; 
        }

        public ConsoleColor getColor()
        {
            return this.color;
        }

        public short getTinta() { 
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {

            short nivelNuevoTinta = (short)(this.tinta + tinta);
            if(nivelNuevoTinta >= 0 && nivelNuevoTinta <= cantidadTintaMaxima) { 
                this.tinta = nivelNuevoTinta; 
            }
            else
            {
                Console.WriteLine("No se puede agregar tinta");
            }
        }


        public void Recargar()
        {
            short total = (short)(cantidadTintaMaxima - tinta);
               
            SetTinta(total);   
        
        }


            public string Pintar(int gasto, string dibujo)
            {
            string resultado;
                if (tinta >= gasto)
            {
                int tintaGastada = Math.Min(gasto, tinta);
                Console.WriteLine(tintaGastada);
                SetTinta((short)-tintaGastada);
                Console.ForegroundColor = color;
                 resultado = new string('*', tintaGastada);
           
            }
            else
            {
                resultado = "no se pudo pintar";
            }
            return resultado;
           
            }
        

    }
}
