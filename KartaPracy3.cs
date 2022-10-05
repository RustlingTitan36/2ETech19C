using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1. (Easy) Napisz program, który wypisze ciąg sześcianów liczb naturalnych powiększonych o 3
            Wejście: -
            Wyjście: 3, 4, 11...
            */

            /*
            for (int i = 0; i < x; i++)
            {
                *//*Console.WriteLine(Math.Pow(i, 3)+3);*//*
                Console.WriteLine($"Cześć oto liczba {i + i + i + 3}");
            }
            */

            /*
            2. (Easy)Napisz program, który wypisze wszytkie liczby trzycyfrowe podzielne przez 15.
            Wejście: -
            Wyjście: 105, 120, 135...
            */

            /*for (int i = 105; i < 1000; i+=15)
            {
                Console.WriteLine(i);
            }*/
            /*
            for (int i = 100; i < 1000; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */

            /*
            3. (Medium)Napisz program, który wypisze wszyskie dzielniki podanej liczby n.
            Wejście: p
            Wyjście: dzielniki
            */
            /*
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */
            /*
            4. (Medium) Napisz program, który obliczy sumę liczb dwucyfrowych.
            Wejście: -
            Wyjście: 4905
            */

            /*
            int suma = 0;

            for (int i = 10; i < 100; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine(suma);
            */

            /*
            5. (Hard) Bajtuś postanowił zrobić dla swoich kolegów pewną zagadkę. Zagadka polega na tym, że koledzy
            najpierw podają liczbę naturalną n. Następnie Bajtuś wybiera sobie liczbę x, taką, że 0 < x < n oraz
            wypisuje n − 1 różnych, mniejszych on n liczb pomijając przy tym swoje tajemnicze x. Napisz program,
            który pozwoli sprawdzić, jaką liczbę x wybrał sobie Bajtuś.
            Przykłady:
            WE: 5
            1 2 4 5
            WY: 3
            WE: 6
            6 5 3 2 1
            WY: 4
            WE: 7
            4 6 1 3 7 2
            WY: 5
            */

            /*
            int n, s, k;
            Console.WriteLine("Podaj liczbę");
            n = int.Parse(Console.ReadLine());
            s = 0;
            for (int i = 1; i <= n; i++)
            {
                s += 1;
                Console.WriteLine(s);
            }
            k = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                s = s - k;
            }
            Console.WriteLine(s);
            */

            /*
            6. (Hard) Napisz program według wyjścia poniżej(ciąg Fibonacciego).Zastosuj do tego zadania pętle for.
            Wejście:
            Wyjście: 1, 2, 3, 5, 8, 13, 21, 34
            */

            Console.WriteLine("Podaj ile liczb:");
            int ilosc = int.Parse(Console.ReadLine());
            int x = 1;
            int y = 2;
            int z;
            Console.Write(x);
            for (int i = 1; i <= ilosc; i++)
            {
                Console.Write($", {y}");
                z = y;
                y = x + y;
                x = z;
            }
            Console.WriteLine(" ");
        }
    }
}
