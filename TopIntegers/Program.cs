using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {

            // 14 24 3  19 15 17	-> 24 19 17
            // i0 i1 i2 i3 i4 i5

            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
           
            

            for (int i = 0; i < arr.Length; i++)
            {
                bool topIntegerTrue = true;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        topIntegerTrue = false;
                        break;
                    }
              
                }
                
                if (topIntegerTrue)
                {
                    Console.Write($"{arr[i]} ");
                }

               

            }
            Console.WriteLine();
        }
    }
}
