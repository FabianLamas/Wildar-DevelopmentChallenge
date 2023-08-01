using DevelopmentChallenge.Data.Interfaces;
using System;

namespace DevelopmentChallenge.Data.Classes.Idiomas
{
    public class Castellano : IIdioma
    {
        public string ReporteFormas => "Reporte de Formas";
        public string ListaVacia => "Lista vacía de formas!";
        public string Formas => "formas";
        public string Perimetro => "Perimetro";
        public string Area => "Area";
        public string Total => "TOTAL";

        public string GetNombreForma(string forma, int cantidad)
        {
            switch (forma)
            {
                case "Circulo":
                    return cantidad == 1 ? "Círculo" : "Círculos";
                case "Cuadrado":
                    return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                case "TrianguloEquilatero":
                    return cantidad == 1 ? "Triángulo" : "Triángulos";
                case "Trapecio":
                    return cantidad == 1 ? "Trapecio" : "Trapecios";
                case "Rectangulo":
                    return cantidad == 1 ? "Rectángulo" : "Rectángulos";
                default:
                    throw new NotSupportedException("Forma no soportada");
            }
        }
    }
}
