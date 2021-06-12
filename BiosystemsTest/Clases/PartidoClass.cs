using BiosystemsTest.Enums;
using System;

namespace BiosystemsTest.Clases
{
    /// <summary>
    /// Ejecuta una simulación de un partido de tenis individual. Los juegos se suceden, ganando aleatoriamente uno de los jugadores, 
    /// hasta que termina el partido aplicando las reglas indicadas
    /// </summary>
    public class PartidoClass
    {
        private const int LIMITE_PUNTOS = 10000;

        private readonly Random rnd;
        private readonly int setGanadores;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modo">Tipo de partido: 3 sets / 5 sets</param>
        /// <param name="nombre1">Nombre del primer jugador (para seguimiento)</param>
        /// <param name="nombre2">Nombre del segundo jugador</param>
        public PartidoClass(ModoJuegoEnum modo, string nombre1 = "Jugador 1", string nombre2 = "Jugador 2")
        {
            Modo = modo;
            Jugador1 = new(nombre1);
            Jugador2 = new(nombre2);
            rnd = new Random();

            setGanadores = Modo == ModoJuegoEnum.TresSets ? 2 : 3;
        }

        public ModoJuegoEnum Modo { get; private set; }
        public JugadorClass Jugador1 { get; private set; }
        public JugadorClass Jugador2 { get; private set; }

        // jugar un punto:
        //  devuelve 'true' si el partido debe continuar
        public bool Jugar()
        {
            if (rnd.Next(0, 2) == 0)
            {
                Jugada(Jugador1);
            }
            else
            {
                Jugada(Jugador2);
            }
            return !EsFinPartido();
        }

        public string GetInfo()
        {
            return $"{Jugador1.GetInfo()}\r\n{Jugador2.GetInfo()}";
        }

        /// <summary>
        /// Acciones a realizar al acabar un punto
        /// </summary>
        /// <param name="ganador">jugador ganador del punto</param>
        private void Jugada(JugadorClass ganador)
        {
            JugadorClass perdedor = ganador.Equals(Jugador1) ? Jugador2 : Jugador1;

            perdedor.Pierde();
            if (ganador.Gana())
            {
                if (EsPuntoGanador())
                {
                    ganador.CurrentSet.CurrentJuego.EsGanador = true;

                    if (EsSetGanador())
                    {
                        ganador.CurrentSet.EsGanador = true;

                        if (EsPartidoGanador(ganador))
                        {
                            ganador.EsGanador = true;
                            return;
                        }
                        AddSet();
                    }
                    AddJuego();
                }
            }
        }

        private void AddSet()
        {
            Jugador1.AddSet();
            Jugador2.AddSet();
        }

        private void AddJuego()

        {
            Jugador1.AddJuego();
            Jugador2.AddJuego();
        }

        #region --- COMPROBACION DE GANADORES ---
        //
        // Comprobar si se ha acabado el juego
        //
        private bool EsPuntoGanador()
        {
            return Math.Abs(Jugador1.CurrentSet.CurrentPunto.Valor - Jugador2.CurrentSet.CurrentPunto.Valor) > 1;
        }

        //
        // Comprobar si se ha acabado el set
        //
        private bool EsSetGanador()
        {
            return (Jugador1.CurrentSet.CountJuegosGanados >= 6 || Jugador2.CurrentSet.CountJuegosGanados >= 6)
                && Math.Abs(Jugador1.CurrentSet.CountJuegosGanados - Jugador2.CurrentSet.CountJuegosGanados) > 1;
        }

        //
        // Comprobar si se ha ganado el el partido
        //
        private bool EsPartidoGanador(JugadorClass ganador)
        {
            return ganador.CountSetsGanados >= setGanadores;
        }

        // Comprobar si se ha acabado el partido, por ganador o por límite
        private bool EsFinPartido()
        {
            return Jugador1.EsGanador || Jugador2.EsGanador || Jugador1.Puntuacion.CountPuntos >= LIMITE_PUNTOS;
        }
        #endregion
    }
}
