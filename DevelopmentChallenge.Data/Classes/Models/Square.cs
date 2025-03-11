/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

namespace DevelopmentChallenge.Data.Classes
{
    public class Square : GeometrycShape
    {
        public Square(decimal lado) : base(lado)
        {
        }

        public override decimal CalcularArea()
        {
            return Lado * Lado;
        }

        public override decimal CalcularPerimetro()
        {
            return Lado * 4;
        }
        public override string EnglishLabelName(bool pluralize)
        {
            return pluralize ? "Squares" : "Square";
        }
        

        public override string SpanishLabelName(bool pluralize)
        {
            return pluralize ? "Cuadrados" : "Cuadrado";
        }
    }
}
