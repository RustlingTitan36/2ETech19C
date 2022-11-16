using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto a1 = new Auto();
            a1.model = "Opel";
            a1.marka = "AStra";
            a1.jedz();
            Console.WriteLine(a1.sprzedaj());

            Console.ReadKey();

        }
    }

    class Program2
    {

    }
}
