using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;
using System.Runtime.Remoting.Messaging;

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
        protected static string path = "..\\..\\";
        protected static string inpfile = "lista.csv";
        private static string outfile = "barat.csv";
        protected List<Szemely> list = new List<Szemely>();
        protected List<Szemely> recordData = new List<Szemely>();
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
       
        }
    #region lapoz
    internal class BaratokPage : Baratok
    {
        public BaratokPage() { }
        
        public void lapoz()
        {
            beolvas();
            
            int currentPage = 1; // Jelenlegi lap száma
            int totalRecords = list.Count; // Összes rekord száma
            int recordsPerPage = 1; // Rekordok száma oldalanként
            int totalPages = totalRecords/recordsPerPage; // Összes lap száma

            Console.WriteLine("Jelenlegi lap: " + currentPage);
            Console.WriteLine("Összes lap: " + totalPages);
            Console.WriteLine();

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.PageUp:
                        currentPage--;
                        if (currentPage < 1)
                            currentPage = 1;
                        break;
                    case ConsoleKey.PageDown:
                        currentPage++;
                        if (currentPage > totalPages)
                            currentPage = totalPages;
                        break;
                    case ConsoleKey.Home:
                        currentPage = 1;
                        break;
                    case ConsoleKey.End:
                        currentPage = totalPages;
                        break;
                }

                // Kiírás a jelenlegi oldal tartalmával

                int startIndex = (currentPage - 1) * recordsPerPage;
                int endIndex = Math.Min(startIndex + recordsPerPage, totalRecords);

                int count = 0; // Változó a kinyomtatott sorok számának nyomon követésére
                
                foreach (var item in this.list)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (startIndex <= i && i < endIndex )
                    {


                            

                            
                            string name = item.nev;
                            DateTime birthDate = item.szido;
                            char gender = item.nem;
                            int partyHabits = item.hajlam;

                        
                            Console.Write($"Név: {name},  ");
                            Console.Write($"Születési idő: {birthDate},  ");
                            Console.Write($"Nem: {gender},  ");
                            Console.WriteLine($"Bulizási hajlam: {partyHabits}");
                            Console.WriteLine();
                        
                        }

                    }

                    count++; // Növeli a kinyomtatott sorok számát

                    if (count >= endIndex)
                    {
                        break; // Kilép a ciklusból, ha elértük a lap végét
                    }
                }

                Console.WriteLine();

                

                Console.WriteLine();
                Console.WriteLine("Jelenlegi lap: " + currentPage);
                Console.WriteLine("Összes lap: " + totalPages);
                Console.WriteLine();
            }
            
            
        }
        #endregion lapoz
        internal class BaratBuli : Baratok
        {
            public BaratBuli() { }

            public void bulizas()
            {
                Console.WriteLine("Kérem adja meg az életkorát:");
                int E = Convert.ToInt32(Console.ReadLine());
                

                foreach (var i in this.list)
                {
                   
                }
                Console.ReadLine();
            }
        }
    }
}
