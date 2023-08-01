using DevelopmentChallenge.Data.Classes.Formas;
using DevelopmentChallenge.Data.Classes.Idiomas;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Tests.FormaGeometricaTests.RectanguloTests
{
    [TestFixture]
    public class RectanguloInglesTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            var idioma = new Ingles();
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeometrica>(), idioma));
        }

        [TestCase]
        public void TestResumenListaConUnRectangulo()
        {
            var rectangulos = new List<IFormaGeometrica> { new Rectangulo(5, 3) };
            var idioma = new Ingles();

            var resumen = FormaGeometrica.Imprimir(rectangulos, idioma);

            Assert.AreEqual("<h1>Shapes report</h1>1 Rectangle | Area 15 | Perimeter 16 <br/>TOTAL:<br/>1 shapes Perimeter 16 Area 15", resumen);
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

            var idioma = new Ingles();

            var resumen = FormaGeometrica.Imprimir(rectangulos, idioma);

            Assert.AreEqual("<h1>Shapes report</h1>3 Rectangles | Area 23 | Perimeter 32 <br/>TOTAL:<br/>3 shapes Perimeter 32 Area 23", resumen);
        }
    }
}
