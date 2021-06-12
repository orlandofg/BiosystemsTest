using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BiosystemsTest.Clases.Tests
{
    [TestClass()]
    public class PuntuacionClassTests
    {
        [TestMethod()]
        public void GanaTest()
        {
            int countEsperado = 1;
            int pointEsperado = 5;
            int juegosEsperado = 2;

            PuntuacionClass puntuacion = new();
            for (int i = 0; i < 5; i++)
            {
                if (puntuacion.Gana())
                {
                    puntuacion.CurrentSet.CurrentJuego.EsGanador = true;
                    puntuacion.CurrentSet.AddJuego();
                }
            }
            Assert.AreEqual(countEsperado, puntuacion.CurrentSet.CountJuegosGanados);
            Assert.AreEqual(pointEsperado, puntuacion.CountPuntos);
            Assert.AreEqual(juegosEsperado, puntuacion.CurrentSet.Juegos.Count);
        }

    }
}