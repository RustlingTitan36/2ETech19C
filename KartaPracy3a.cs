using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
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

            /*
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

            Console.WriteLine("Podaj liczbę");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                for (int l = 0; l <= i; l++)
                {
                    Console.Write("#");
                }
                for (int j = n; j > i + 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
            }
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            

            //*****
            //****
            //***
            //**
            //*

            //    *
            //   **
            //  ***
            // ****
            //*****


            int n;
            Console.WriteLine("Podaj liczbę");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n + 1; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    if (i >= j) Console.Write("");
                    else Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 0; i <=n + 1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (n-j >= i) Console.Write(" ");
                    else Console.Write("*");
                }
                Console.WriteLine();
            }

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    if (i == 1 || j == 1 || i == n || j == n || (i == n/2 + 1 && j == n/2 + 1)) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    if (i == n-j+1) Console.Write("?");
                    else if (i == j) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    if (j == n/2+1) Console.Write("*");
                    else if (i == n/2+1) Console.Write("-");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            */
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    if (i + j == n/2 + 2 || i + j == 15) Console.Write("*");
                    else Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
