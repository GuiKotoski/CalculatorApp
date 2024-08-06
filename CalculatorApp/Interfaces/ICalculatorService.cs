using CalculatorApp.Enums;

namespace CalculatorApp.Interfaces
{
    public interface ICalculatorService
    {
        double Calculate(double num1, double num2, OperationType operationType);
    }
}