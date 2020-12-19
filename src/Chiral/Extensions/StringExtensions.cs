using System;
using System.Collections.Generic;
using System.Linq;

namespace Chiral.Extensions
{
    /// <summary>
    /// Extension methods for Strings.
    /// </summary>
    internal static class StringExtensions
    {
        /// <summary>
        /// Finds the longest common prefix.
        /// </summary>
        /// <param name="values">A list of strings.</param>
        /// <returns>The common prefix.</returns>
        public static string FindSharedPrefix(this IEnumerable<string> values)
        {
            var enumerable = values.ToList();
            var prefix = enumerable?.Min()?.TakeWhile((value, index) =>
                enumerable.All(target => target?.ElementAt(index).Equals(value) ?? false));

            return new string(prefix?.ToArray() ?? Array.Empty<char>());
        }
    }
}
