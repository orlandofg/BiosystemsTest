using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiosystemsTest.Models
{
    class SetClass : IPunto
    {
        public SetClass()
        {
            Juegos = new List<JuegoClass>();
            AddJuego();
        }
        public List<JuegoClass> Juegos { get; private set; }

        public JuegoClass CurrentJuego => Juegos.Last();
        public PuntoClass CurrentPunto => CurrentJuego.Puntos;
        
        public int CountJuegosGanados => Juegos.Count(j => j.Puntos.EsGanador);

        public override int CountPuntos() => Juegos.Sum(j => j.Puntos.CountPuntos());
        public override bool EsGanador { get; set; }

        public override bool EsFin => Juegos.Count > 6;

        public JuegoClass AddJuego()
        {
            JuegoClass juego = new();
            Juegos.Add(juego);
            return juego;
        }

        public override bool Gana()
        {
            CurrentJuego.Gana();
            return CurrentJuego.EsFin;
        }
        public override void Pierde()
        {
            CurrentJuego.Pierde();
        }

        public override string GetInfo()
        {
            string info = "";
            for (int i = 0; i < Juegos.Count; i++)
            {
                info += $"[{i + 1}]: {Juegos[i].Puntos.GetInfo()} ";
            }
            return info;
        }
    }
}
