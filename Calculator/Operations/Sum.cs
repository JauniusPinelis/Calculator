using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    public class Sum : Operation
    {
        public Sum(object operand1, object operand2) : base(operand1, operand2)
        {
        }

        protected override string GetExpression()
        {
            throw new NotImplementedException();
        }

        protected override string GetExpressionSentence()
        {
            throw new NotImplementedException();
        }

        protected override double Process()
        {
            return _operand1Value + _operand2Value;
        }
    }
}
