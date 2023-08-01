using DevelopmentChallenge.Data.Classes.Formas;
using DevelopmentChallenge.Data.Classes.Idiomas;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Tests.FormaGeometricaTests.VariasFormas
{
    public class VariasFormasInglesTests
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

            var idioma = new Ingles();

            var resumen = FormaGeometrica.Imprimir(formas, idioma);

            Assert.AreEqual("<h1>Shapes report</h1>1 Square | Area 25 | Perimeter 20 <br/>1 Circle | Area 28.27 | Perimeter 18.85 <br/>1 Triangle | Area 6.93 | Perimeter 12 <br/>1 Rectangle | Area 6 | Perimeter 10 <br/>1 Trapezoid | Area 10 | Perimeter 11 <br/>TOTAL:<br/>5 shapes Perimeter 71.85 Area 76.2", resumen);
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

            var idioma = new Ingles();

            var resumen = FormaGeometrica.Imprimir(formas, idioma);

            Assert.AreEqual("<h1>Shapes report</h1>2 Squares | Area 13 | Perimeter 20 <br/>2 Circles | Area 15.71 | Perimeter 18.85 <br/>TOTAL:<br/>4 shapes Perimeter 38.85 Area 28.71", resumen);
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

            var idioma = new Ingles();

            var resumen = FormaGeometrica.Imprimir(formas, idioma);

            Assert.AreEqual("<h1>Shapes report</h1>4 Squares | Area 63 | Perimeter 52 <br/>4 Circles | Area 245.04 | Perimeter 100.53 <br/>4 Rectangles | Area 30 | Perimeter 46 <br/>4 Triangles | Area 49.36 | Perimeter 60 <br/>2 Trapezoids | Area 32 | Perimeter 28 <br/>TOTAL:<br/>18 shapes Perimeter 286.53 Area 419.41", resumen);

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

            var idioma = new Ingles();

            var resumen = FormaGeometrica.Imprimir(formas, idioma);


            Assert.AreEqual("<h1>Shapes report</h1>4 Circles | Area 245.04 | Perimeter 100.53 <br/>3 Rectangles | Area 24 | Perimeter 36 <br/>2 Trapezoids | Area 32 | Perimeter 28 <br/>TOTAL:<br/>9 shapes Perimeter 164.53 Area 301.04", resumen);
        }
    }
}
