using System;
using Characters;
using Interfaces;

namespace Negocio
{
    public class Personality
    {
        Interfazpersonalidad Personalidad;

        public Personality(Interfazpersonalidad Personalidad)
        {
            this.Personalidad = Personalidad;
        }
        public void EscogerPersonalidad(characters characters)
        {
            Personalidad.escoger(characters);
        }
    }
}
