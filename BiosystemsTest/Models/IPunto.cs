using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiosystemsTest.Models
{
    abstract class IPunto
    {
        public abstract bool Gana();
        public abstract void Pierde();

        public abstract int CountPuntos();

        public abstract bool EsGanador { get; set; }

        public abstract bool EsFin { get; }

        public abstract string GetInfo();
    }
}
