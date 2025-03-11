/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

using System;

namespace DevelopmentChallenge.Data.Classes
{
    public abstract class Triangle : GeometrycShape
    {
        protected Triangle(decimal lado) : base(lado)
        {
        }        

        public override string EnglishLabelName(bool pluralize)
        {
            return pluralize ? "Triangles" : "Triangle";
        }


        public override string SpanishLabelName(bool pluralize)
        {
            return pluralize ? "Triángulos" : "Triángulo";
        }
    }
}
