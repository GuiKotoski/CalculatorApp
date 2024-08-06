using Xunit;
using CalculatorApp.Enums;
using CalculatorApp.Services;

namespace CalculatorApp.Tests
{
    private readonly CalculatorService _calculatorService;

    public CalculatorServiceTests()
    {
        _calculatorService = new CalculatorService();
    }

    [Theory]
    [InlineData(3, 2, OperationType.Addition, 5)]
    [InlineData(3, 2, OperationType.Subtraction, 1)]
    [InlineData(3, 2, OperationType.Multiplication, 6)]
    [InlineData(6, 2, OperationType.Division, 3)]
    public void Calculate_ShouldReturnExpectedResult(double num1, double num2, OperationType operationType, double expectedResult)
    {
        //Act
        var result = _calculatorService.Calculate(num1, num2, operationType);
        
        //Assert
        Assert.Equal(expectedResult, result);
    }
}