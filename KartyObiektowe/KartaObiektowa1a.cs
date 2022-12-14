using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Producent
    {
        public string nazwa;
        public string nip;
        private string getNazwa()
        {
            return nazwa;
        }
        private string getNip()
        {
            return nip;
        }
        private void setNazwa(string anazwa)
        {
            this.nazwa = anazwa;
        }
    }
    public class Material
    {
        private string typ;
        private int id;
        private double cena;
        public void setTyp(string atyp)
        {
            this.typ = atyp;
        }
        public string getTyp()
        {
            return typ;
        }
        public string getCena()
        {
            return "Cena";
        }
        private void setId(int aid)
        {
            this.id = aid;
        }
    }
    public class Rower
    {
        private Producent producent;
        private string color;
        private Material material;
        public void jedz()
        {
            Console.WriteLine("  ");

        }
        public void setColor(string acolor)
        {
            this.color = acolor; 
        }
        public string getColor()
        {
            return color;
        }
        public void setMaterial(Material material)
        {
            this.material = material;
        }
        public Rower(Producent aproducent)
        {
            this.producent = aproducent;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Producent p1 = new Producent();
            Material m1 = new Material();
            Rower r1 = new Rower(p1);
            r1.setMaterial(m1);
            r1.setColor("Czrewony");
        }
    }
}
