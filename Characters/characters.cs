using System;

namespace Characters
{
    public class characters
    {
        public string Nombre { get; set; }
        public string Personalidad { get; set; }
        public characters(string nombre, string personalidad)
        {
            Nombre = nombre;
            Personalidad = personalidad;

        }
    }
}
