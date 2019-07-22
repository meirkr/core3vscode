using System;
using Xunit;

namespace MyUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var c = new ClassLib.Class1();
            object something = "hello";
            var result = c.Echo(something);

            Assert.Equal(something, result);

        }
    }
}
