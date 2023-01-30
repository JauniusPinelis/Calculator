using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators.Unary;

public abstract class UnaryOperator : Operator
{
    protected readonly Operator _operand;

    public UnaryOperator(Operator operand)
    {
        _operand = operand;
    }

}
