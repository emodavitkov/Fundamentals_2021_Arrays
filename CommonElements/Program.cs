using System;
using System.Linq;
namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program, which prints common elements in two arrays. You have to compare the elements of the second array to the elements of the first.
            string[] arr1 = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries);


            string[] arr2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string secondElement in arr2)
            {
                foreach (string firstElement in arr1)
                {
                    if (secondElement==firstElement)
                    {
                        Console.Write($"{firstElement} ");
                    }
                    
                }

            }

            Console.WriteLine();
            //string[] arr1 = Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .ToArray();


            //string[] arr2 = Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .ToArray();

            //string match = String.Empty;
            //string space = " ";

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    for (int j = 0; j < arr1.Length; j++)
            //    {
            //        if (arr2[i]==arr1[j])
            //        {
            //            match += arr2[i] + space;
            //        }
            //    }
            //}

            //Console.WriteLine(match);
        }
    }
}
