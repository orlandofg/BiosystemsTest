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
    public class PuntoClassTests
    {
        [TestMethod()]
        public void GanaTest()
        {
            int countEsperado = 5;
            int pointEsperado = 3;
            int ventajaEsperado = 2;

            PuntoClass punto = new();
            for (int i = 0; i < 5; i++)
                punto.Gana();

            Assert.AreEqual(countEsperado, punto.Count);
            Assert.AreEqual(pointEsperado, punto.Puntos);
            Assert.AreEqual(ventajaEsperado, punto.Ventaja);
        }

        [TestMethod()]
        public void PierdeTest()
        {
            int countEsperado = 5;
            int pointEsperado = 3;
            int ventajaEsperado = 0;

            PuntoClass punto = new();
            for (int i = 0; i < 4; i++)
                punto.Gana();
            punto.Pierde();

            Assert.AreEqual(countEsperado, punto.Count);
            Assert.AreEqual(pointEsperado, punto.Puntos);
            Assert.AreEqual(ventajaEsperado, punto.Ventaja);
        }

        [TestMethod()]
        public void AddTest()
        {
            int countEsperado = 0;
            int pointEsperado = 3;
            int ventajaEsperado = 2;

            PuntoClass punto = new();
            for (int i = 0; i < 5; i++)
                punto.Add();

            Assert.AreEqual(countEsperado, punto.Count);
            Assert.AreEqual(pointEsperado, punto.Puntos);
            Assert.AreEqual(ventajaEsperado, punto.Ventaja);
        }
    }
}