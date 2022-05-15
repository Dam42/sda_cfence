using System;

namespace sda_cfence
{
    internal class Dog : Pet
    {
        private string SOUND = "AUGHHH";
        private string Name { get; }

        public Dog(string name)
        {
            this.Name = name;
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} wydaje dźwięk {SOUND}");
        }
    }
}