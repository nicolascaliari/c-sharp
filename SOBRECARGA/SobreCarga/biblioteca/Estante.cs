using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class Estante
    {
       private Producto[] productos;
        private int ubicacionEstante;
        
        public Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];  
        }

        public Estante(int capacidad, int ubicacionEstante)
        {
            this.productos = new Producto[capacidad];
            this.ubicacionEstante = ubicacionEstante;
        }

        public static bool operator ==(Estante e, Producto p)
        {
          
            foreach (Producto item in e.productos) {
                
                Console.WriteLine(item);    
                if(item == p)
                {
                    return true;
                }
            }
            return false;   
        }

        public static bool operator +(Estante e, Producto p)
        {
            if (e is not null)
            {
                for(int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            return e - p;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }  


        public Producto[] GetProductos()
        {
            return productos;
        }

        public static string MostrarEstante(Estante e)
        {
            string cadena = $"Ubicacion: {e.ubicacionEstante}";

            foreach (Producto item in e.productos)
            {
                if(!(item is null))
                {
                    cadena += Producto.MostrarProducto(item);
                }
                
            }

            return cadena;
        }
    }
}
