using System;
using System.Linq;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            //Read an array of real numbers (space separated), round them in "away from 0" style and print the output as in the examples:
            //1.5 => 2
            double[] realNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            foreach (var item in realNumbers)
            {
                if (item == -0)
                {
                    Console.WriteLine($"0 => 0");
                }
                else
                {
                    Console.WriteLine($"{item} => {(int)Math.Round(item, MidpointRounding.AwayFromZero)}");
                }
            }

            //float[] arr = Console.ReadLine()
            //    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //    .Select(float.Parse)
            //    .ToArray();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    
            //        Console.WriteLine($"{arr[i]} => {Math.Round(arr[i], MidpointRounding.AwayFromZero)}");
            //   


             //}
        }
    }
}
