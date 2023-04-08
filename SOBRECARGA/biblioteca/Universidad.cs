namespace biblioteca
{
    public class Universidad
    {
        public string NombreUniversidad { get; set; }

        public Universidad(string NombreUniversidad)
        {
            this.NombreUniversidad = NombreUniversidad;
        }


        public static explicit operator string(Universidad universidad) {
            return universidad.NombreUniversidad.ToString();
        }



      //  public static int operator -(Estudiante estudianteUno, Estudiante estudianteDos)
      // {
      //      return estudianteUno.NombreEstudiante - estudianteDos.NombreEstudiante;
      //}
    }
}