using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiosystemsTest.Clases
{
    public class JuegoClass
    {
        public JuegoClass()
        {
            Puntos = new();
        }
        public PuntoClass Puntos { get; private set; }

        public bool EsGanador { get; set; }

        public bool EsFin => Puntos.EsFin;

        public void Gana()
        {
            Puntos.Gana();
        }

        public void Pierde()
        {
            Puntos.Pierde();
        }
    }
}
