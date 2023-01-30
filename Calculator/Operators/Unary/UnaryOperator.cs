using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators.Unary;

public abstract class UnaryOperator : Operator
{
    protected double _operandValue;

    protected string _operandExpression;

    protected string _operandExpressionSentence;

    public UnaryOperator(object operand)
    {
        if (operand is Operator operation)
        {
            _operandValue = operation.GetResult();
            _operandExpression = operation.GetExpression();
            _operandExpressionSentence = operation.GetExpressionSentence();
        }
        else
        {
            _operandValue = Convert.ToDouble(operand);
            _operandExpression = _operandValue.ToString();
            _operandExpressionSentence = _operandValue.ToString();
        }
    }

}
