
namespace EnumsyStructs
{
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
