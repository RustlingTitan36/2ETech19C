using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
                        //ZAD 1
        public static int kp1z1(int a, int b)
        {
            return a*a+ b*b;
        }
        
                       // ZAD 2
        public static bool kp2z2(int a)
        {
            if (a >= 100 && a < 1000 && a % 17 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
                      //  ZAD 3
        public static bool kp2z6(int a, int p)
        {
                if ((Math.Pow(a, p) - a) % p == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }
                   //     ZAD 4
        public static int kp3z1(int x)
        {
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(Math.Pow(i, 3)+3);
                Console.WriteLine($"Cześć oto liczba {i + i + i + 3}");
            }
            return x;
        }
                      //  ZAD 5
        
        public static ArrayList kp3z3(int x)
        {
            ArrayList alist = new ArrayList();

            for (int i = 1; i < x+1; i++)
            {
                if ( x % i == 0)
                {
                    alist.Add(i);
                }
            }

            return alist;
        }
        public static int Zad2(int n)
        {
            int suma_cyfr = 0;
            int cyfra;
            while (n>0) {
                cyfra = n % 10;
                suma_cyfr += cyfra;
                n = n / 10;
            }
            return suma_cyfr;
        }
        public static int Zad3(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Zad3(n - 1);
        }
        public static int silniaIteracyjna(int n)
        {
            int silnia = 1;
            for (int i = 1; i <= n; i++ )
            {
                silnia = silnia * i;
            }
            return silnia;
        }
        public static int Zad4(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n < 2)
            {
                return 1;
            }
            return Zad4(n - 1) + Zad4(n - 2);
        }
        static void Main(string[] args)
        {
            /*
                            ZAD 1

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(kp1z1(a, b));
            Console.ReadKey();
                            ZAD 2

            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(kp2z2(a));
                            ZAD 3

            int a = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine(kp2z6(a, p));
                            ZAD 4

            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(kp3z1(x));
                            ZAD 5
            */
            /*
            ArrayList dzielniki = new ArrayList();
            int n = int.Parse(Console.ReadLine());
            dzielniki = kp3z3(n);
            foreach (int a in dzielniki)
            {
                Console.Write(a + " ");
            */
            /*
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Zad2(n));
            
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Zad3(n));
            
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(silniaIteracyjna(n));
            Console.ReadKey();
            */
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Zad4(n));
            Console.ReadKey();
        }
    }
}
