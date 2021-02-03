using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    sum = arr[i] + arr[j];

                    if (number==sum)
                    {
                        Console.WriteLine($"{arr[i]} {arr[j]}");
                    }

                }

            }

        }
    }
}
