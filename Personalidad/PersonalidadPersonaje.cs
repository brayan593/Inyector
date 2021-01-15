using System;
using Characters;
using Interfaces;

namespace Personalidad
{
    public class PersonalidadPersonaje: Interfazpersonalidad    
    {
        public bool escoger(characters characters)
        {
            Console.WriteLine("Ha escogido el personaje {0} con la personalidad: {1}", characters.Nombre, characters.Personalidad);
            return true;
        }
    }
}
