using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zad 1 - Medium - Oblicz sumę n pierwszych liczb trzycyfrowych

            /*
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            for (int i = 100; i < n + 100; i++)
            {
                suma += i;
            }
            Console.WriteLine(suma);
            */

            // Zad 2 - Light Hard - Napisz sume k początkowych liczb fibocciego
            // 1 + 2 + 3 + 5 + 8 + 13 + 21 + ....

            /*
            int k = int.Parse(Console.ReadLine());
            int suma = 0;
            int a = 0;
            int b = 1;
            for (int i = 0; i <= k; i++)
            {
                suma = b;
                b = b + a;
                a = suma;
            }
            Console.WriteLine(suma);
            */

            // Zad 3 - Light Hard - Sprawdzenie czy liczba n jest doaskonała, czyli równa sumie swoich dzielników
            // bez niej samej

            // 6 = 1 + 2 + 3 (jest)
            // 10 = 1 + 2 + 5 (nie)
            // 28 = 1 + 2 + 4 + 7 + 14 (jest)
            // 496 (jest)

            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            for (int i = 1; i < n; i++)
            {
                if (n%i==0)
                {
                    suma += i;
                }
            }
            if (n==suma)
            {
                Console.WriteLine($"liczba {n} jest doskonała");
            }
            else
            {
                Console.WriteLine($"liczba {n} nie jest doskonała");
            }
            
        }
    }
}
