using DevelopmentChallenge.Data.Classes.Formas;
using DevelopmentChallenge.Data.Classes.Idiomas;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Tests.FormaGeometricaTests.CuadradoTests
{
    [TestFixture]
    public class CuadradoInglesTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            var idioma = new Ingles();
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeometrica>(), idioma));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<IFormaGeometrica> { new Cuadrado(5) };
            var idioma = new Ingles();

            var resumen = FormaGeometrica.Imprimir(cuadrados, idioma);

            Assert.AreEqual("<h1>Shapes report</h1>1 Square | Area 25 | Perimeter 20 <br/>TOTAL:<br/>1 shapes Perimeter 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var idioma = new Ingles();

            var resumen = FormaGeometrica.Imprimir(cuadrados, idioma);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }
    }
}
