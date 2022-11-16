using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Person
    {
        public string name;
        public string phoneNumber;
        public string emailAddress;
        public Address lives_at;
        public void purchaseParkingPass()
        {
            Console.WriteLine("Kupiono bilet");
        }
    }
}
