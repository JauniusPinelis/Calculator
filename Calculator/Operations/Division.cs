using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations;

public class Division : Operation
{
    public Division(object operand1, object operand2) : base(operand1, operand2)
    {
    }

    protected override double Process()
    {
        return _operand1Value / _operand2Value;
    }

    protected override string GetExpression()
    {
        return $"({_operand1Expression} / {_operand2Expression})";
    }

    protected override string GetExpressionSentence()
    {
        return $"division of {_operand1ExpressionSentence} by {_operand2ExpressionSentence}";
    }
}
