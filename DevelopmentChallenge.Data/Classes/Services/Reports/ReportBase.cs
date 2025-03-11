/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes.Services
{
    public abstract class ReportBase
    {
        public string Imprimir(List<GeometrycShape> formas)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
                sb.Append(GetMessageEmptyList());
            else
            {
                sb.Append(GetTitle());

                var geometricShapes = formas.GroupBy(a => a.GetType());

                foreach ( var geometricShape in geometricShapes)
                {                    
                    sb.Append(GetLine(geometricShape));
                }

                sb.Append(GetFooter(geometricShapes));            
            }

            return sb.ToString();


        }

        protected abstract string GetFooter(IEnumerable<IGrouping<Type, GeometrycShape>> geometricShapes);        
        protected abstract string GetLine(IGrouping<Type, GeometrycShape> geometricShape);                
        abstract protected string GetMessageEmptyList();
        abstract protected string GetTitle();
    }
}
