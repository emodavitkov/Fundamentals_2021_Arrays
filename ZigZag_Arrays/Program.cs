using System;
using System.Linq;

namespace ZigZag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program which creates 2 arrays.You will be given an integer n.
            //On the next n lines you get 2 integers.

            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] currentArr = Console.ReadLine()
                         .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                         .Select(int.Parse)
                         .ToArray();

                if (i % 2 == 0)
                {
                    arr1[i] = currentArr[0];
                    arr2[i] = currentArr[1];

                }

                else
                {
                    arr1[i] = currentArr[1];
                    arr2[i] = currentArr[0];
                }


            }
            Console.WriteLine(String.Join(" ",arr1));
            Console.WriteLine(String.Join(" ",arr2));

        }
    }
}
