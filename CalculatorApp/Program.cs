using System;
using CalculatorApp.Enums;
using CalculatorApp.Models;
using CalculatorApp.Services;

namespace CalculatorApp
{
    class Program
    {
        static void Main (string[] args)
        {
            var CalculatorService = new CalculatorService();
            
           Console.WriteLine("Enter first number:"); 
            double num1 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Enter second number:"); 
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter operation(Addition, Subtraction, Multiplication, Division):");
            string operationInput = Console.ReadLine()!;
            OperationType operationType = Enum.Parse<OperationType>(operationInput, true);

            double result = CalculatorService.Calculate(num1, num2, operationType);

            Console.WriteLine($"Result: {result}");
        } 
    }
}