using DevelopmentChallenge.Data.Classes.Formas;
using DevelopmentChallenge.Data.Classes.Idiomas;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Tests.FormaGeometricaTests.CirculoTests
{
    [TestFixture]
    public class CirculoCastellanoTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            var idioma = new Castellano();
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeometrica>(), idioma));
        }

        [TestCase]
        public void TestResumenListaConUnCirculo()
        {
            var circulos = new List<IFormaGeometrica> { new Circulo(3) };
            var idioma = new Castellano();

            var resumen = FormaGeometrica.Imprimir(circulos, idioma);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Círculo | Area 28.27 | Perimetro 18.85 <br/>TOTAL:<br/>1 formas Perimetro 18.85 Area 28.27", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCirculos()
        {
            var circulos = new List<IFormaGeometrica> { new Circulo(3), new Circulo(1), new Circulo(5.75m) };
            var idioma = new Castellano();

            var resumen = FormaGeometrica.Imprimir(circulos, idioma);

            Assert.AreEqual("<h1>Reporte de Formas</h1>3 Círculos | Area 135.28 | Perimetro 61.26 <br/>TOTAL:<br/>3 formas Perimetro 61.26 Area 135.28", resumen);
        }
    }
}
