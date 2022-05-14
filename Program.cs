using System;

namespace sda_cfence
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj cenę produktu:");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj liczbę produktów:");
                int productNumber = Convert.ToInt32(Console.ReadLine());
                PriceList(price, productNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void PriceList(int cena, int liczba)
        {
            for (int i = 1; i <= liczba; i++)
            {
                Console.WriteLine($"Liczba sztuk {i} łaczna cena {cena * i}");
            }
        }
    }
}