using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiosystemsTest.Clases
{
    /// <summary>
    /// Clase para el tratamiento de un Juego
    /// </summary>
    public class JuegoClass: JuegoBase
    {
        public JuegoClass()
        {
            Puntos = new();
        }

        // control de puntos del Juego
        public PuntoClass Puntos { get; private set; }

        public override bool Gana()
        {
            return Puntos.Gana();
        }

        public override void Pierde()
        {
            Puntos.Pierde();
        }

        public override string GetInfo()
        {
            return Puntos.GetInfo();
        }
    }
}
