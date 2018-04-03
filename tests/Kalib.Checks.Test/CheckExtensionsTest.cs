using System;
using Xunit;
using Kalib.Checks.Extensions;

namespace Kalib.Checks.Test
{
    public class CheckExtensionsTest
    {
        [Fact]
        public void CheckNull()
        {
            string value = null;
            Assert.Throws<ArgumentNullException>(() => value.NotNull(nameof(value)));
        }

        [Fact]
        public void CheckEmpty()
        {

            string value = null;
            Assert.Throws<ArgumentNullException>(() => value.NotEmpty(nameof(value)));

            value = "";
            Assert.Throws<ArgumentException>(() => value.NotEmpty(nameof(value)));
        }


        [Fact]
        public void CheckWhitespace()
        {

            string value = null;
            Assert.Throws<ArgumentNullException>(() => value.NotEmpty(nameof(value)));

            value = " ";
            Assert.Throws<ArgumentException>(() => value.NotWhitespace(nameof(value)));
        } 
    }
}
