namespace sda_cfence
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Guest[] guests = new Guest[]
            {
            new Guest("Nick", "Gurr", 1992),
            new Employee("Rob", "Graves", 1999, 5_000.99M),
            new Guest()
            {
                FirstName = "Bruh",
                LastName = "wah",
                YearOfBirth = 2002
            }
            };
            
            foreach (var guest in guests)
            {
                guest.DumpInfo();
                if (guest is Employee employee) {
                    System.Console.WriteLine($"Salary is {employee.Salary}");
                } 
            }
        }
    }
}