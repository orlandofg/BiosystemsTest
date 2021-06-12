using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiosystemsTest.Clases
{
    /// <summary>
    /// Clase para el tratamiento de un Set
    /// </summary>
    public class SetClass : JuegoBase
    {
        public SetClass()
        {
            Juegos = new List<JuegoClass>();
            AddJuego();
        }

        // lista de juegos del set
        public List<JuegoClass> Juegos { get; private set; }

        // acceso al juego actual
        public JuegoClass CurrentJuego => Juegos.Last();
        // acceso al punto actual
        public PuntoClass CurrentPunto => CurrentJuego.Puntos;

        public int CountPuntos => Juegos.Sum(j => j.Puntos.Count);
        public int CountJuegosGanados => Juegos.Count(j => j.EsGanador);

        public JuegoClass AddJuego()
        {
            JuegoClass juego = new();
            Juegos.Add(juego);
            return juego;
        }

        // --- 
        public override bool Gana()
        {
            return CurrentJuego.Gana();
        }
        public override void Pierde()
        {
            CurrentJuego.Pierde();
        }

        public override string GetInfo()
        {
            string info = "";
            for(int i = 0; i < Juegos.Count; i++)
            {
                info += $"[{i + 1}]: {Juegos[i].Puntos.GetInfo()} ";
            }
            return info;
        }
    }
}
