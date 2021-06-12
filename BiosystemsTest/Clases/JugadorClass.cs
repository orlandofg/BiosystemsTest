using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiosystemsTest.Clases
{
    public class JugadorClass
    {
        public JugadorClass(string nombre)
        {
            Nombre = nombre;
            Puntuacion = new PuntuacionClass();
        }
        public string Nombre { get; set; }
        
        public PuntuacionClass Puntuacion { get; private set; }

        public SetClass CurrentSet => Puntuacion.CurrentSet;
        public int CountSetsGanados => Puntuacion.Sets.Count(s => s.EsGanador);

        public bool EsGanador { get; set; }

        public void AddJuego()
        {
            Puntuacion.CurrentSet.AddJuego();
        }
        public void AddSet()
        {
            Puntuacion.AddSet();
        }

        public bool Gana()
        {
            return Puntuacion.Gana();
        }
        public void Pierde()
        {
            Puntuacion.Pierde();
        }

        public string GetInfo()
        {
            return $"{Nombre}:\r\n\t{Puntuacion.GetInfo()}";
        }
    }
}
