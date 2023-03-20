using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CimletezesOOP
{
    internal class CimletezOOP
    {
        private int a;
        private int[] lista = {5,10,20,50,100,200,500,1000,2000,5000,10000,20000 };

        public CimletezOOP() { }
        public CimletezOOP(int a)
        {
            this.a = a;
        }
        public void setA(int a)
        {
            this.a = a;
        }
        public int GetA() { return this.a; }
        public void szamitasok(int a, int[] lista) 
        {
            int ennyi = 0;
            int maradek;
            for (int i = 0; i < lista.Length; i++)
            {
                if (a % lista[i] == 0)
                {
                    a= a / lista[i];
                    ennyi++;
                    maradek = a % lista[11]; 
                }
            }
        }

    }
}
