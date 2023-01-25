using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    public abstract class Operation : IOperation
    {
        protected double _operand1Value;
        protected double _operand2Value;

        protected string _operand1Expression;
        protected string _operand2Expression;

        protected string _operand1ExpressionSentence;
        protected string _operand2ExpressionSentence;

        public Operation(object operand1, object operand2)
        {
            if (operand1 is Operation operation)
            {
                _operand1Value = operation.Process();
                _operand1Expression = operation.GetExpression();
                _operand1ExpressionSentence = operation.GetExpressionSentence();
            }
            else
            {
                _operand1Value = Convert.ToDouble(operand1);
                _operand1Expression = _operand1Value.ToString();
                _operand1ExpressionSentence = _operand1Value.ToString();
            }

            if (operand2 is Operation operation2)
            {
                _operand2Value = operation2.Process();
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

        public double ToResult()
        {
            return Process();
        }

        public string Print()
        {
            return $"{GetExpression()} = {ToResult()}";
        }

        public string PrintSentence()
        {
            return $"{GetExpressionSentence()} is {ToResult()}";
        }

        protected abstract double Process();

        protected abstract string GetExpression();

        protected abstract string GetExpressionSentence();
    }
}
