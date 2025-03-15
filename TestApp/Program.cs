namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======Mathematical action=======");

            Console.Write("Enter num1: ");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter num2: ");

            decimal num2 = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine($"Result:{num1+num2}");

        }
    }
}
