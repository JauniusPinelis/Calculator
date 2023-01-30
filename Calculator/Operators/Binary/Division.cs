namespace Calculator.Operators.Binary;

public class Division : BinaryOperator
{
    public Division(Operator operand1, Operator operand2) : base(operand1, operand2)
    {
    }

    public override double GetResult()
    {
        return _operand1.GetResult() / _operand2.GetResult();
    }

    public override string GetExpression()
    {
        return $"({_operand1.GetExpression()} / {_operand2.GetExpression()})";
    }

    public override string GetExpressionSentence()
    {
        return $"division of {_operand1.GetExpressionSentence()} by {_operand2.GetExpressionSentence()}";
    }
}
