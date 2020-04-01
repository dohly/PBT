using FsCheck;
using FsCheck.Xunit;

namespace CSharp
{
    public class FsCheckTests
    {

        [Property(DisplayName = "A+0=A")]
        public Property IdentityProperty(int a, int b)
            => (MyMath.Add(a, 0) == a)
            .ToProperty();

        [Property(DisplayName = "A+B=B+A")]
        public Property CommutativeProperty(int a, int b)
            => (MyMath.Add(a, b) == MyMath.Add(b, a))
            .ToProperty();

        [Property(DisplayName = "(A+B)+C=A+(B+C)")]
        public Property AssociativityProperty(int a, int b, int c)
            => (MyMath.Add(MyMath.Add(a, b), c) == MyMath.Add(a, MyMath.Add(b, c)))
            .ToProperty();

        [Property]
        public Property ShrinkerDemo(int a)
            => (a < 81)
            .ToProperty();

        [Property(DisplayName = "A+B > A if B > 0")]
        public Property GeneratorDemo(int a, int b)
            => (MyMath.Add(a, b) > a)
            .When(b > 0);
    }
}
