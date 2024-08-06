using CalculatorApp.Enums;

namespace CalculatorApp.Models
{
    public class Operation
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public OperationType OperationType { get; set; }

        public Operation (double number1, double number2, OperationType operationType)
        {
            Number1 = number1;
            Number2 = number2;
            OperationType = operationType;
        }
    }
}