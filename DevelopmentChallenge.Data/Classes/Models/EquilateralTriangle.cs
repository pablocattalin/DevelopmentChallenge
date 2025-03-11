using System;

namespace DevelopmentChallenge.Data.Classes.Models
{
    public class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(decimal lado) : base(lado)
        {
        }

        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * Lado * Lado;
        }

        public override decimal CalcularPerimetro()
        {
            return Lado * 3;
        }
    }
}
