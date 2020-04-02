using System;
using Xunit;
using MyMathLibrary;

namespace CSharp
{
    public class PropertyBasedTests_Refactored
    {
        private delegate bool Property(int a, int b);
        private void Check(Property property)
        {
            var rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                var a = rand.Next();
                var b = rand.Next();
                var result = property(a, b);
                Assert.True(result);
            }
        }

        private Property IdentityProperty
            => (a, _)
            => MyMath.Add(a, 0) == a;

        private Property CommutativeProperty
            => (a, b)
            => MyMath.Add(a, b) == MyMath.Add(b, a);

        private Property AssociativityProperty
            => (a, b)
            =>
            {
                var c = new Random().Next();
                var result1 = MyMath.Add(MyMath.Add(a, b), c);
                var result2 = MyMath.Add(a, MyMath.Add(b, c));
                return result1 == result2;
            };



        [Fact(DisplayName = "A+0=A")]
        public void IdentityTest()
            => Check(IdentityProperty);

        [Fact(DisplayName = "A+B=B+A")]
        public void CommutativityTest()
            => Check(CommutativeProperty);

        [Fact(DisplayName = "(A+B)+C=A+(B+C)")]
        public void AssocitiativityTest() 
            => Check(AssociativityProperty);


    }
}
