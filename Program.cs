using System;

namespace sda_cfence
{
    internal class Program
    {
        private static void Main()
        {
            string pass = "1qazXSW#";

            Console.WriteLine(Verify(pass));
        }

        private static bool Verify(string pass)
        {
            if (IsLong(pass) && HasNumber(pass) && HasSpecial(pass) && HasUpperCase(pass) && HasLowerCase(pass)) return true;
            return false;
        }

        private static bool IsLong(string pass)
        {
            if (pass.Length >= 6) return true;
            return false;
        }

        private static bool HasNumber(string pass)
        {
            char[] chPass = pass.ToCharArray();
            foreach (char c in chPass) if (char.IsDigit(c)) return true;
            return false;
        }

        private static bool HasUpperCase(string pass)
        {
            char[] chPass = pass.ToCharArray();
            foreach (char c in chPass) if (char.IsUpper(c)) return true;
            return false;
        }

        private static bool HasLowerCase(string pass)
        {
            char[] chPass = pass.ToCharArray();
            foreach (char c in chPass) if (char.IsLower(c)) return true;
            return false;
        }

        private static bool HasSpecial(string pass)
        {
            char[] chars = { '&', '*', '$', '#' };
            if (pass.IndexOfAny(chars) == -1) return false;
            return true;
        }
    }
}