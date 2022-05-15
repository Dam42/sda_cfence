using System;

namespace sda_cfence
{
    internal class Pet
    {
        private string name;
        private string sound;

        public Pet(string name, string sound)
        {
            this.name = name;
            this.sound = sound;
        }

        public void MakeSound()
        {
            Console.WriteLine($"{name} wydaje dźwięk {sound}");
        }
    }
}