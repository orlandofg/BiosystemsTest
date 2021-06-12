using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiosystemsTest.Clases
{
    public abstract class JuegoBase
    {
        public bool EsGanador { get; set; }

        public abstract bool Gana();

        public abstract void Pierde();

        public abstract string GetInfo();
    }
}
