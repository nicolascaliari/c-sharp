using System.Text;

namespace biblioteca
{
    public class Producto
    {
        public string codigoDeBarra;
        public string marca { get; set; }
        public float precio {  get; set; }

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.precio = precio;
            codigoDeBarra = codigo;
        }


        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }


        public static bool operator ==(Producto p1, Producto p2)
        {
            if(!(p1 is null || p2 is null)) {

                return (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
            }
            else
            {
                return false;
            }
            
        }

        public static bool operator !=(Producto p1, Producto p2)
        {

            return !(p1.marca == p2.marca);
        }


        public static bool operator ==(Producto p1, string marca)
        {
            return p1.marca == marca;
        }


        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1.marca == marca);
        }


        public static string MostrarProducto(Producto p)
        {
           StringBuilder sb = new StringBuilder();

            sb.AppendLine("=================");
            sb.AppendLine($"Codigo de barra: {p.codigoDeBarra}");
            sb.AppendLine($"Marca del producto: {p.marca}");
            sb.AppendLine($"El precio del producto es: {p.precio}");
            sb.AppendLine("=================");    

            return sb.ToString();
        }



    }
}