using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szigetek
{
    internal class Szigetszamol
    {
        //Osztályváltozók
        private int islandCount = 0,
            maxIslandLength = 0,
            i = 0;
        private string data = string.Empty;


        //Konstruktorok
        public Szigetszamol() { } // Üres konstruktor
        public Szigetszamol(string data) 
        {
            this.data = data;
        }
        //Metódusok/Számítások visszaadása


        //A data változó megadása
        public void setData(string data) { this.data = data; }
        

        //Returnel való visszaadás
        public string getData() { return this.data; }
        public int getIslandCount() { return this.islandCount; }
        public int getMaxIslandLength() { return this.maxIslandLength; }


        //Algoritmus
        public void Szamol() 
        {
            while (i < this.data.Length)
            {
                if (this.data[i] == '1')
                {
                    ++this.islandCount;
                    int j = i;
                    int tmp = 0;
                    while (j < this.data.Length && this.data[j] == '1')
                    {
                        ++j; ++tmp;
                    }
                    i= j;
                    if (tmp > this.maxIslandLength)
                    {
                        this.maxIslandLength = tmp;
                    }
                   
                }
                else ++i;
            }
        }
    }
}
