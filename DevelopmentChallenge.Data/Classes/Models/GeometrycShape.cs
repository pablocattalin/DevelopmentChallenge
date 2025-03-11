/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

namespace DevelopmentChallenge.Data.Classes
{
    public abstract class GeometrycShape
    {
        protected GeometrycShape(decimal lado)
        {
            Lado = lado;
        }

        public decimal Lado { get; protected set; }

        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
        public abstract string EnglishLabelName(bool pluralize);                
        public abstract string SpanishLabelName(bool pluralize);
    }    
}
