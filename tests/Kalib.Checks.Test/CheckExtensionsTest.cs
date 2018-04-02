using System;
using Xunit;
using Kalib.Checks;

namespace Kalib.Checks.Test
{
    public class CheckExtensionsTest
    {
        [Fact]
        public void CheckNull()
        {
            string value = null;
            Assert.Throws<ArgumentNullException>(() => value.CheckNull(nameof(value)));
        }

        [Fact]
        public void CheckEmpty()
        {

            string value = null;
            Assert.Throws<ArgumentNullException>(() => value.CheckEmpty(nameof(value)));

            value = "";
            Assert.Throws<ArgumentException>(() => value.CheckEmpty(nameof(value)));
        }


        [Fact]
        public void CheckWhitespace()
        {

            string value = null;
            Assert.Throws<ArgumentNullException>(() => value.CheckEmpty(nameof(value)));

            value = " ";
            Assert.Throws<ArgumentException>(() => value.CheckWhitespace(nameof(value)));
        } 
    }
}
