using System;
using Interfaces;
using Characters;
using Negocio;
using Personalidad;
using Ninject;

namespace Inyector
{
    class logicprogram
    {
        static void Main(string[] args)
        {
            var opcionUsuario = 0;
            var kernel = new StandardKernel();

            Console.WriteLine("Escoja su personaje, con su respectiva personalidad!");
            Console.WriteLine("1.- Slingshot - Optimista");
            Console.WriteLine("2.- Enforcer - Perceptivo");
            Console.WriteLine("3.- Soldier - independiente");
            Console.WriteLine("4.- Blackwolf - hábil");
            Console.WriteLine("5.- Dragomir - líder");
            Console.WriteLine("6.- Maximus - poderoso");
            opcionUsuario = int.Parse(Console.ReadLine());

            if (opcionUsuario == 1)
            {
                characters character1 = new characters("Slingshot", "Optimista");
                kernel.Bind<Interfazpersonalidad>().To<PersonalidadPersonaje>();
                var jugador1 = kernel.Get<Personality>();
                jugador1.EscogerPersonalidad(character1);
            }
            if (opcionUsuario == 2)
            {
                characters character2 = new characters("Enforcer", "Perceptivo");
                kernel.Bind<Interfazpersonalidad>().To<PersonalidadPersonaje>();
                var jugador2 = kernel.Get<Personality>();
                jugador2.EscogerPersonalidad(character2);
            }
            if (opcionUsuario == 3)
            {
                characters character3 = new characters("Soldier", "independiente");
                kernel.Bind<Interfazpersonalidad>().To<PersonalidadPersonaje>();
                var jugador3 = kernel.Get<Personality>();
                jugador3.EscogerPersonalidad(character3);
            }
            if (opcionUsuario == 4)
            {
                characters character4 = new characters("Blackwolf", "hábil");
                kernel.Bind<Interfazpersonalidad>().To<PersonalidadPersonaje>();
                var jugador4 = kernel.Get<Personality>();
                jugador4.EscogerPersonalidad(character4);
            }
            if (opcionUsuario == 5)
            {
                characters character5 = new characters("Dragomir", "líder");
                kernel.Bind<Interfazpersonalidad>().To<PersonalidadPersonaje>();
                var jugador5 = kernel.Get<Personality>();
                jugador5.EscogerPersonalidad(character5);
            }
            if (opcionUsuario == 6)
            {
                characters character6 = new characters("Maximus", "poderoso");
                kernel.Bind<Interfazpersonalidad>().To<PersonalidadPersonaje>();
                var jugador6 = kernel.Get<Personality>();
                jugador6.EscogerPersonalidad(character6);
            }

        }
    }
}
