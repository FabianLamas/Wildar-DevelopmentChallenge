using DevelopmentChallenge.Data.Classes.Formas;
using DevelopmentChallenge.Data.Classes.Idiomas;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Tests.FormaGeometricaTests.CirculoTests
{
    [TestFixture]
    public class CirculoItalianoTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            var idioma = new Italiano();
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeometrica>(), idioma));
        }

        [TestCase]
        public void TestResumenListaConUnCirculo()
        {
            var circulos = new List<IFormaGeometrica> { new Circulo(3) };
            var idioma = new Italiano();

            var resumen = FormaGeometrica.Imprimir(circulos, idioma);

            Assert.AreEqual("<h1>Rapporto forme</h1>1 Cerchio | Area 28.27 | Perimetro 18.85 <br/>TOTALE:<br/>1 forme Perimetro 18.85 Area 28.27", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCirculos()
        {
            var circulos = new List<IFormaGeometrica> { new Circulo(3), new Circulo(1), new Circulo(5.75m) };
            var idioma = new Italiano();

            var resumen = FormaGeometrica.Imprimir(circulos, idioma);

            Assert.AreEqual("<h1>Rapporto forme</h1>3 Cerchi | Area 135.28 | Perimetro 61.26 <br/>TOTALE:<br/>3 forme Perimetro 61.26 Area 135.28", resumen);
        }
    }
}
