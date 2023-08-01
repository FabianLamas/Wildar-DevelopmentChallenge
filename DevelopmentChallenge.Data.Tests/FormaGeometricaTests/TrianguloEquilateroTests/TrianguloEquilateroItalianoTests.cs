using DevelopmentChallenge.Data.Classes.Formas;
using DevelopmentChallenge.Data.Classes.Idiomas;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Tests.FormaGeometricaTests.TrianguloEquilateroTests
{
    [TestFixture]
    public class TrianguloEquilateroItalianoTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            var idioma = new Italiano();
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeometrica>(), idioma));
        }

        [TestCase]
        public void TestResumenListaConUnTriangulo()
        {
            var triangulos = new List<IFormaGeometrica> { new TrianguloEquilatero(5) };
            var idioma = new Italiano();

            var resumen = FormaGeometrica.Imprimir(triangulos, idioma);

            Assert.AreEqual("<h1>Rapporto forme</h1>1 Triangolo | Area 10.83 | Perimetro 15 <br/>TOTALE:<br/>1 forme Perimetro 15 Area 10.83", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTriangulos()
        {
            var triangulos = new List<IFormaGeometrica>
            {
                new TrianguloEquilatero(5),
                new TrianguloEquilatero(1),
                new TrianguloEquilatero(3)
            };

            var idioma = new Italiano();

            var resumen = FormaGeometrica.Imprimir(triangulos, idioma);

            Assert.AreEqual("<h1>Rapporto forme</h1>3 Triangoli | Area 15.16 | Perimetro 27 <br/>TOTALE:<br/>3 forme Perimetro 27 Area 15.16", resumen);
        }
    }
}
