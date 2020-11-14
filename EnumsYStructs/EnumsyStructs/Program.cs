using System;

namespace EnumsyStructs
{
    class Program
    {
        static void Main(string[] args)
        {
            var nahuel = new Persona();
            nahuel.Nombre = "Nahuel Cioffi";
            nahuel.Edad = 22;
        }
    }
    public struct Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string Nombre, int Edad)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
        }
    }


}
