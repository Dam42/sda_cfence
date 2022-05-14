using System;

namespace sda_cfence
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string pesel = "55030101193";

            Console.WriteLine(CheckControlNumber(pesel));
        }

        private static bool CheckControlNumber(string pesel)
        {
            int[] checks = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 0 };
            int[] numbers = new int[11];
            int lastNum = Convert.ToInt32(Convert.ToString(pesel[10]));
            int sum = 0;
            int i = 0;

            foreach (char c in pesel)
            {
                numbers[i] = Convert.ToInt32(Convert.ToString(c));
                numbers[i] *= checks[i];
                sum += numbers[i];
                i++;
            }

            int M = sum % 10;
            if (((10 - M) == lastNum) || (M == 0 && 0 == lastNum)) return true;
            return false;
        }
    }
}