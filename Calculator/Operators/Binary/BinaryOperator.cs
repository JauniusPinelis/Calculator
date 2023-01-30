
namespace Calculator.Operators.Binary;

public abstract class BinaryOperator : Operator
{
        protected readonly Operator _operand1;
        protected readonly Operator _operand2;

    public BinaryOperator(Operator operand1, Operator operand2)
    {
        _operand1 = operand1;
        _operand2 = operand2;
    }
}
