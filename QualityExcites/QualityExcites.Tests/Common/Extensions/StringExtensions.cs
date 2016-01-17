using System.Linq;

namespace QualityExcites.Tests.Common.Extensions
{
    public static class StringExtensions
    {
        public static string ToCamelCase(this string text)
        {
            var result = string.Empty;
            var elements = text.Split(' ');

            return elements.Aggregate(result, (current, element) => current + (element.Substring(0, 1).ToUpper() + element.Substring(1).ToLower()));
        }
    }
}
