using EstatisticaAPI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EstatisticaAPITest
{
    [TestClass]
    public class EstatisticaTest
    {
    
        Estatistica estatistica = new Estatistica();
        [TestMethod]
        public void CirculoCalcularMedia()
        {
            double esperado = 6;
            string[] medidas = {"6","6","6","6"};
            double resultado = estatistica.CalcularMedia(medidas);

            Assert.AreEqual(esperado,resultado);
        }
    }
}