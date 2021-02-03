using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            bool isEqual = false;
            

           
            for (int i = 0; i < arr.Length; i++)
            {
                int sumLeft = 0;
               
                for (int j = i-1; j >= 0; j--)
                {
                        sumLeft += arr[j];   
                }

                int sumRight = 0;

                for (int j = i+1; j < arr.Length; j++)
                {
                    sumRight += arr[j];
                }

                if (sumLeft==sumRight)
                {
                    isEqual = true;
                    Console.WriteLine(i);
                    break;
                }

                

            }
            if (!isEqual)
            {
                Console.WriteLine("no");

            }
        }
    }
}
