using Fibonacci.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Tests
{
    internal class FibonacciData : IEnumerable<object[]>
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<object[]> IEnumerable<object[]>.GetEnumerator()
        {

            yield return new object[] {
                13,
                new FibonacciResult
                {
                    IsFibonacci = true,
                    Iterations = 7, 
                    CurrentDigit = 13
                }
            };

            yield return new object[] {
                8,
                new FibonacciResult
                {
                    IsFibonacci = true,
                    Iterations = 6,
                    CurrentDigit = 8
                }
            };

            yield return new object[] {
                7,
                new FibonacciResult
                {
                    IsFibonacci = false,
                    Iterations = 6,
                    CurrentDigit = 8
                }
            };

        }
    }
}
