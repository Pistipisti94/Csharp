using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        private List<Szemely> list = new List<Szemely>();
        #region Konstruktor
        public Baratok() { }
        #endregion Konstruktor

        #region Metódusok
        #region Beolvasás
        public void beolvas() 
        {
            FileStream fs = new FileStream(path + inpfile,FileMode.Open,FileAccess.Read);
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
                    sw.WriteLine(item.nev,";",item.szido, ";", item.nem, ";", item.hajlam);
            }
        }
        #endregion Kiiratás
        #region Kepreiras
        public void odair()
        {
            FileStream fs = new FileStream(path + inpfile, FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                while (!sr.EndOfStream)
                    
            }
        }
        #endregion Kepreiras
        #endregion Metódusok


    }
}
