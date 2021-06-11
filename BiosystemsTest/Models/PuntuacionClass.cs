using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiosystemsTest.Models
{
    class PuntuacionClass : IPunto
    {
        public PuntuacionClass()
        {
            Sets = new();
            AddSet();
        }
        public List<SetClass> Sets { get; private set; }

        public SetClass CurrentSet => Sets.Last();

        public override bool EsGanador { get; set; }

        public override bool EsFin => Sets.Count >= 3;

        public override int CountPuntos() => Sets.Sum(s => s.CountPuntos());

        public SetClass AddSet()
        {
            var set = new SetClass();
            Sets.Add(set);
            return set;
        }

        public override bool Gana()
        {
            return CurrentSet.Gana();
        }
        public override void Pierde()
        {
            CurrentSet.Pierde();
        }

        public override string GetInfo()
        {
            string info = "";
            for (int i = 0; i < Sets.Count; i++)
            {
                info += $"SET {i + 1}: {Sets[i].GetInfo()}\r\n\t";
            }
            return info;
        }
    }
}
