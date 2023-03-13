using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HofokOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hőmérsékletek tömbje
            int[,] data = new int[12, 30];

            //Hőmérséklet tömb feltöltése adatokkal
            setMatrix(data);

            //Tömb adatainak kiiratása
            kiirMatrix(data);

            //Példányosítom az osztályt
            Hofokszamitas afok= new Hofokszamitas(data);


            //Számítások elvégzése
            afok.szamitas();
            //kiiratom a legmelegebb napot
            prLegmelegebbNap(afok);
            //kiiratom a leghidegebb napot
            prLeghidegebbNap(afok);
            //kiiratom a legmelegebb hónapot
            prLegmelegebbHonpa(afok);
            //kiiratom a leghidegebb hónapot
            prLeghidegebbHonap(afok);
            //kiiratom az összefüggő 5 minuszos napokat
            //prOtMinusz(afok);

            Console.ReadKey();

        }

        private static void prOtMinusz(Hofokszamitas p)
        {
            Napiadat[] napiadats = new Napiadat[5];
            napiadats = p.getOtMinusz();
            if ( napiadats[0].hofok < 0 )
            {
                Console.WriteLine("Az öt összefüggő minuszos nap a következő: ");
                for (int i = 0; i < napiadats.Length; i++)
                    Console.WriteLine("{0} {1}: {2}", napiadats[i].honap, napiadats[i].nap, napiadats[i].hofok);
            }
            else
                Console.WriteLine("Nem volt 5 összefüggő minuszos nap.");
        }

        private static void prLeghidegebbHonap(Hofokszamitas afok)
        {

            Haviadat adat = new Haviadat();
            adat = afok.getHaviMin();
            Console.WriteLine("Az év leghidegebb hónapja: {0} {1}", adat.honap, adat.hofok);

        }

        private static void prLegmelegebbHonpa(Hofokszamitas afok)
        {
            Haviadat adat = new Haviadat();
            adat = afok.getHaviMax();
            Console.WriteLine("Az év legmelegebb hónapja: {0} {1}", adat.honap, adat.hofok);
        }

        private static void prLeghidegebbNap(Hofokszamitas afok)
        {
            Console.WriteLine("Az év leghidegebb napja: {0} {1} {2}", afok.getNapiMin().honap,afok.getNapiMin().nap,afok.getNapiMin().hofok) ;
        }

        private static void prLegmelegebbNap(Hofokszamitas afok)
        {
            Napiadat adat = new Napiadat();
            adat = afok.getNapiMax();
            Console.WriteLine("Az év legmelegebb napja: {0} {1} {2}", adat.honap, adat.nap,adat.hofok);
        }

        private static void kiirMatrix(int[,] data)
        {
            Console.WriteLine("Az éves hőmérséklet adatok:");
            for (int i = 0; i < data.GetLength(0); i++)
            {
                Console.Write("\n {0} honap:",i+1);
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write("{0}, ", data[i,j]);
                }
            }
        }

        private static void setMatrix(int[,] data)
        {
            //Havi min és max hőmérsékletek tömbje
            int[,] minmax =
                {
                { -20,5},
                { -12,5},
                { -7,14},
                { -2,17},
                { 10,19},
                { 18,32},
                { 25,38},
                { 25,30},
                { 12,25},
                {  5,17},
                { -7,18},
                { -10,5},
                };
            //Munkaváltozók
            Random rn= new Random();

            for (int i = 0; i < data.GetLength(0); i++)
                for (int j = 0; j < data.GetLength(1); j++)
                    data[i, j] = rn.Next(minmax[i, 0], minmax[i, 1]);
        }
        
    }
    
}
