using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Skladnik
    {
        private string nazwa;
        private int kalorie;
        public Skladnik(string nazwa, int kalorie)
        {
            this.nazwa = nazwa;
            this.kalorie = kalorie;
        }
    }
    class Salatka
    {
        Skladnik s1;
        Skladnik s2;
        Skladnik s3;
        public void przygotuj()
        {
            // wiele logiki ....
            Skladnik s = new Skladnik("marchew", 60);
            if (this.s1 == null) this.s1 = s;
            else this.s2 = s;
        }
        public void wydaj()
        {
            
        }
    }
    class Danie
    {
        private string zupa;
        private string napoj;
        private Salatka salatka;
        public void przyrzadzSalatke(Salatka asalatka)
        {
            this.salatka = asalatka;
        }
        public void zjedz()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Danie d = new Danie();
            Salatka s = new Salatka();
            d.przyrzadzSalatke(s);
        }
    }
}
