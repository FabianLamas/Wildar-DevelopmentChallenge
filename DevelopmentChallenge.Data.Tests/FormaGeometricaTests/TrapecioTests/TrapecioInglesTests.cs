using DevelopmentChallenge.Data.Classes.Formas;
using DevelopmentChallenge.Data.Classes.Idiomas;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Tests.FormaGeometricaTests.TrapecioTests
{
    [TestFixture]
    public class TrapecioInglesTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            var idioma = new Ingles();
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeometrica>(), idioma));
        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var trapecios = new List<IFormaGeometrica> { new Trapecio(5, 3, 4, 2) };
            var idioma = new Ingles();

            var resumen = FormaGeometrica.Imprimir(trapecios, idioma);

            Assert.AreEqual("<h1>Shapes report</h1>1 Trapezoid | Area 16 | Perimeter 12 <br/>TOTAL:<br/>1 shapes Perimeter 12 Area 16", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTrapecios()
        {
            var trapecios = new List<IFormaGeometrica>
            {
                new Trapecio(5, 3, 4, 2),
                new Trapecio(1, 1, 1, 1),
                new Trapecio(3, 2, 3, 2)
            };

            var idioma = new Ingles();

            var resumen = FormaGeometrica.Imprimir(trapecios, idioma);

            Assert.AreEqual("<h1>Shapes report</h1>3 Trapezoids | Area 24.5 | Perimeter 25 <br/>TOTAL:<br/>3 shapes Perimeter 25 Area 24.5", resumen);
        }
    }
}
