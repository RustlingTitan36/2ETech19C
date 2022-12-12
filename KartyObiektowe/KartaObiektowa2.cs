using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Produkt {
    public string nazwa;
    public double cena;
    public string opis;
    public void getNazwa() 
    {
      Console.WriteLine("nazwa?")
    }
    public void getcena() 
    {
      Console.WriteLine("cena?")
    }
    public void getOpis() 
    {
      Console.WriteLine("opis?")
    }
    public void Produkt(nazwa, cena, opis)
    {
      Console.WriteLine("produkt?")
    }
  }

  class Profil {
    public string imie;
    public string drugieImie;
    public string nazwisko;
    public void getImie()
    {
      Console.WriteLine("imie?")
    }
    public void getNazwisko()
    {
      Console.WriteLine("nazwisko?")
    }
  }

  class Uzytkownik {
    public string login;
    public string haslo;
    public Profil profil;
    public void loguj()
    {
      Console.WriteLine("loguj?")
    }
  }

  class Koszyk {
    public int id;
    public Produkt produkt;
    public Uzytkownik uzytkownik;
    public int getId()
    {
      return id;
    }
    public void operation() {
      Console.WriteLine("operacja????")
    }
  }

  
  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!")
        }
    }
}