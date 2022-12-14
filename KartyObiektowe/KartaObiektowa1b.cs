using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Produkt
    {
        private string nazwa;
        private double cena;
        private string opis;
        public string getNazwa()
        {
            return nazwa;
        }
        public double getcena()
        {
            return cena;
        }
        public string getOpis()
        {
            return opis;
        }
        public Produkt(string nazwa, double cena, string opis)
        {
            this.nazwa = nazwa;
            this.cena = cena;
            this.opis = opis;
        }
    }

    class Profil
    {
        private string imie;
        private string drugieImie;
        private string nazwisko;
        public string getImie()
        {
            return imie;
        }
        public string getNazwisko()
        {
            return nazwisko;
        }
        public void setNazwisko(string anazwisko)
        {
            this.nazwisko = anazwisko;
        }
    }

    class Uzytkownik
    {
        private string login;
        private string haslo;
        private Profil profil;
        public void loguj()
        {
            Console.WriteLine("loguj?");
        }
        public Uzytkownik(Profil profil)
        {
            this.profil = profil;
        }   
    }

    class Koszyk
    {
        private int id;
        private Produkt produkt;
        private Uzytkownik uzytkownik;
        public int getId()
        {
            return id;
        }
        public void operation()
        {
            Console.WriteLine("operacja");
        }
        public Koszyk(Produkt aprodukt)
        {
            this.produkt = aprodukt;
        }
        public void setUzytkownik(Uzytkownik auzytkownik)
        {
            this.uzytkownik = auzytkownik;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Profil prof1 = new Profil();
            Uzytkownik u1 = new Uzytkownik(prof1);
            u1.loguj();
            prof1.setNazwisko(" ");
            Produkt prod1 = new Produkt("mleko", 6, "mleko");
            Koszyk k1 = new Koszyk(prod1);
        }
    }
}
