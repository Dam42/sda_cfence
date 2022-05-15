namespace sda_cfence
{
    internal class Employee : Guest
    {
        public decimal Salary { get; set; }

        public Employee(string FirstN, string LN, int age, decimal salary) : base(FirstN, LN, age)
        {
            this.Salary = salary;
        }
    }
}