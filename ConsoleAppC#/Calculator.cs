using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppC_
{
    class Calculator
    {
        // Define Calculator Method And Getting Numbers For Calculating
        public double Calculate(double n1, double n2 , char op)
        {
            switch (op)
            {
                case '+': return n1 + n2;
                case '-': return n1 - n2;
                case '*': return n1 * n2;
                case '/':
                    // Exception Handling For DivisionByZero Error
                    if (n2 == 0)
                    {
                        throw new DivideByZeroException("Error: Division by zero is not allowed.");
                    }
                    return n1 / n2;
                // Exception Handling For Any Exception:)
                default: throw new ArgumentException("Invalid operator try these : *, /, -, +");
            }
        }
    }
}
