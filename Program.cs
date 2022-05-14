using System;

namespace sda_cfence
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = { 5, 8, 11, 15, 2, 9, 10, 51, 3, 100, 4, 9, 18 };

            foreach (int num in numbers) Console.Write($"{num} ");
            Console.WriteLine();
            sort(numbers);
            foreach (int num in numbers) Console.Write($"{num} ");

            //To modyfikuje tablicę której używamy, nie wiem czy lepiej tak czy żeby zwracało nową posortowaną a taj nie zmieniało.
        }

        static void sort(int[] numbers)
        {
            int temp = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - (i + 1); j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                        temp = 0;
                        // To by wypadało w sumie zapisać w funkcji swap() czy coś takiego, ale whatever.
                    }
                }
            }
        }
    }
}