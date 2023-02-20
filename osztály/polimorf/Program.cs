using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace polimorf
{
    class Ember
    {
        public string Nev { get; set; }
        private string bemut = "Üdvözlüm a nevem: ";

        public Ember(string nev)
        {
            Nev = nev;
        }
        public string beszel()
        {
            return (bemut + Nev);
        }
    }
    class Ferfi : Ember
    {
        public int Kor { get; set; }
        public Ferfi(string nev, int kor) : base(nev)
        {
            Kor = kor;
        }
        class Woman : Ember
        {
            public string SzemSzin { get; set; }
            public Woman(string nev, string szemszin) : base(nev)
            {
                SzemSzin = szemszin;
            }
        }
        class Haz
        {
            private List<Ember> lakok = new List<Ember>();
            public void hazajon(Ember obj)
            {
                this.lakok.Add(obj);
            }
            public void csenget()
            {
                int i;
                Random rd = new Random();

                if (lakok.Count > 0)
                {
                    i = rd.Next(0, lakok.Count - 1);
                    Console.WriteLine(lakok[1].beszel());

                }
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Haz otthon = new Haz();
                Woman eva = new Woman("Éva", "zöld");
                Woman kati = new Woman("Kati", "barna");
                Woman sari = new Woman("Sári", "kék");
                Woman zsuzsi = new Woman("Zsuzsi", "zöld");

                Ferfi feri = new Ferfi("Feri",16);
                Ferfi david = new Ferfi("Dávid", 20);
                Ferfi laci = new Ferfi("Laci", 25);
                Ferfi attila = new Ferfi("Attila", 30);

                if(eva is Ember) otthon.hazajon(eva as Ember);
                {
                    otthon.hazajon((Ember)kati);
                    otthon.hazajon((Ember)sari);
                    otthon.hazajon((Ember)feri);
                    otthon.hazajon((Ember)zsuzsi);
                    otthon.hazajon((Ember)david);
                    otthon.hazajon((Ember)laci);
                    otthon.hazajon((Ember)attila);
                }

                bool tovabb = true;
                do
                {
                    otthon.csenget();
                    tovabb = (Console.ReadLine() == string.Empty) ?
                    false : true;

                }while (tovabb);
                
                

                Console.ReadKey();

            }
        }
    }
}
