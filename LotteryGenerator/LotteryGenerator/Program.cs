using System;
using System.Linq;

namespace LotteryGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            const int countOfNumbersToGenerate = 5;
            const int maxNumberToGenerate = 31;
            Random random = new Random();
            int[] numbers = Enumerable
                .Repeat(0, countOfNumbersToGenerate)
                .Select(i => random.Next(1, maxNumberToGenerate + 1))
                .ToArray();
            Console.WriteLine("Generated numbers:");
            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine();
            Console.WriteLine("Press enter to close");
            Console.ReadLine();
        }
    }
}
