using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators.Base
{
    public abstract class BinaryOperator : Operator
    {
        protected double _operand1Value;
        protected double _operand2Value;

        protected string _operand1Expression;
        protected string _operand2Expression;

        protected string _operand1ExpressionSentence;
        protected string _operand2ExpressionSentence;

        public BinaryOperator(object operand1, object operand2)
        {
            if (operand1 is Operator operation)
            {
                _operand1Value = operation.GetResult();
                _operand1Expression = operation.GetExpression();
                _operand1ExpressionSentence = operation.GetExpressionSentence();
            }
            else
            {
                _operand1Value = Convert.ToDouble(operand1);
                _operand1Expression = _operand1Value.ToString();
                _operand1ExpressionSentence = _operand1Value.ToString();
            }

            if (operand2 is Operator operation2)
            {
                _operand2Value = operation2.GetResult();
                _operand2Expression = operation2.GetExpression();
                _operand2ExpressionSentence = operation2.GetExpressionSentence();
            }
            else
            {
                _operand2Value = Convert.ToDouble(operand2);
                _operand2Expression = _operand2Value.ToString();
                _operand2ExpressionSentence = _operand2Value.ToString();
            }
        }
    }
}
