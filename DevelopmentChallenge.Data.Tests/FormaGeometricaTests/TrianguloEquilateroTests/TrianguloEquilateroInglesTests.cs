using DevelopmentChallenge.Data.Classes.Formas;
using DevelopmentChallenge.Data.Classes.Idiomas;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Tests.FormaGeometricaTests.TrianguloEquilateroTests
{
    [TestFixture]
    public class TrianguloEquilateroInglesTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            var idioma = new Ingles();
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeometrica>(), idioma));
        }

        [TestCase]
        public void TestResumenListaConUnTriangulo()
        {
            var triangulos = new List<IFormaGeometrica> { new TrianguloEquilatero(5) };
            var idioma = new Ingles();

            var resumen = FormaGeometrica.Imprimir(triangulos, idioma);

            Assert.AreEqual("<h1>Shapes report</h1>1 Triangle | Area 10.83 | Perimeter 15 <br/>TOTAL:<br/>1 shapes Perimeter 15 Area 10.83", resumen);
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

            var idioma = new Ingles();

            var resumen = FormaGeometrica.Imprimir(triangulos, idioma);

            Assert.AreEqual("<h1>Shapes report</h1>3 Triangles | Area 15.16 | Perimeter 27 <br/>TOTAL:<br/>3 shapes Perimeter 27 Area 15.16", resumen);
        }
    }
}
