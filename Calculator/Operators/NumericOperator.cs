

namespace Calculator.Operators;

public class NumericOperator : Operator
{
    private readonly double _value;

    public NumericOperator(double value)
    {
        _value = value;
    }

    public override string GetExpression()
    {
        return _value.ToString();
    }

    public override string GetExpressionSentence()
    {
        return _value.ToString();
    }

    public override double GetResult()
    {
        return _value;
    }
}
