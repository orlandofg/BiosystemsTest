using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiosystemsTest.Clases
{
    /// <summary>
    /// Clase para gestión de un jugador: datos y control de puntuación del mismo
    /// </summary>
    public class JugadorClass
    {
        public JugadorClass(string nombre)
        {
            Nombre = nombre;
            Puntuacion = new PuntuacionClass();
        }
        public string Nombre { get; set; }
        
        // control de puntuación del jugaor
        public PuntuacionClass Puntuacion { get; private set; }

        // set actual jugado
        public SetClass CurrentSet => Puntuacion.CurrentSet;
        public int CountSetsGanados => Puntuacion.Sets.Count(s => s.EsGanador);

        // es ganador del partido
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
