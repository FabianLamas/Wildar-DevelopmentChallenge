using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Rectangulo : IFormaGeometrica
    {
        private readonly decimal _longitud;
        private readonly decimal _anchura;

        public Rectangulo(decimal longitud, decimal anchura)
        {
            _longitud = longitud;
            _anchura = anchura;
        }

        public decimal CalcularArea()
        {
            return _longitud * _anchura;
        }

        public decimal CalcularPerimetro()
        {
            return 2 * (_longitud + _anchura);
        }
    }
}
