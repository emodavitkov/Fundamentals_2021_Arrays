using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int longestSequence = 0;
            int currentSequence = 0;
            int longestSequenceIndex = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i]==arr[j])
                    {        
                        currentSequence++;   
                    }
                    else
                    {
                        break;
                    }
                }

                if (longestSequence<currentSequence)
                {
                    longestSequence = currentSequence;
                    longestSequenceIndex = arr[i];
                }

                currentSequence = 0;

            }

            for (int k = 0; k <= longestSequence; k++)
            {
                Console.Write($"{longestSequenceIndex} ");
            }
            
        }
    }
}
