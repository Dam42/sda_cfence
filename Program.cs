using System;

namespace sda_cfence
{
    class Program
    {
        static void Main()
        {
            numSequence(5, 2, 2);
        }

        static void numSequence(int len, int firstElement, int diff)
        {
            for (int i = 0; i < len; i++) 
            {
                Console.WriteLine(firstElement + diff*i);
            }
            
        }
    }
}
