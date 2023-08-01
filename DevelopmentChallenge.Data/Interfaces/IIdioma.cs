namespace DevelopmentChallenge.Data.Interfaces
{
    public interface IIdioma
    {
        string ReporteFormas { get; }
        string ListaVacia { get; }
        string Formas { get; }
        string Perimetro { get; }
        string Area { get; }
        string Total { get; }
        string GetNombreForma(string forma, int cantidad);
    }
}
