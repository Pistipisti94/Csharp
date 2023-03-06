using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szigetek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1. példa
            //s változó létrehozása
            string s = "00111111100001111101111110000000011111111110000011111101001011111111111";

            //Objektum létrehozása/ elnevezése sz1-re
            Szigetszamol sz1= new Szigetszamol();
            //sz1 objektum Data(s) megadása
            sz1.setData(s);
            sz1.Szamol();
            //Kiiratás
            Console.WriteLine("A szigetek száma: {0}, a leghosszabb sziget: {1}", sz1.getIslandCount(), sz1.getMaxIslandLength());

            #endregion
            #region 2. példa
            //s változó létrehozása
            string s2 = "00111111100001111101111110000011000111111111111100000111111010010111111111111111111111110110111111110111111000000000000000111111";

            //Objektum létrehozása/ elnevezése sz1-re
            Szigetszamol sz2 = new Szigetszamol();
            //sz1 objektum Data(s) megadása
            sz2.setData(s2);
            sz2.Szamol();
            //Kiiratás
            Console.WriteLine("A szigetek száma: {0}, a leghosszabb sziget: {1}", sz2.getIslandCount(), sz2.getMaxIslandLength());

            #endregion
            #region 3. példa
            //s változó létrehozása
            string s3 = "001111111000000000000111111";

            //Objektum létrehozása/ elnevezése sz1-re
            Szigetszamol sz3 = new Szigetszamol();
            //sz1 objektum Data(s) megadása
            sz3.setData(s3);
            sz3.Szamol();
            //Kiiratás
            Console.WriteLine("A szigetek száma: {0}, a leghosszabb sziget: {1}", sz3.getIslandCount(), sz3.getMaxIslandLength());
            #endregion

            Console.ReadKey();
        }
    }
}
