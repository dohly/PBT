using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharp
{
    public class PropertyBasedTests
    {

        [Fact(DisplayName = "A+0=A")]
        public void IdentityTest()
        {
            var rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                var a = rand.Next();
                var result1 = MyMath.Add(a, 0);
                var result2 = a;
                Assert.Equal(result1, result2);
            }
        }



        [Fact(DisplayName = "A+B=B+A")]
        public void CommutativityTest()
        {
            var rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                var a = rand.Next();
                var b = rand.Next();
                var result1 = MyMath.Add(a, b);
                var result2 = MyMath.Add(b, a);
                Assert.Equal(result1, result2);
            }
        }


        [Fact(DisplayName = "(A+B)+C=A+(B+C)")]
        public void AssocitiativityTest()
        {
            var rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                var a = rand.Next();
                var b = rand.Next();
                var c = rand.Next();
                var result1 = MyMath.Add(MyMath.Add(a, b), c);
                var result2 = MyMath.Add(a, MyMath.Add(b, c));
                Assert.Equal(result1, result2);
            }
        }


    }
}
