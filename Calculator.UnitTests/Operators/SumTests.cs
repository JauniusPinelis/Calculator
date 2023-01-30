using Calculator.Operators.Binary;
using FluentAssertions;

namespace Calculator.UnitTests.Operators;

public class SumTests
{
    [Fact]
    public void ToResult_GivenValidOperands_SumsCorrectly()
    {
        var sum = new Sum(1, 1);
        sum.ToResult().Should().Be(2);
    }

    [Fact]
    public void Print_GivenValidOperands_PrintsCorrectly()
    {
        var sum = new Sum(1, 1);
        sum.Print().Should().Be("(1 + 1) = 2");
    }

    [Fact]
    public void PrintSentence_GivenValidOperands_PrintsSentenceCorrectly()
    {
        var sum = new Sum(1, 1);
        sum.PrintSentence().Should().Be("sum of 1 and 1 is 2");
    }
}
