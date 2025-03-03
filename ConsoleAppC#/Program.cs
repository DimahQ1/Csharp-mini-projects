using ConsoleAppC_;
using System;
using System.Net.Http.Headers;
// This Program for manage calculator class
class Program
{
    // Method For Check Number IsValid or NOT!
    static double GetValidNumber(string prompt)
    {
        double number;
        while (true)
        {
            Console.WriteLine(prompt);
            if(double.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            Console.WriteLine("Error: Invalid input, Please Enter A Valid Number: ");
        }
    }
    // Method For Check Operator Is Valid Or NOT
    static char GetValidOperator()
    {
        char op;
        while (true)
        {
            Console.WriteLine("Enter Operator ( * , / , - , + )");
            if(char.TryParse(Console.ReadLine(), out op) && "+/-*".Contains(op))
            {
                return op;
            }
            Console.WriteLine("Error: Invalid Operator! Please Enter A Valid Operator");
        }
    }
    static void Main()
    {
        // Define Calculator Class
        Calculator calculator = new Calculator();

        // Define A Loop For Unlimited Calculating :)
        while (true)
        {
            try
            {
                // Variables && Calls
                double n1 = GetValidNumber("Enter first number: ");
                char sign = GetValidOperator();
                double n2 = GetValidNumber("Enter second number: ");
                double result = calculator.Calculate(n1, n2, sign);

                // Result Section
                Console.WriteLine($"{n1} {sign} {n2} = {result}");
            }
            catch(Exception e)
            {
                // Simple Exception Message
                Console.WriteLine("Error: " + e.Message);
            }
            Console.WriteLine("Do you want another calculation? y or n");
            if(Console.ReadLine().ToLower() != "y")
            {
                break;
            }
        }
    }
}
