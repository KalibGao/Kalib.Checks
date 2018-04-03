using System;
using System.Collections.Generic;

namespace Kalib.Checks
{
    public static class Check
    {
        public static void NotNull<T>(T item, string arugmentName = null)
        {
            if (item == null)
            {
                throw new ArgumentNullException(arugmentName ?? nameof(item));
            }
        }

        public static void NotEmpty<T>(IReadOnlyList<T> list, string argumentName = null)
        {
            NotNull(list, argumentName);
            if (list.Count == 0)
            {
                throw new ArgumentException($"collection must contain at least one item.", argumentName ?? nameof(list));
            }
        }

        public static void NotEmpty(string value, string argumentName = null)
        {
            NotNull(value, argumentName);

            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("value can not be empty.", argumentName ?? nameof(value));
            }
        }

        public static void NotWhitespace(this string value, string argumentName = null)
        {
            NotNull(value, argumentName);

            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"value can not be empty or whitespace.", argumentName ?? nameof(value));
            }
        }
    }
}
