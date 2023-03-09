using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HofokOOP
{
    struct Napiadat
    {
        public string honap; //Hónapok nevei
        public int 
            nap, //Napok sorszáma
            hofok; // napok hőmérséklete
    }
    struct Haviadat
    {
        public string honap; //Hónapok nevei
        public int hofok; //Hónapok átlaghőmérséklete
    }
    internal class Hofokszamitas
    {
        //Osztályváltozók
        private int[,] adat = null; //Hőfokok tárolására
        private int[] haviAtlag = new int[12]; //Havi átlaghőfokok
        private Napiadat napiMax, napiMin; //Legmagasabb és legalacsonyabb napi hőmérséklet adatok
        private Haviadat haviMax, haviMin; // Legmagasabb és legalacsonyabb átlaghőmérsékletű hónap
        private Napiadat[] OtMinusz = new Napiadat[5];//Az öt minuszos nap tömbje 
        static string[] honapok = { "Január", "Február", "Március", "Április", "Május", "Június", "Július", "Agusztus", "Szeptember", "Október", "November", "December" }; //A 12 hónap nevének tömbje
        //Konstruktor
        Hofokszamitas(int[,] p)
        { this.adat = p; }

        //Eredményeket átadó metódusok
        public Napiadat getNapiMin() { return napiMin; }
        public Napiadat getNapiMax() { return napiMax; }
        public Haviadat getHaviMin() { return haviMin; }
        public Haviadat getHaviMax() { return haviMax; }
        public Napiadat[] getOtMinusz() { return OtMinusz; }
        #region Feladatok
        //Számítások
        private void szamitas()
        {

            //Legmelegebb & leghidegebb napok kiszámítása
            setNapiMaxMin();

            //Legmelegebb & leghidegebb átlaghőmérsékletű hónap kiszámítása
            setHaviAtlag();
            setHaviMaxMin();
            //Folyamatos 5 minuszos nap kiszámítása
            setOtMinusz();
        }
        public void setHaviAtlag()
        {
            int osszeg = 0;
            for (int i = 0; i < adat.GetLength(0); i++) //Hónapok
            {
                osszeg = 0;
                for (int j = 0; j < adat.GetLength(1); j++) //Napok
                    osszeg += adat[i, j];

                this.haviAtlag[i] = osszeg / adat.GetLength(1);
                
            }
        }
        private void setOtMinusz()
        {
            int mDB = 0;// Ezzel számoljuk, hogy hanyadik napon tartunk
            for (int i = 0; i < adat.GetLength(0); i++)
                //Hónap
            {
                for (int j = 0; j < adat.GetLength(1); j++)
                    //Nap
                {
                    if (this.adat[i,j] < 0)
                    {
                        this.OtMinusz[mDB].honap = honapok[i];
                        this.OtMinusz[mDB].nap = j + 1;
                        this.OtMinusz[mDB].hofok = this.adat[i,j];
                        mDB++;
                    }
                    else
                    {
                        for (int k = 0; k < mDB+1; k++)
                        {
                            this.OtMinusz[k].honap=String.Empty;
                            this.OtMinusz[k].nap = 0;
                            this.OtMinusz[k].hofok = 0;
                            
                        }
                        mDB = 0;
                    }
                }
            }
        }


        private void setHaviMaxMin()
        {
            int max = int.MinValue,
                maxInd = 0,
                min = int.MinValue,
                minInd = 0;


            for (int i = 0; i < haviAtlag.Length; i++)
            {
                if (this.haviAtlag[i] > max)
                { 
                max = this.haviAtlag[i];
                maxInd = i;
            }
                else if (this.haviAtlag[i] < min)
                {
                    min = this.haviAtlag[i];
                    minInd = i;
                }
            }
            this.haviMax.hofok = max;
            this.haviMax.honap = honapok[maxInd];

        }

        private void setNapiMaxMin()
        {
            int max = int.MinValue, 
                maxI = 0,
                maxJ = 0,
                min = int.MaxValue,
                minI = 0,
                minJ = 0;
                
            for (int i = 0; i < adat.GetLength(0); i++) //Hónapok ciklusa
                for (int j = 0; j < adat.GetLength(1); j++) //Napok ciklusa
                {
                    if (this.adat[i, j] > max)
                    {
                        max = this.adat[i, j];
                        maxI = i;
                        maxJ = j;
                    }
                    if (this.adat[i, j] > min)
                    {
                        min = this.adat[i, j];
                        minI = i;
                        minJ = j;
                    }
                }
            //Eredmény átadása a tömbnek
            this.napiMax.honap = honapok[maxI];
            this.napiMax.nap = maxJ + 1; // Mivel 0.nap nincs a hónapban 
            this.napiMax.hofok = max; //

            this.napiMin.honap = honapok[minI];
            this.napiMin.nap = minJ + 1; // Mivel 0.nap nincs a hónapban 
            this.napiMin.hofok = min; // 
            
        }


        #endregion
    }
}
