using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators.Base
{
    public abstract class Operator
    {
        public double ToResult()
        {
            return GetResult();
        }

        public string Print()
        {
            return $"{GetExpression()} = {ToResult()}";
        }

        public string PrintSentence()
        {
            return $"{GetExpressionSentence()} is {ToResult()}";
        }

        public abstract double GetResult();

        public abstract string GetExpression();

        public abstract string GetExpressionSentence();
    }
}
