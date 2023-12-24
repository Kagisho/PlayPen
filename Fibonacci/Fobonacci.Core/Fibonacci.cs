namespace Fibonacci.Core
{
    public class Fibonacci
    {
        public void CalculateFibonacci(int startDigit, ref FibonacciResult? result)
        {
            if (result == null)
            {
                Console.WriteLine("Isnull");
                result = new FibonacciResult
                {
                    CurrentDigit = 1,
                    PreviousDigit = 0,
                    Iterations = 1
                };
            }
            else
            {
                Console.WriteLine("not null");
            }

            var tempDigit = result.CurrentDigit + result.PreviousDigit;
            result.PreviousDigit = result.CurrentDigit;
            result.CurrentDigit = tempDigit;
            result.Iterations += 1;

            Console.WriteLine($"Is Fibonacci: {result.IsFibonacci}");
            Console.WriteLine($"Iterations: {result.Iterations}");

            if (result.CurrentDigit == startDigit)
            {
                result.IsFibonacci = true;
            }
            else
            if (result.CurrentDigit < startDigit)
                CalculateFibonacci(startDigit, ref result);

        }

    }
}