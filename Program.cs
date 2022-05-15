using System;

namespace sda_cfence
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pet[] pets = new Pet[] {
                new Dog("Cerberus"),
                new Cat("Void"),
                new Dog("Bladewolf"),
                new Cat("Fatass")
            };

            foreach (var pet in pets)
            {
                if (pet is Dog dog)
                {
                    Console.Write("Pies ");
                    dog.MakeSound();
                }
                else if (pet is Cat cat)
                {
                    Console.Write("Kot ");
                    cat.MakeSound();
                }
            }
        }
    }
}