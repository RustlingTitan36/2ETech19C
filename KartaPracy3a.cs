using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ZAD1
            /*
            int n;
            Console.WriteLine("Podaj liczbę");
            n = int.Parse(Console.ReadLine());
            for (int i=0; i<=n; i++)
            {
              Console.Write("* - | ");
            }
            */

            //ZAD2
            /*
            for (int i=1; i<11; i++)
            {
              for (int j=1; j<11; j++)
              {
                Console.Write(i*j + "\t");
              }
              Console.WriteLine();
            }
            */


            int n;
            Console.WriteLine("Podaj liczbę");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                for (int l = 0; l <= i; l++)
                {
                    Console.Write(" ");
                }
                for (int j = n; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
