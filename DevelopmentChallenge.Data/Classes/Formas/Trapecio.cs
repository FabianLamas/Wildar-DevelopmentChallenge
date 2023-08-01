using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Trapecio : IFormaGeometrica
    {
        private readonly decimal _baseMayor;
        private readonly decimal _baseMenor;
        private readonly decimal _altura;
        private readonly decimal _lado;

        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura, decimal lado)
        {
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _altura = altura;
            _lado = lado;
        }

        public decimal CalcularArea()
        {
            return (_baseMayor + _baseMenor) / 2 * _altura;
        }

        public decimal CalcularPerimetro()
        {
            return _baseMayor + _baseMenor + 2 * _lado;
        }
    }
}
