

namespace Calculator.Operators;

public abstract class Operator
{
    public double ToResult()
    {
        return GetResult();
    }

    public string Print()
    {
        return $"{GetExpression()} = {ToResult()}";
    }

    public string PrintSentence()
    {
        return $"{GetExpressionSentence()} is {ToResult()}";
    }

    public static implicit operator Operator(double value) => new NumericOperator(value);

    public abstract double GetResult();

    public abstract string GetExpression();

    public abstract string GetExpressionSentence();
}
