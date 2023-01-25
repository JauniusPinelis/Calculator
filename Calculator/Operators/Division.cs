using Calculator.Operators.Base;

namespace Calculator.Operations;

public class Division : BinaryOperator
{
    public Division(object operand1, object operand2) : base(operand1, operand2)
    {
    }

    public override double GetResult()
    {
        return _operand1Value / _operand2Value;
    }

    public override string GetExpression()
    {
        return $"({_operand1Expression} / {_operand2Expression})";
    }

    public override string GetExpressionSentence()
    {
        return $"division of {_operand1ExpressionSentence} by {_operand2ExpressionSentence}";
    }
}
