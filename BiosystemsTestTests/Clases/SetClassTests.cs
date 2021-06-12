using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BiosystemsTest.Clases.Tests
{
    [TestClass()]
    public class SetClassTests
    {

        [TestMethod()]
        public void GanaTest()
        {
            int countEsperado = 1;
            int pointEsperado = 5;
            int juegosEsperado = 2;

            SetClass set = new();
            for (int i = 0; i < 5; i++)
            {
                if (set.Gana())
                {
                    set.CurrentJuego.EsGanador = true;
                    set.AddJuego();
                }
            }
            Assert.AreEqual(countEsperado, set.CountJuegosGanados);
            Assert.AreEqual(pointEsperado, set.CountPuntos);
            Assert.AreEqual(juegosEsperado, set.Juegos.Count);
        }


    }
}