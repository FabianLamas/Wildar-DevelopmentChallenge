using DevelopmentChallenge.Data.Classes.Formas;
using DevelopmentChallenge.Data.Classes.Idiomas;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Tests.FormaGeometricaTests.TrianguloEquilateroTests
{
    [TestFixture]
    public class TrianguloEquilateroCastellanoTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            var idioma = new Castellano();
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeometrica>(), idioma));
        }

        [TestCase]
        public void TestResumenListaConUnTriangulo()
        {
            var triangulos = new List<IFormaGeometrica> { new TrianguloEquilatero(5) };
            var idioma = new Castellano();

            var resumen = FormaGeometrica.Imprimir(triangulos, idioma);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Triángulo | Area 10.83 | Perimetro 15 <br/>TOTAL:<br/>1 formas Perimetro 15 Area 10.83", resumen);
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

            var idioma = new Castellano();

            var resumen = FormaGeometrica.Imprimir(triangulos, idioma);

            Assert.AreEqual("<h1>Reporte de Formas</h1>3 Triángulos | Area 15.16 | Perimetro 27 <br/>TOTAL:<br/>3 formas Perimetro 27 Area 15.16", resumen);
        }
    }
}
