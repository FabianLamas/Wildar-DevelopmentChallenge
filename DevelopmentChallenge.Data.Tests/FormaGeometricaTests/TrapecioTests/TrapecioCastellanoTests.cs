using DevelopmentChallenge.Data.Classes.Formas;
using DevelopmentChallenge.Data.Classes.Idiomas;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Tests.FormaGeometricaTests.TrapecioTests
{
    [TestFixture]
    public class TrapecioCastellanoTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            var idioma = new Castellano();
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeometrica>(), idioma));
        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var trapecios = new List<IFormaGeometrica> { new Trapecio(5, 3, 4, 2) };
            var idioma = new Castellano();

            var resumen = FormaGeometrica.Imprimir(trapecios, idioma);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Area 16 | Perimetro 12 <br/>TOTAL:<br/>1 formas Perimetro 12 Area 16", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTrapecios()
        {
            var trapecios = new List<IFormaGeometrica>
            {
                new Trapecio(5, 3, 4, 2),
                new Trapecio(1, 1, 1, 1),
                new Trapecio(3, 2, 3, 2)
            };

            var idioma = new Castellano();

            var resumen = FormaGeometrica.Imprimir(trapecios, idioma);

            Assert.AreEqual("<h1>Reporte de Formas</h1>3 Trapecios | Area 24.5 | Perimetro 25 <br/>TOTAL:<br/>3 formas Perimetro 25 Area 24.5", resumen);
        }
    }
}
