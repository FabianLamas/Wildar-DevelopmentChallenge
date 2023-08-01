using DevelopmentChallenge.Data.Interfaces;
using System;

namespace DevelopmentChallenge.Data.Classes.Idiomas
{
    public class Italiano : IIdioma
    {
        public string ReporteFormas => "Rapporto forme";
        public string ListaVacia => "Elenco vuoto di forme!";
        public string Formas => "forme";
        public string Perimetro => "Perimetro";
        public string Area => "Area";
        public string Total => "TOTALE";

        public string GetNombreForma(string forma, int cantidad)
        {
            switch (forma)
            {
                case "Circulo":
                    return cantidad == 1 ? "Cerchio" : "Cerchi";
                case "Cuadrado":
                    return cantidad == 1 ? "Quadrato" : "Quadrati";
                case "TrianguloEquilatero":
                    return cantidad == 1 ? "Triangolo" : "Triangoli";
                case "Trapecio":
                    return cantidad == 1 ? "Trapezio" : "Trapezi";
                case "Rectangulo":
                    return cantidad == 1 ? "Rettangolo" : "Rettangoli";
                default:
                    throw new NotSupportedException("Forma non supportata");
            }
        }
    }
}
