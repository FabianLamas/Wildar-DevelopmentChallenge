using DevelopmentChallenge.Data.Classes.Formas;
using DevelopmentChallenge.Data.Classes.Idiomas;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Tests.FormaGeometricaTests.RectanguloTests
{
    [TestFixture]
    public class RectanguloCastellanoTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            var idioma = new Castellano();
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeometrica>(), idioma));
        }

        [TestCase]
        public void TestResumenListaConUnRectangulo()
        {
            var rectangulos = new List<IFormaGeometrica> { new Rectangulo(5, 3) };
            var idioma = new Castellano();

            var resumen = FormaGeometrica.Imprimir(rectangulos, idioma);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Rectángulo | Area 15 | Perimetro 16 <br/>TOTAL:<br/>1 formas Perimetro 16 Area 15", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasRectangulos()
        {
            var rectangulos = new List<IFormaGeometrica>
            {
                new Rectangulo(5, 3),
                new Rectangulo(2, 1),
                new Rectangulo(3, 2)
            };

            var idioma = new Castellano();

            var resumen = FormaGeometrica.Imprimir(rectangulos, idioma);

            Assert.AreEqual("<h1>Reporte de Formas</h1>3 Rectángulos | Area 23 | Perimetro 32 <br/>TOTAL:<br/>3 formas Perimetro 32 Area 23", resumen);
        }
    }
}
