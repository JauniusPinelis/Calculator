using Calculator.Operators.Binary;
using FluentAssertions;

namespace Calculator.UnitTests.Operators;

public class DivisionTests
{
    [Fact]
    public void ToResult_ExpressionWithNumbers_CalculatesCorrectly()
    {
        var test = new Division(8, 4);

        test.ToResult().Should().Be(2);
    }

    [Fact]
    public void ToResult_OperationWithOperation_CalculatesCorrectly()
    {
        var test = new Division(8, new Division(8, 4));

        test.ToResult().Should().Be(4);
    }

    [Fact]
    public void ToResult_ComplexOperation_CalculatesCorrectly()
    {
        var test = new Division(new Division(8, 4), new Division(8, 4));

        test.ToResult().Should().Be(1);
    }

    [Fact]
    public void Print_GivenOperation_ParsesCorrectly()
    {
        var test = new Division(8, 4);

        test.Print().Should().Be("(8 / 4) = 2");
    }

    [Fact]
    public void Print_GivenValidDivision2_ParsesCorrectly()
    {
        var test = new Division(8, new Division(4, 2));

        test.Print().Should().Be("(8 / (4 / 2)) = 4");
    }

    [Fact]
    public void PrintSentence_GivenValidDivision_PrintsCorrectly()
    {
        var test = new Division(8, new Division(4, 2));

        test.PrintSentence().Should().Be("division of 8 by division of 4 by 2 is 4");
    }
}
