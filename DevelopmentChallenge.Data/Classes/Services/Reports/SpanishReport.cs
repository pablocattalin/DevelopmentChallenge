﻿/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes.Services
{
    public class SpanishReport : ReportBase
    {
        protected override string GetFooter(IEnumerable<IGrouping<Type, GeometrycShape>> geometricShapes)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("TOTAL:<br/>");
            sb.Append($"{geometricShapes.Sum(a => a.Count())} formas ");
            sb.Append($"Perimetro {geometricShapes.SelectMany(a => a).Sum(a => a.CalcularPerimetro()).ToString("#.##")} ");
            sb.Append($"Area {geometricShapes.SelectMany(a => a).Sum(a => a.CalcularArea()).ToString("#.##")}");            
            return sb.ToString();
        }

        protected override string GetLine(IGrouping<Type, GeometrycShape> geometricShape)
        {                                    
            if (geometricShape.Count() > 0)
            {
                return $"{geometricShape.Count()} {geometricShape.First().SpanishLabelName(geometricShape.Count() > 1)} | Area {geometricShape.Sum(a => a.CalcularArea()):#.##} | Perimetro {geometricShape.Sum(a => a.CalcularPerimetro()):#.##} <br/>";
            }
            return string.Empty;
        }

        protected override string GetMessageEmptyList()
        {
            return "<h1>Lista vacía de formas!</h1>";
        }

        protected override string GetTitle()
        {
            return "<h1>Reporte de Formas</h1>";
        }
    }
}
