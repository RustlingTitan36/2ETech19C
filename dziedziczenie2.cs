using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Pojazd
    {
        private string nazwa;
        private int vin;
        public void jedz()
        {
            Console.WriteLine("Jade");
        }
        public void tankuj()
        {
            Console.WriteLine("Tankuje");
        }

    }
    class Samochod : Pojazd
    {
        private string oc;
        public void zaparkuj()
        {
            Console.WriteLine("Parkuje");
        }
    }
    class Motur : Pojazd
    {
        public void zalozKask()
        {
            Console.WriteLine("założony");
        }
    }
    class Koparka : Pojazd 
    {
        private string udt;
        public void kop()
        {
            Console.WriteLine("Kopie");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
