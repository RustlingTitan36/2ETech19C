using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int a, b, wynik;
            Console.WriteLine("Podaj pierwszą liczbę");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            b = int.Parse(Console.ReadLine());
            wynik = a * a + b * b;
            Console.WriteLine($"{a}^2 + {b}^2 = {wynik}");
            */

            /*
            int x, y, z;
            Console.WriteLine("Podaj liczbę");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę");
            z = int.Parse(Console.ReadLine());
            if (x>y && y>z)
            {
                Console.WriteLine($"{x}, {y}, {z}");
            }
            else if(x>z && z>y)
            {
                Console.WriteLine($"{x}, {z}, {y}");
            }
            else if(y>x && x>z)
            {
                Console.WriteLine($"{y}, {x}, {z}");
            }
            else if(y>z && z>x)
            {
                Console.WriteLine($"{y}, {z}, {x}");
            }
            else if(z>x && x>y)
            {
                Console.WriteLine($"{z}, {x}, {y}");
            }
            else if(z>y && z>x)
            {
                Console.WriteLine($"{z}, {y}, {x}");
            }
            */

            /*
            int n, x;
            Console.WriteLine("Podaj liczbę");
            n = int.Parse(Console.ReadLine());
            x = 1;
            for (int i = 1; i<=n; i++)
            {
                x = x * i;
            }
            Console.WriteLine(x);
            */

            /*
            int x;
            x = -7;
            for (int i = 1; i<=7; i++)
            {
                Console.WriteLine(x);
                x = x + 4;
            }
            
            int x, y;
            x = -7;
            y = 1;
            while (y<=7)
            {
                Console.WriteLine(x);
                y = y + 1;
                x = x + 4;
            }
            */

            /*
            int x;
            x = 2;
            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine(x);
                x = x * 3;
            }

            int x, y;
            x = 2;
            y = 1;
            while (y <= 6)
            {
                Console.WriteLine(x);
                y = y + 1;
                x = x * 3;
            }
            */

            /*
            int n, x;
            Console.WriteLine("Podaj liczbę");
            n = int.Parse(Console.ReadLine());
            x = 0;
            while (n >= 1)
            {
                n = n / 10;
                x = x + 1;
            }
            Console.WriteLine(x);
            */

            /*
            int n = int.Parse(Console.ReadLine());
            bool flaga = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    flaga = false;
                    break;
                }
            }
            if (flaga == true)
            {
                Console.WriteLine("JEST PIERWSZA");
            }
            else
            {
                Console.WriteLine("NIE JEST PIERWSZA");
            }
            */
        }
    }
}
