using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that receives an array and number of rotations you have to perform (first element goes at the end) 
            //Print the resulting array.
            int[] arr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int rotations = int.Parse(Console.ReadLine());
            int firstNumber = 0;

            for (int rotation = 0; rotation < rotations; rotation++)
            {
                firstNumber = arr[0];
                for (int i = 0; i < arr.Length-1; i++)
                {
                    
                    arr[i] = arr[i + 1];
                    
                }
                arr[arr.Length - 1] = firstNumber;
            }

            foreach (int item in arr)
            {
                
                Console.Write($"{item} ");
            }



        }
    }
}
