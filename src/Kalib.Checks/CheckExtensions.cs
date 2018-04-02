using System;
using System.Collections.Generic;

namespace Kalib.Checks
{
    public static class CheckExtensions
    {
        public static void CheckNull<T>(this T item, string arugmentName = null)
        {
            if (item == null)
            {
                throw new ArgumentNullException(arugmentName ?? nameof(item));
            }
        }

        public static void CheckEmpty<T>(this IReadOnlyList<T> list, string argumentName = null)
        {
            list.CheckNull(argumentName);
            if (list.Count == 0)
            {
                throw new ArgumentException($"collection must contain at least one item.", argumentName ?? nameof(list));
            }
        }

        public static void CheckEmpty(this string value, string argumentName = null)
        {
            value.CheckNull(argumentName);

            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("value can not be empty.", argumentName ?? nameof(value));
            }
        }

        public static void CheckWhitespace(this string value, string argumentName = null)
        {
            value.CheckNull(argumentName);

            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"value can not be empty or whitespace.", argumentName ?? nameof(value));
            }
        }
    }
}
