using DevelopmentChallenge.Data.Interfaces;
using System;

namespace DevelopmentChallenge.Data.Classes.Idiomas
{
    public class Ingles : IIdioma
    {
        public string ReporteFormas => "Shapes report";
        public string ListaVacia => "Empty list of shapes!";
        public string Formas => "shapes";
        public string Perimetro => "Perimeter";
        public string Area => "Area";
        public string Total => "TOTAL";

        public string GetNombreForma(string forma, int cantidad)
        {
            switch (forma)
            {
                case "Circulo":
                    return cantidad == 1 ? "Circle" : "Circles";
                case "Cuadrado":
                    return cantidad == 1 ? "Square" : "Squares";
                case "TrianguloEquilatero":
                    return cantidad == 1 ? "Triangle" : "Triangles";
                case "Trapecio":
                    return cantidad == 1 ? "Trapezoid" : "Trapezoids";
                case "Rectangulo":
                    return cantidad == 1 ? "Rectangle" : "Rectangles";
                default:
                    throw new NotSupportedException("Forma no soportada");
            }
        }
    }
}
