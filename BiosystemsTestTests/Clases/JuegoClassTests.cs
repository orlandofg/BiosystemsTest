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
    public class JuegoClassTests
    {
        [TestMethod()]
        public void JuegoClassTest()
        {
            int countEsperado = 5;
            int pointEsperado = 3;
            int ventajaEsperado = 0;

            JuegoClass juego = new();
            for (int i = 0; i < 4; i++)
                juego.Gana();
            juego.Pierde();

            Assert.AreEqual(countEsperado, juego.Puntos.Count);
            Assert.AreEqual(pointEsperado, juego.Puntos.Puntos);
            Assert.AreEqual(ventajaEsperado, juego.Puntos.Ventaja);
        }
    }
}