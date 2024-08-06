using System.Security.Cryptography;
using CalculatorApp.Enums;
using CalculatorApp.Interfaces;

namespace CalculatorApp.Services
{
    public class CalculatorService : ICalculatorService
    {
        public double Calculate(double num1, double num2, OperationType operationType)
        {
            return operationType switch
            {
                OperationType.Addition => num1 + num2,
                OperationType.Subtraction => num1 - num2,
                OperationType.Multiplication => num1 * num2,
                OperationType.Division => num2 != 0 ? num1 / num2 : throw new DivideByZeroException("Cannot divide by zero"),
                _=> throw new ArgumentException("Invalid operation type"),
            };
        }
    }
}