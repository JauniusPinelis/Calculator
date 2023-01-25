using Calculator.Operations;
using FluentAssertions;

namespace Calculator.UnitTests
{
    public class ComplexOperatorTests
    {
        [Fact]
        public void ComplexTest()
        {
            var result = new Sum(new Division(20, 4), 1);

            result.ToResult().Should().Be(6);
            result.PrintSentence().Should().Be("sum of division of 20 by 4 and 1 is 6");
        }

        [Fact]
        public void ComplexTest2()
        {
            var result = new Sum(new Division(20, 2), new Faculty(2));

            result.ToResult().Should().Be(12);
            result.PrintSentence().Should().Be("sum of division of 20 by 2 and faculty of 2 is 12");
        }
    }
}
