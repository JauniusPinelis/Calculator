namespace Calculator.Operators.Binary;

public class Sum : BinaryOperator
{
    public Sum(Operator operand1, Operator operand2) : base(operand1, operand2)
    {
    }

    public override string GetExpression()
    {
        return $"({_operand1.GetExpression()} + {_operand2.GetExpression()})";
    }

    public override string GetExpressionSentence()
    {
        return $"sum of {_operand1.GetExpressionSentence()} and {_operand2.GetExpressionSentence()}";
    }

    public override double GetResult()
    {
        return _operand1.GetResult() + _operand2.GetResult();
    }
}
