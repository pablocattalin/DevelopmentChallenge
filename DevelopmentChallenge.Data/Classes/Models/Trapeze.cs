/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class Trapeze : GeometrycShape
    {        
        public Trapeze(decimal lado, 
            decimal lado2, 
            decimal altura,
            decimal lado1NoParalelo, 
            decimal lado2NoParalelo) : base(lado)
        {
            Lado2 = lado2;
            Lado1NoParalelo = lado1NoParalelo;
            Lado2NoParalelo = lado2NoParalelo;
            Altura = altura;
        }

        public decimal Altura { get; private set; }
        public decimal Lado2 { get; private set; }
        public decimal Lado1NoParalelo { get; private set; }
        public decimal Lado2NoParalelo { get; private set;}

        public override decimal CalcularArea()
        {
            return (Lado + Lado2) * Altura / 2;
        }

        public override decimal CalcularPerimetro()
        {
            return Lado + Lado2 + Lado1NoParalelo + Lado2NoParalelo;
        }

        public override string EnglishLabelName(bool pluralize)
        {
            return pluralize ? "Trapezes" : "Trapeze";
        }
        

        public override string SpanishLabelName(bool pluralize)
        {
            return pluralize ? "Trapecios" : "Trapecio";
        }
    }
}
