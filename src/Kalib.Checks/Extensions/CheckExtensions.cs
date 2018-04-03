using System;
using System.Collections.Generic;

namespace Kalib.Checks.Extensions
{
    public static class CheckExtensions
    {
        public static void NotNull<T>(this T item, string arugmentName = null)
        {
            if (item == null)
            {
                throw new ArgumentNullException(arugmentName ?? nameof(item));
            }
        }

        public static void NotEmpty<T>(this IReadOnlyList<T> list, string argumentName = null)
        {
            list.NotNull(argumentName);
            if (list.Count == 0)
            {
                throw new ArgumentException($"collection must contain at least one item.", argumentName ?? nameof(list));
            }
        }

        public static void NotEmpty(this string value, string argumentName = null)
        {
            value.NotNull(argumentName);

            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("value can not be empty.", argumentName ?? nameof(value));
            }
        }

        public static void NotWhitespace(this string value, string argumentName = null)
        {
            value.NotNull(argumentName);

            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"value can not be empty or whitespace.", argumentName ?? nameof(value));
            }
        }
    }
}
