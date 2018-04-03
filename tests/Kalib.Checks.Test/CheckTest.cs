using System;
using System.Collections.Generic;
using Xunit;

namespace Kalib.Checks.Test
{
    public class CheckTest
    {
        [Fact]
        public void NotNull()
        {
            DateTime? dateTime = null;

            Assert.Throws<ArgumentNullException>(() => Check.NotNull(dateTime, nameof(dateTime)));
        }

        [Fact]
        public void NotEmpty()
        {
            string value = string.Empty;
            Assert.Throws<ArgumentException>(() => Check.NotEmpty(value, nameof(value)));

            IReadOnlyList<int> list = new List<int>();
            Assert.Throws<ArgumentException>(() => Check.NotEmpty(list, nameof(list)));
        }

        [Fact]
        public void NotWhitespace()
        {
            string value = " ";
            Assert.Throws<ArgumentException>(() => Check.NotWhitespace(value, nameof(value)));
        }
    }
}