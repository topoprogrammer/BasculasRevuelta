using System;
using BasculasRevuelta.Common.Data.Models;
using NUnit.Framework;

namespace BasculasRevuelta.Common.Data.UnitTest
{
    [TestFixture]
    public class TourTest
    {
        [Test]
        public void Si_Cancela_Deberia_ActualizarInstanciaCancelado()
        {
            var testTour = new Tour
            {
                // Llenado de propiedades o llamada a metodo factory dentro de la clase
            };

            testTour.Canela();
            Assert.IsTrue(testTour.Canelado);
        }
    }
}
