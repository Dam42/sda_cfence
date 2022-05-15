namespace sda_cfence
{
    internal class Cat : Pet
    {
        private const string CAT_SOUND = "Miau";

        public Cat(string name) : base(name, CAT_SOUND) { }
    }
}