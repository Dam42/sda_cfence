using System;

namespace sda_cfence
{
    class Program
    {
        static void Main()
        {
            string pass = "1qazXSW#";

            Console.WriteLine(Verify(pass)); 
        }

        static bool Verify(string pass)
        {
            if ( IsLong(pass) && HasNumber(pass) && HasSpecial(pass)) return true;
            return false;
        }

        static bool IsLong(string pass)
        {
            if (pass.Length >= 6) return true;
            return false;
        }
        static bool HasNumber(string pass)
        {
            char[] chPass = pass.ToCharArray();
            foreach (char c in chPass) if (char.IsDigit(c)) return true;
            return false;
        }
        static bool HasSpecial(string pass)
        {
            char[] chars = { '&', '*', '$', '#' };
            if (pass.IndexOfAny(chars) == -1) return false;
            return true;
        }

    }
}
