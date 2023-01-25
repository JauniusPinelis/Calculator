using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Operators.Base;

namespace Calculator.Operations
{
    public class Sum : BinaryOperator
    {
        public Sum(object operand1, object operand2) : base(operand1, operand2)
        {
        }

        public override string GetExpression()
        {
            return $"({_operand1Expression} + {_operand2Expression})";
        }

        public override string GetExpressionSentence()
        {
            return $"sum of {_operand1ExpressionSentence} and {_operand2ExpressionSentence}";
        }

        public override double GetResult()
        {
            return _operand1Value + _operand2Value;
        }
    }
}
