using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztály
{
    internal class Program
    {
        class Kutya
        {
            private string nev; //Properties, osztályváltozók

            //Konstruktor
            public Kutya(string nev) 
            {
                this.nev = nev; //This = példányosítás
            }

            public Kutya() 
            {

            }
            public string getNev() => this.nev; // Lambda operátoros felírás

            public void setNev(string nev) { this.nev = nev; }
            public string Fajta { get; set; }
            private int gender;
            public void setGender(string gender)
            {
                switch (gender)
                {
                    case "Kan":
                        this.gender = 1;
                        break;
                    case "Szuka":
                        this.gender = 2; 
                        break;
                    default: 
                        this.gender = 3;
                        break;
                }
            }
            public string getGender()
            {
                switch (this.gender)
                {
                    case 1:
                        return "Kan";
                    case 2:
                        return "Szuka";
                    case 3:
                        return "Ismeretlen";
                }
            }
        }
        static void Main(string[] args)
        {
            Kutya kutya1 = new Kutya();
            Kutya Zeusz = new Kutya("Zeusz");
            kutya1.setNev("Bodri");
            Console.WriteLine("A Kutya1 neve: {0}", kutya1.getNev());
            Console.WriteLine("A másik kutya neve: {0}", Zeusz.getNev());
            

            Zeusz.Fajta= "Németjuhász";
            Console.WriteLine("Zeusz fajtája: {0}", Zeusz.Fajta);

            Console.ReadKey();

        }
    }
}
