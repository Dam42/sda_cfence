using System;

namespace sda_cfence
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 1, 2, 5};

            RemoveDups(numbers);
        }

        private static void RemoveDups(int[] numbers)
        {
            int[] tempNumbers = new int[6];
            foreach (int num in numbers) tempNumbers[num] = 1;

            for (int i = 0; i < tempNumbers.Length; i++) if (tempNumbers[i] == 1) Console.Write($"{i} ");
        }
    }
}