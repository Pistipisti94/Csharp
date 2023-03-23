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

        public int getA() { return this.a; }
   
        public void setA(int a)
        {
            int mar = 0;
            this.a = a;
            for (int i = lista.Length -1; i>=0; i--)
            {
                while (a >= lista[i])
                {
                    a -= lista[i];
                    mar++;

                }
            }
            Console.WriteLine(mar);
        }
       

    }
}
