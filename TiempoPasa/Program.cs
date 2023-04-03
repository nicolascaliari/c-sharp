namespace TiempoPasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su fecha de nacimiento: ");
            DateTime fecha;
           bool fechaNacimiento = DateTime.TryParse(Console.ReadLine(), out fecha);
            
           // Console.WriteLine(fecha);    
            if(fechaNacimiento)
            {
                int diasVividos = (int)(DateTime.Today.Subtract(fecha).TotalDays);
                Console.WriteLine($"Usted a vivido esta cantidad de dias :{diasVividos}");
            }
            else
            {
                Console.WriteLine("Ingreso mal la fehca");
            }
           
        }


    public static void CalcularAniosVividos(DateTime FechaInicio, DateTime FechaFin)
        {
            
        }
    }
}