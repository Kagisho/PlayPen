using Fibonacci.Core;

namespace Fibonacci.Tests
{
    public class FibonacciCalculatorTests
    {
        [Theory]
        [ClassData(typeof(FibonacciData))]

        public void Calculate_Tests(int input, FibonacciResult expected)
        {
            var calculator = new Core.Fibonacci();
            FibonacciResult? result = null;
            calculator.CalculateFibonacci(input, ref result);
            
            Assert.Equal(expected.IsFibonacci, result?.IsFibonacci);
            Assert.Equal(expected.Iterations, result?.Iterations);
            Assert.Equal(expected.CurrentDigit, result?.CurrentDigit);
        }
    }
}