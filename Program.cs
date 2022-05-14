using System;

namespace sda_cfence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));

            Console.WriteLine(FactorialnotRecursive(5));
        }

        static int Factorial(int num)
        {
            if (num == 0) return 1;
            return num * Factorial(num - 1);
        }

        static int FactorialnotRecursive(int num)
        {
            int result = 1;
            for (int i = 1; i <= num; i++) result *= i;
            return result;
        }
    }
}
