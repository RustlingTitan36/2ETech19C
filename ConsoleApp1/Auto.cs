using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Auto
    {
        // definicja obiektu
        // pola
        // metody

        // private, public, protected
        private int id;
        public string marka;
        public string model;
        public void jedz()
        {
            Console.WriteLine(this.marka + " robi Brummmmm");
        }
        public int sprzedaj()
        {
            return 1000;
        }
    }
}
