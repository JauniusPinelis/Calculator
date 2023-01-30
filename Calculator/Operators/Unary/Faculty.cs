namespace Calculator.Operators.Unary;

public class Faculty : UnaryOperator
{
    public Faculty(Operator operand) : base(operand)
    {
    }

    public override string GetExpression()
    {
        return $"({_operand.GetExpression()}!)";
    }

    public override string GetExpressionSentence()
    {
        return $"faculty of {_operand.GetExpressionSentence()}";
    }

    public override double GetResult()
    {
        return Enumerable.Range(1, (int)_operand.GetResult()).Aggregate(1, (p, item) => p * item);
    }
}
