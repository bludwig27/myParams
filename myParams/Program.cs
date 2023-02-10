using System;
using System.Globalization;

namespace myParams
{
    class Program
    {
        static int Add(params int[] numbers)
        {
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }
            return total;
        }
        static int Mult(params int[] numbers)
        {
            int total = 1;
            foreach (int number in numbers)
            {
                total *= number;
            }
            return total;
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("How many values would you like to generate?");
            int nums = int.Parse(Console.ReadLine());
            int[] numbers = new int[nums];
            Console.WriteLine("Your randomly generated values are:");
            for (int i = 0; i < nums;i++)
            {
                numbers[i] = r.Next(1,10);
                Console.WriteLine(numbers[i]);
            }
            //for debugging
            //Array.ForEach(numbers, Console.WriteLine);
            Console.WriteLine($"Sum of the numbers array={Add(numbers)}");
            Console.WriteLine();
            Console.WriteLine($"Product of the numbers array={Mult(numbers)}");
            Console.WriteLine();
            Console.WriteLine("Thank you for using our program!");
        }
    }
}
