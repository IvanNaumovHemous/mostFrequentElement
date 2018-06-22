using System;
using System.Collections.Generic;
using System.Linq;

namespace maxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] array = GetMostFrequentElements(numbers);
            PrintArray(array);

        }

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static int[] GetMostFrequentElements(List<int> numbers)
        {
            int current = 1;
            int max = 0;
            int index = 0;
            int maxIndex = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    current++;
                    index = numbers[i];
                }
                else
                {
                    current = 1;
                    index = 0;
                }
 
                if (current > max)
                {
                    max = current;
                    maxIndex = index;
                }
            }

            int[] array = new int[max];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = maxIndex;
            }

            return array;
        }
    }
}
