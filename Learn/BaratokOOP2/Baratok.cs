using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography.X509Certificates;

namespace BaratokOOP2
{
    public struct Szemely
    {
        public string nev;
        public DateTime szido;
        public char nem;
        public int hajlam;
    }
    internal class Baratok
    {
        private static string path = "..\\..\\";
        private static string inpfile = "lista.csv";
        private static string outfile = "barat.csv";
        protected List<Szemely> list = new List<Szemely>();
        #region Konstruktor
        public Baratok() { }
        #endregion Konstruktor

        #region Metódusok
        #region Beolvasás
        public void beolvas()
        {
            FileStream fs = new FileStream(path + inpfile, FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                while (!sr.EndOfStream)
                    this.list.Add(convert(sr.ReadLine().Split(';')));
            }
        }
        #endregion Beolvasás
        #region Személy
        private Szemely convert(string[] line)
        {
            Szemely szemely = new Szemely();
            szemely.nev = line[0];
            szemely.szido = Convert.ToDateTime(line[1]);
            szemely.nem = Convert.ToChar(line[2]);
            szemely.hajlam = Convert.ToInt32(line[3]);

            return szemely;
        }
        #endregion Személy
        #region Hozzáadás
        public void insertBarat(string[] t)
        {
            this.list.Add(convert(t));
        }
        #endregion Hozzáadás
        #region Törlés
        public void delete(string nev)
        {
            this.list.Remove(this.list.Find(list => list.nev == nev));
        }
        #endregion Törlés
        #region Keresés
        public bool kereses(string nev)
        {
            Szemely vane = new Szemely();
            vane = this.list.Find(list => list.nev == nev);
            if (vane.nev == nev)
                return true;
            return false;
        }
        #endregion Keresés
        #region Kiiratás
        public void kiir()
        {
            using (StreamWriter sw = new StreamWriter(new FileStream(path + outfile, FileMode.Create, FileAccess.Write), Encoding.UTF8))
            {
                foreach (Szemely item in this.list)
                    sw.WriteLine(item.nev, ";", item.szido, ";", item.nem, ";", item.hajlam);
            }
        }
        #endregion Kiiratás
        #region Kepreiras
        public void odair()
        {
            FileStream fs = new FileStream(path + inpfile, FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(path + inpfile))
            {
                int szamlalo = 0;
                string ln;

                while ((ln = sr.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    szamlalo++;
                }
                sr.Close();

            }
        }
        #endregion Kepreiras

        #endregion Metódusok


        
    }
    internal class BaratokScreen : Baratok 
    {
        public BaratokScreen() { }
        #region listazas
        public void listazas()
        {
            foreach (var item in this.list)
            {
                Console.WriteLine($"{item.nev,-20};  {item.szido.ToShortDateString(),10}; {item.nem,1}; {item.hajlam}");
                Console.WriteLine();
            }
        }
        #endregion listazas
        #region lapoz
        internal class BaratokPage : Baratok
        {
            public BaratokPage() { }

            public void lapoz()
            {
                
                int lapmeret = 15;
                //int PageUp = 33;
                //int PageDown = 34;
                //int Home =36;
                //int End =35;
                //int Esc =27;
                int p;
                int i;
                
                do
                {

                
                for (i = 0; i < lapmeret; i++)
                {
                    Console.WriteLine($"{this.list[i].nev,-20};  {this.list[i].szido.ToShortDateString(),10}; {this.list[i].nem,1}; {this.list[i].hajlam,1}");
                    Console.WriteLine();

                }
                p = Convert.ToInt32(Console.ReadKey());
                    bool b = false;
                    switch (p)
                {
                    case ConsoleKey.PageUp:
                       i = (i >= lapmeret) ?  i - lapmeret : 0;
                        break;//PageUP

                    case ConsoleKey.PageDown: i+=lapmeret;
                        i = (i <= lapmeret) ? i + lapmeret : 20;
                        break;//PageDown

                    case ConsoleKey.Home: i = 0;
                        break;//Home

                    case ConsoleKey.End: i = this.list.Count-lapmeret;
                        break;//End

                    case ConsoleKey.Escape:

                        b = true;
                        break;//Esc

                    default:
                            Console.WriteLine("Csak a következő billentyűket használhatod:\\n PageUp\\n PageDown\\n Home\\n End\\n Esc");
                        break;
                }
                } while (true);
            }
        }
        #endregion lapoz
    }
    internal class BaratBuli : Baratok
    {
        public BaratBuli() { }

        public void bulizas()
        {
            Console.WriteLine("Kérem adja meg az életkorát:");
            int E = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            
            foreach (var i in this.list)
            {
                if(i.hajlam >= 5 &&  i.szido)
                {

                }
            }
            Console.ReadLine();
        }
    }
}
