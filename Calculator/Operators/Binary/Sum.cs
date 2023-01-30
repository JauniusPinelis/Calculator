using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators.Binary
{
    public class Sum : BinaryOperator
    {
        public Sum(Operator operand1, Operator operand2) : base(operand1, operand2)
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
