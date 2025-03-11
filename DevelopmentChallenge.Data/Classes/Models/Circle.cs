using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circle : GeometrycShape
    {
        public Circle(decimal lado) : base(lado)
        {
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (Lado/ 2) * (Lado / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI* Lado;
        }

        public override string EnglishLabelName(bool pluralize)
        {
            return pluralize ? "Circles" : "Circle";
        }
        
        public override string SpanishLabelName(bool pluralize)
        {
            return pluralize ? "Círculos" : "Círculo";
        }
    }
}
