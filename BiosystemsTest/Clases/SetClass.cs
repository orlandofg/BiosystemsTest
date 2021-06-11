using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiosystemsTest.Clases
{
    public class SetClass
    {
        public SetClass()
        {
            Juegos = new List<JuegoClass>();
            AddJuego();
        }
        public List<JuegoClass> Juegos { get; private set; }

        public JuegoClass CurrentJuego => Juegos.Last();
        public PuntoClass CurrentPunto => CurrentJuego.Puntos;
        public int CountJuegosGanados => Juegos.Count(j => j.EsGanador);
        public int CountPuntos => Juegos.Sum(j => j.Puntos.Count);
        public bool EsGanador { get; set; }

        public JuegoClass AddJuego()
        {
            JuegoClass juego = new();
            Juegos.Add(juego);
            return juego;
        }

        // --- 
        public bool Gana()
        {
            CurrentJuego.Gana();
            return CurrentJuego.EsFin;
        }
        public void Pierde()
        {
            CurrentJuego.Pierde();
        }

        public string GetInfo()
        {
            string info = "";
            for(int i = 0; i < Juegos.Count; i++)
            {
                info += $"[{i + 1}]: {Juegos[i].Puntos.Info} ";
            }
            return info;
        }
    }
}
