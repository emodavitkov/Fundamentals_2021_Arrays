using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to read an array of integers and condense them by summing adjacent couples of elements until a single integer is obtained.
            //For example, if we have 3 elements { 2, 10, 3}, we sum the first two and the second two elements and obtain { 2 + 10, 10 + 3} = { 12, 13}, 
            //then we sum again all adjacent elements and obtain { 12 + 13} = { 25}.

            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //            While we have more than one element in the array nums[], repeat the following:
            //•	Allocate a new array condensed[] of size nums.Length - 1.
            //•	Sum the numbers from nums[] to condensed[]:
            //o condensed[i] = nums[i] + nums[i + 1]
            //•	nums[] = condensed[]

            

            while (arr.Length-1>0)
            {
                int[] condensedArr = new int[arr.Length - 1];

                for (int i = 0; i < condensedArr.Length; i++)
                {
                    condensedArr[i] = arr[i] + arr[i + 1];
                }

                arr = condensedArr;

            }

           
            Console.WriteLine(arr[0]);



        }
    }
}
