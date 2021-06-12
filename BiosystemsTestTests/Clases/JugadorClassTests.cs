using Microsoft.VisualStudio.TestTools.UnitTesting;
using BiosystemsTest.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiosystemsTest.Clases.Tests
{
    [TestClass()]
    public class JugadorClassTests
    {
        [TestMethod()]
        public void GanaTest()
        {
            int countEsperado = 1;
            int pointEsperado = 5;
            int juegosEsperado = 2;

            JugadorClass puntuacion = new("jugador");
            for (int i = 0; i < 5; i++)
            {
                if (puntuacion.Gana())
                {
                    puntuacion.CurrentSet.CurrentJuego.EsGanador = true;
                    puntuacion.CurrentSet.AddJuego();
                }
            }
            Assert.AreEqual(countEsperado, puntuacion.CurrentSet.CountJuegosGanados);
            Assert.AreEqual(pointEsperado, puntuacion.CurrentSet.CountPuntos);
            Assert.AreEqual(juegosEsperado, puntuacion.CurrentSet.Juegos.Count);
        }

    }
}