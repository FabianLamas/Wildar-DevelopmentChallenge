/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * OPCIONAL: Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using DevelopmentChallenge.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        public static string Imprimir(List<IFormaGeometrica> formas, IIdioma idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append($"<h1>{idioma.ListaVacia}</h1>");
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append($"<h1>{idioma.ReporteFormas}</h1>");

                var formasAgrupadas = formas.GroupBy(f => f.GetType());

                foreach (var grupo in formasAgrupadas)
                {
                    var numeroFormas = grupo.Count();
                    var areaFormas = grupo.Sum(f => f.CalcularArea());
                    var perimetroFormas = grupo.Sum(f => f.CalcularPerimetro());

                    var primeraForma = grupo.First();
                    var nombreForma = idioma.GetNombreForma(primeraForma.GetType().Name, numeroFormas);

                    sb.Append(ObtenerLinea(numeroFormas, areaFormas, perimetroFormas, nombreForma, idioma));
                }

                // FOOTER
                sb.Append($"{idioma.Total}:<br/>");
                var numeroTotalFormas = formas.Count;
                var areaTotalFormas = formas.Sum(f => f.CalcularArea());
                var perimetroTotalFormas = formas.Sum(f => f.CalcularPerimetro());
                sb.Append($"{numeroTotalFormas} {idioma.Formas} ");
                sb.Append($"{idioma.Perimetro} {perimetroTotalFormas:#.##} ");
                sb.Append($"Area {areaTotalFormas:#.##}");
            }

            return sb.ToString();
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string nombre, IIdioma idioma)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {nombre} | {idioma.Area} {area:#.##} | {idioma.Perimetro} {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }
    }
}
