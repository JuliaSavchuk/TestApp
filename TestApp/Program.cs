using System;

namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======= Mathematical Action =======");

            decimal num1 = GetValidNumber("Enter num1: ");
            decimal num2 = GetValidNumber("Enter num2: ");
            string operation = GetValidOperation();

            decimal result = PerformCalculation(num1, num2, operation);

            Console.WriteLine($"Result: {result}");
        }

        static decimal GetValidNumber(string prompt)
        {
            decimal number;
            while (true)
            {
                Console.Write(prompt);
                if (decimal.TryParse(Console.ReadLine(), out number))
                    return number;

                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        static string GetValidOperation()
        {
            while (true)
            {
                Console.Write("Choose operation (+, -, *, /): ");
                string operation = Console.ReadLine();

                if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
                    return operation;

                Console.WriteLine("Invalid operation. Please choose one of the following: +, -, *, /");
            }
        }

        static decimal PerformCalculation(decimal num1, decimal num2, string operation)
        {
            return operation switch
            {
                "+" => num1 + num2,
                "-" => num1 - num2,
                "*" => num1 * num2,
                "/" when num2 != 0 => num1 / num2,
                "/" => throw new DivideByZeroException("Error: Division by zero is not allowed."),
                _ => 0 // Цей випадок не досяжний через валідацію, але потрібен для компіляції
            };
        }
    }
}
