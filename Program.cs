using System;

namespace sda_cfence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert numamber and power to which you want it to be raised");
            int num = Convert.ToInt32(Console.ReadLine());
            int pow = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Power(num, pow)); 
        }

        static int Power(int num, int pow)
        {
            int result = num;
            while (pow > 1) {
                result *= num;
                pow--;
            }
            return result;
        }
    }
}
