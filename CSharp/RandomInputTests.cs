using System;
using Xunit;
using MyMathLibrary;

namespace CSharp
{
    public class RandomInputTests
    {
        [Fact(DisplayName= "`When I add two random numbers (100 times)," +
                           " I expect their sum to be correct")]
        public void RandomNumbersTest()
        {
            var rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                var a = rand.Next();
                var b = rand.Next();
                var expected = a + b; // <===!!!!!
                var result = MyMath.Add(a, b);
                Assert.Equal(expected, result);
            }
        }


    }
}
