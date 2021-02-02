using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
          

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                arr[i] = number;

            }

            foreach (var item in arr)
            {
                Console.Write($"{item} ");
                
            }
            Console.WriteLine();
            Console.WriteLine($"{arr.Sum()}");

        }
    }
}
