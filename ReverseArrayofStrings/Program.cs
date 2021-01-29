using System;
using System.Linq;

namespace ReverseArrayofStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Read an array of strings (space separated values), reverse it and print its elements

            string[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            for (int i = 0; i < arr.Length/2; i++)
            {
                string oldElement = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = oldElement;
            }
            Console.WriteLine(string.Join(" ",arr));


            //option 2
            //string[] arrayOfStrings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
            //foreach (var item in arrayOfStrings)
            //{
            //    Console.Write($"{item} ");
            //}


            //option 3
            //string[] arr = Console.ReadLine()
            //    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
            //    .ToArray();

            //Console.WriteLine(string.Join(' ',arr.Reverse()));



        }
    }
}
