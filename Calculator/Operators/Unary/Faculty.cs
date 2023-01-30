using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators.Unary
{
    public class Faculty : UnaryOperator
    {
        public Faculty(object operand) : base(operand)
        {
        }

        public override string GetExpression()
        {
            return $"({_operandExpression}!)";
        }

        public override string GetExpressionSentence()
        {
            return $"faculty of {_operandExpressionSentence}";
        }

        public override double GetResult()
        {
            return Enumerable.Range(1, (int)_operandValue).Aggregate(1, (p, item) => p * item);
        }
    }
}
