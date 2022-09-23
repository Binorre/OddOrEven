using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracadomowa3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę, aby sprawdzić czy jest parzysta czy nieparzysta");
            while (true)
            {
                var userInitValue = Console.ReadLine();
                var success = int.TryParse(userInitValue, out int numInt);
                var remainder = numInt % 2;

                if (!success)
                    Console.WriteLine("Wprowadź wartość liczbową:");
                else if (remainder == 0)
                    Console.WriteLine("Podana liczba jest parzysta. Podaj kolejną liczbę:");
                else
                    Console.WriteLine("Podana liczba jest nieparzysta. Podaj kolejną liczbę:");
            }
        }
    }
}
