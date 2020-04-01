using System;
using Xunit;

namespace CSharp
{
    public class ExampleBasedTests
    {
        [Fact(DisplayName = "When I add 1 + 3, I expect 4")]
        public void Add1And3ShouldBe4()
        {
            var result = MyMath.Add(1, 3);
            Assert.Equal(4, result);
        }
        [Fact(DisplayName = "When I add 2 + 2, I expect 4")]
        public void Add2And2ShouldBe4()
        {
            var result = MyMath.Add(2, 2);
            Assert.Equal(4, result);
        }
        [Fact(DisplayName = "When I add -1 + 3, I expect 2")]
        public void AddMinus1And3ShouldBe2()
        {
            var result = MyMath.Add(-1, 3);
            Assert.Equal(2, result);
        }

        [Theory(DisplayName = "When I add two numbers, I expect to get their sum")]
        [InlineData(1, 3, 4)]
        [InlineData(2, 2, 4)]
        [InlineData(-1, 3, 2)]
        [InlineData(27, 15, 42)]
        public void AddTwoNumbersShouldReturnSum(int a, int b, int expected)
        {
            var result = MyMath.Add(a, b);
            Assert.Equal(expected, result);
        }
    }
}
