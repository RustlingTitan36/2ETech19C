using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KartaPracy1
{			
	public class Program
	{
		public static void Main(string[] args)
		{
			// ZAD1
			/*
			int a, b, c;
			Console.WriteLine("Podaj pierwszą liczbę");
			a = int.Parse(Console.ReadLine());
			Console.WriteLine("Podaj drugą liczbę");
			b = int.Parse(Console.ReadLine());
			c = a + b;
			if (c%2==0)
			{
				Console.WriteLine("Tak");
			}
			else 
			{
				Console.WriteLine("Nie");
			}
			*/
			// ZAD2
			/*
			double a, g, sredAryt, sredGeom;
			Console.WriteLine("Podaj pierwszą liczbę");
			a = double.Parse(Console.ReadLine());
			Console.WriteLine("Podaj drugą liczbę");
			g = double.Parse(Console.ReadLine());
			sredAryt = (a + g)/2;
			sredGeom = Math.Sqrt(a * g);
			if (sredAryt > sredGeom)
			{
				Console.WriteLine("Tak");
			}
			else 
			{
				Console.WriteLine("Nie");
			}
			*/
			// ZAD3
			/*
			int k, l, m;
			Console.WriteLine("Podaj pierwszą liczbę (k)");
			k = int.Parse(Console.ReadLine());
			Console.WriteLine("Podaj drugą liczbę (l)");
			l = int.Parse(Console.ReadLine());
			Console.WriteLine("Podaj trzecią liczbę (m)");
			m = int.Parse(Console.ReadLine());
			if (k == l)
			{
				Console.WriteLine("Tak, k=l");
			}
			else if (l == m)
			{
				Console.WriteLine("Tak, l=m");
			}
			else if (k == m)
			{
				Console.WriteLine("Tak, k=m");
			}
			else
			{
				Console.WriteLine("Nie");
			}
			*/
			// ZAD4
			/*
			int a, b, c, d;
			Console.WriteLine("Podaj pierwszą liczbę");
			a = int.Parse(Console.ReadLine());
			Console.WriteLine("Podaj drugą liczbę");
			b = int.Parse(Console.ReadLine());
			Console.WriteLine("Podaj trzecią liczbę");
			c = int.Parse(Console.ReadLine());
			Console.WriteLine("Podaj czwartą liczbę");
			d = int.Parse(Console.ReadLine());
			Console.WriteLine("Najmniejsza liczba to: ");
			Console.Write(Math.Min(Math.Min(a, b), Math.Min(c, d)));
			*/
			// ZAD5
			int a, b, c;
			Console.WriteLine("Podaj pierwszą liczbę");
			a = int.Parse(Console.ReadLine());
			Console.WriteLine("Podaj drugą liczbę");
			b = int.Parse(Console.ReadLine());
			Console.WriteLine("Podaj trzecią liczbę");
			c = int.Parse(Console.ReadLine());
			if (a<b+c)
			{
				Console.WriteLine("Tak");
			}
			else if (b<a+c)
			{
				Console.WriteLine("Tak");
			}
			else if (c<a+b)
			{
				Console.WriteLine("Tak");
			}
			else
			{
				Console.WriteLine("Nie");
			}
		}
	}
}
