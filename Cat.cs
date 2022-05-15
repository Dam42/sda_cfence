using System;

namespace sda_cfence
{
    internal class Cat : Pet
    {
        private string SOUND = "Miau";
        private string Name { get; }

        public Cat(string name)
        {
            this.Name = name;
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} wydaje dziek {SOUND}");
        }
    }
}