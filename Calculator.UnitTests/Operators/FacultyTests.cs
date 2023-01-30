using Calculator.Operators.Unary;
using FluentAssertions;

namespace Calculator.UnitTests.Operators
{
    public class FacultyTests
    {

        [Fact]
        public void ToResult_GivenValidOperands_FacultiesCorrectly()
        {
            var faculty = new Faculty(5);
            faculty.ToResult().Should().Be(120);
        }

        [Fact]
        public void Print_GivenValidOperands_PrintsCorrectly()
        {
            var faculty = new Faculty(5);
            faculty.Print().Should().Be("(5!) = 120");
        }

        [Fact]
        public void PrintSentence_GivenValidOperands_PrintsSentenceCorrectly()
        {
            var faculty = new Faculty(5);
            faculty.PrintSentence().Should().Be("faculty of 5 is 120");
        }
    }
}
