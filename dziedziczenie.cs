using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Osoba
    {
        private int id;
        private string name;

        public void zbadajSie()
        {
            Console.WriteLine("Badam się per rectum");
        }
    }
    class Pracownik : Osoba
    {
        private int id;
        private string imie;

        public void zarejestruj()
        {
            Console.WriteLine("Jestem w pracy");
        }
        public void zbadajSie()
        {
            base.zbadajSie();
            Console.WriteLine("Badam się normalnie");
        }
    
    }

    class Kierownik : Osoba
    {
        private int id;
        private string imie;

        public void sprawdzPracownika(int id)
        {
            Console.WriteLine("Sprawdzony");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pracownik pr1 = new Pracownik();
            pr1.zarejestruj();
            pr1.zbadajSie();

            Osoba os1 = new Osoba();

            os1.zbadajSie();

            Osoba os2 = new Pracownik();

            os2.zbadajSie();

            Osoba os3 = new Kierownik();

            Osoba os4;
            
            //Pracownik pr2 = new Osoba();
        }
    }
}
