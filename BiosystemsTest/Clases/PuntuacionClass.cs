using System.Collections.Generic;
using System.Linq;

namespace BiosystemsTest.Clases
{
    /// <summary>
    /// Control de puntuación para un jugador
    /// </summary>
    public class PuntuacionClass : JuegoBase
    {
        public PuntuacionClass()
        {
            Sets = new();
            AddSet();
        }

        // lista de sets
        public List<SetClass> Sets { get; private set; }

        // set actual
        public SetClass CurrentSet => Sets.Last();

        // puntos jugados (para control de limite de partido)
        public int CountPuntos => Sets.Sum(s => s.CountPuntos);

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
