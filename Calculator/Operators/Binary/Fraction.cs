using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators.Binary
{
    public class Fraction : BinaryOperator
    {
        public Fraction(object operand1, object operand2) : base(operand1, operand2)
        {
        }

        public override string GetExpression()
        {
            throw new NotImplementedException();
        }

        public override string GetExpressionSentence()
        {
            throw new NotImplementedException();
        }

        public override double GetResult()
        {
            throw new NotImplementedException();
        }
    }
}
