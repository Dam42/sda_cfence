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
                pet.MakeSound();
                if (pet is Dog dog)
                {
                    Console.WriteLine("Pies ^");
                }
                else if (pet is Cat cat)
                {
                    Console.WriteLine("Kot ^");
                }
            }
        }
    }
}