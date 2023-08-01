using DevelopmentChallenge.Data.Classes.Formas;
using DevelopmentChallenge.Data.Classes.Idiomas;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Tests.FormaGeometricaTests.TrapecioTests
{
    [TestFixture]
    public class TrapecioItalianoTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            var idioma = new Italiano();
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeometrica>(), idioma));
        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var trapecios = new List<IFormaGeometrica> { new Trapecio(5, 3, 4, 2) };
            var idioma = new Italiano();

            var resumen = FormaGeometrica.Imprimir(trapecios, idioma);

            Assert.AreEqual("<h1>Rapporto forme</h1>1 Trapezio | Area 16 | Perimetro 12 <br/>TOTALE:<br/>1 forme Perimetro 12 Area 16", resumen);
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

            var idioma = new Italiano();

            var resumen = FormaGeometrica.Imprimir(trapecios, idioma);

            Assert.AreEqual("<h1>Rapporto forme</h1>3 Trapezi | Area 24.5 | Perimetro 25 <br/>TOTALE:<br/>3 forme Perimetro 25 Area 24.5", resumen);
        }
    }
}
