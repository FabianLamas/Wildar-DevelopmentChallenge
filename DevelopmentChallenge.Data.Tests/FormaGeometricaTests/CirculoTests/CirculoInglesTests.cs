using DevelopmentChallenge.Data.Classes.Formas;
using DevelopmentChallenge.Data.Classes.Idiomas;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Tests.FormaGeometricaTests.CirculoTests
{
    [TestFixture]
    public class CirculoInglesTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            var idioma = new Ingles();
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeometrica>(), idioma));
        }

        [TestCase]
        public void TestResumenListaConUnCirculo()
        {
            var circulos = new List<IFormaGeometrica> { new Circulo(3) };
            var idioma = new Ingles();

            var resumen = FormaGeometrica.Imprimir(circulos, idioma);

            Assert.AreEqual("<h1>Shapes report</h1>1 Circle | Area 28.27 | Perimeter 18.85 <br/>TOTAL:<br/>1 shapes Perimeter 18.85 Area 28.27", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCirculos()
        {
            var circulos = new List<IFormaGeometrica> { new Circulo(3), new Circulo(1), new Circulo(5.75m) };
            var idioma = new Ingles();

            var resumen = FormaGeometrica.Imprimir(circulos, idioma);

            Assert.AreEqual("<h1>Shapes report</h1>3 Circles | Area 135.28 | Perimeter 61.26 <br/>TOTAL:<br/>3 shapes Perimeter 61.26 Area 135.28", resumen);
        }
    }
}
