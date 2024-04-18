using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an operation (^, %, ^2, Ave):");
            string operation = Console.ReadLine();

            double result;

            switch (operation)
            {
                case "^":
                    result = Math.Pow(num1, num2);
                    break;
                case "%":
                    result = num1 % num2;
                    break;
                case "^2":
                    result = num1 * num2;
                    break;
                case "Ave":
                    result = (num1 + num2) / 2;
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    return;
            }

            Console.WriteLine($"The result is: {result}");
            Console.ReadLine();
        }
    }
}