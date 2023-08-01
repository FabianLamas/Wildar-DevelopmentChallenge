using DevelopmentChallenge.Data.Classes.Formas;
using DevelopmentChallenge.Data.Classes.Idiomas;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Tests.FormaGeometricaTests.VariasFormas
{
    public class VariasFormasCastellanoTests
    {
        [TestCase]
        public void TestResumenListaConTodasFormas()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Rectangulo(2, 3),
                new Trapecio(3, 2, 4, 3)
            };

            var idioma = new Castellano();

            var resumen = FormaGeometrica.Imprimir(formas, idioma);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>1 Círculo | Area 28.27 | Perimetro 18.85 <br/>1 Triángulo | Area 6.93 | Perimetro 12 <br/>1 Rectángulo | Area 6 | Perimetro 10 <br/>1 Trapecio | Area 10 | Perimetro 11 <br/>TOTAL:<br/>5 formas Perimetro 71.85 Area 76.2",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConDosCuadradosYDosCirculos()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(2),
                new Cuadrado(3),
                new Circulo(1),
                new Circulo(2),
            };

            var idioma = new Castellano();

            var resumen = FormaGeometrica.Imprimir(formas, idioma);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 13 | Perimetro 20 <br/>2 Círculos | Area 15.71 | Perimetro 18.85 <br/>TOTAL:<br/>4 formas Perimetro 38.85 Area 28.71",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConVariasFormas()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(2),
                new Circulo(3),
                new Rectangulo(2, 1),
                new Rectangulo(2, 3),
                new Cuadrado(1),
                new Circulo(2),
                new TrianguloEquilatero(4),
                new TrianguloEquilatero(3),
                new Trapecio(3, 2, 4, 3),
                new Circulo(4),
                new TrianguloEquilatero(5),
                new Rectangulo(2, 4),
                new Cuadrado(3),
                new TrianguloEquilatero(8),
                new Trapecio(6, 5, 4, 3),
                new Circulo(7),
                new Cuadrado(7),
                new Rectangulo(2, 7),
            };

            var idioma = new Castellano();

            var resumen = FormaGeometrica.Imprimir(formas, idioma);

            Assert.AreEqual("<h1>Reporte de Formas</h1>4 Cuadrados | Area 63 | Perimetro 52 <br/>4 Círculos | Area 245.04 | Perimetro 100.53 <br/>4 Rectángulos | Area 30 | Perimetro 46 <br/>4 Triángulos | Area 49.36 | Perimetro 60 <br/>2 Trapecios | Area 32 | Perimetro 28 <br/>TOTAL:<br/>18 formas Perimetro 286.53 Area 419.41", resumen);

        }

        [TestCase]
        public void TestResumenListaSinCuadradoNiTraingulo()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Circulo(3),
                new Rectangulo(2, 1),
                new Circulo(2),
                new Trapecio(3, 2, 4, 3),
                new Circulo(4),
                new Rectangulo(2, 4),
                new Trapecio(6, 5, 4, 3),
                new Circulo(7),
                new Rectangulo(2, 7),
            };

            var idioma = new Castellano();

            var resumen = FormaGeometrica.Imprimir(formas, idioma);

            Assert.AreEqual("<h1>Reporte de Formas</h1>4 Círculos | Area 245.04 | Perimetro 100.53 <br/>3 Rectángulos | Area 24 | Perimetro 36 <br/>2 Trapecios | Area 32 | Perimetro 28 <br/>TOTAL:<br/>9 formas Perimetro 164.53 Area 301.04", resumen);
        }
    }
}
