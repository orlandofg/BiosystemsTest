using BiosystemsTest.Clases;
using BiosystemsTest.Enums;
using System;

namespace BiosystemsTest
{
    /// <summary>
    /// Programa que simula un partido de tenis
    /// ----------------------------------------
    /// El primer argumento de la ejecución indica el modo:
    ///     '0': a 3 sets
    ///     '1': a 5 sets
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region --- COMPROBAR ARGUMENTOS DE LINEA DE COMANDOS ---
            if (args.Length == 0)
            {
                Console.WriteLine("** ERROR: hay que indicar el modo: 0 o 1");
                Console.ReadKey();
                return;
            }
            else if (args[0] != "0" && args[0] != "1")
            {
                Console.WriteLine("** ERROR: el modo debe ser: 0 = 3 sets o 1 = 5 sets");
                Console.ReadKey();
                return;
            }
            #endregion

            Console.WriteLine("Pulser <Enter> para comenzar el partido ...");
            Console.ReadKey();

            //
            // ejecucion del partido
            //
            PartidoClass partido = new((ModoJuegoEnum)int.Parse(args[0]));
            while (partido.Jugar())
            {
                Console.WriteLine(partido.GetInfo());
            }


            #region --- MOSTRAR RESULTADO DEL PARTIDO ---
            Console.WriteLine();
            Console.Write($"{partido.Jugador1.Nombre}: ({partido.Jugador1.CountSetsGanados}) ");
            for (int i = 0; i < partido.Jugador1.Puntuacion.Sets.Count; i++)
            {
                Console.Write($"{partido.Jugador1.Puntuacion.Sets[i].CountJuegosGanados} ");
            }

            Console.WriteLine();
            Console.Write($"{partido.Jugador2.Nombre}: ({partido.Jugador2.CountSetsGanados}) ");
            for (int i = 0; i < partido.Jugador2.Puntuacion.Sets.Count; i++)
            {
                Console.Write($"{partido.Jugador2.Puntuacion.Sets[i].CountJuegosGanados} ");
            }
            Console.WriteLine();

            if (partido.Jugador1.EsGanador)
            {
                Console.WriteLine($"GANADOR: {partido.Jugador1.Nombre}");
            }
            else
            {
                Console.WriteLine($"GANADOR: {partido.Jugador2.Nombre}");
            }
            #endregion

            Console.WriteLine("Pulser <Enter> para finalizar ...");
            Console.ReadKey();
        }
    }
}
