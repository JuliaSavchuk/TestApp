namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======Mathematical action=======");
//1
            Console.Write("Enter num1: ");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());
//2
            Console.Write("Enter num2: ");

            decimal num2 = Convert.ToDecimal(Console.ReadLine());
//3
            Console.WriteLine("Choose operation (+, -, *, /): ");
            string operation = Console.ReadLine();

            decimal result = 0;
            bool isValidOperation = true;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        isValidOperation = false;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    isValidOperation = false;
                    break;
            }

            if (isValidOperation)
                Console.WriteLine($"Result: {result}");
        }

    }
}
