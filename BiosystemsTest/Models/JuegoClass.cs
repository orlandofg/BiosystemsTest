using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiosystemsTest.Models
{
    class JuegoClass : IPunto
    {
        public JuegoClass()
        {
            Puntos = new();
        }
        public PuntoClass Puntos { get; private set; }

        public override bool EsFin => Puntos.EsFin;

        public override bool EsGanador
        {
            get => Puntos.EsGanador;
            set => Puntos.EsGanador = value;
        }

        public override int CountPuntos() => Puntos.CountPuntos();

        public override bool Gana()
        {
            return Puntos.Gana();
        }

        public override string GetInfo()
        {
            return Puntos.GetInfo();
        }

        public override void Pierde()
        {
            Puntos.Pierde();
        }
    }
}
