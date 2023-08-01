using DevelopmentChallenge.Data.Classes.Idiomas;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes.Formas;

namespace DevelopmentChallenge.Data.Tests.FormaGeometricaTests.RectanguloTests
{
    [TestFixture]
    public class RectanguloItalianoTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            var idioma = new Italiano();
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeometrica>(), idioma));
        }

        [TestCase]
        public void TestResumenListaConUnRectangulo()
        {
            var rettangoli = new List<IFormaGeometrica> { new Rectangulo(5, 3) };
            var idioma = new Italiano();

            var resumen = FormaGeometrica.Imprimir(rettangoli, idioma);

            Assert.AreEqual("<h1>Rapporto forme</h1>1 Rettangolo | Area 15 | Perimetro 16 <br/>TOTALE:<br/>1 forme Perimetro 16 Area 15", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasRettangoli()
        {
            var rettangoli = new List<IFormaGeometrica>
            {
                new Rectangulo(5, 3),
                new Rectangulo(2, 1),
                new Rectangulo(3, 2)
            };

            var idioma = new Italiano();

            var resumen = FormaGeometrica.Imprimir(rettangoli, idioma);

            Assert.AreEqual("<h1>Rapporto forme</h1>3 Rettangoli | Area 23 | Perimetro 32 <br/>TOTALE:<br/>3 forme Perimetro 32 Area 23", resumen);
        }
    }
}
