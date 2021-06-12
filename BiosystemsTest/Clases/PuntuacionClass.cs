using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiosystemsTest.Clases
{
    class PuntuacionClass
    {
        public PuntuacionClass()
        {
            Sets = new();
            AddSet();
        }
        public List<SetClass> Sets { get; private set; }

        public SetClass CurrentSet => Sets.Last();

        public int CountPuntos => Sets.Sum(s => s.CountPuntos);

        public SetClass AddSet()
        {
            var set = new SetClass();
            Sets.Add(set);
            return set;
        }

        public bool Gana()
        {
            return CurrentSet.Gana();
        }
        public void Pierde()
        {
            CurrentSet.Pierde();
        }

        public string GetInfo()
        {
            string info = "";
            for(int i = 0; i < Sets.Count; i++)
            {
                info += $"SET {i + 1}: {Sets[i].GetInfo()}\r\n\t";
            }
            return info;
        }
    }
}
