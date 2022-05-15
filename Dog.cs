using System;

namespace sda_cfence
{
    internal class Dog : Pet
    {
        private const string DOG_SOUND = "Hau";

        public Dog(string name) : base(name, DOG_SOUND) { }

    }
}