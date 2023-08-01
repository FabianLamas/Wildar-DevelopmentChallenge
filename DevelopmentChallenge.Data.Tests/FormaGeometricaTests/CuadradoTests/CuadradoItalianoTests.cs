using NUnit.Framework;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes.Formas;
using DevelopmentChallenge.Data.Classes.Idiomas;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Tests.FormaGeometricaTests.CuadradoTests
{
    [TestFixture]
    public class CuadradoItalianoTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            var idioma = new Italiano();
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeometrica>(), idioma));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<IFormaGeometrica> { new Cuadrado(5) };
            var idioma = new Italiano();

            var resumen = FormaGeometrica.Imprimir(cuadrados, idioma);

            Assert.AreEqual("<h1>Rapporto forme</h1>1 Quadrato | Area 25 | Perimetro 20 <br/>TOTALE:<br/>1 forme Perimetro 20 Area 25", resumen);
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

            var idioma = new Italiano();

            var resumen = FormaGeometrica.Imprimir(cuadrados, idioma);

            Assert.AreEqual("<h1>Rapporto forme</h1>3 Quadrati | Area 35 | Perimetro 36 <br/>TOTALE:<br/>3 forme Perimetro 36 Area 35", resumen);
        }
    }
}
