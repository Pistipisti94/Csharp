using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csomagoloOOP
{
    internal class CsomagolasOOP
    {
        private int mennyiseg;
        private float atmero;
        private float szalag;
        public CsomagolasOOP() { }
        public CsomagolasOOP(int mennyiseg, float atmero, float szalag) 
        {
            this.mennyiseg = mennyiseg;
            this.atmero = atmero;
            this.szalag = szalag;
        }
        public float getSzalag() { return this.szalag; }
        public void setSzalag(float atmero,int mennyiseg) 
        {
            this.szalag = (((atmero*2)+60)*mennyiseg)/100 ;
            Console.WriteLine("{0} méter szallag kell",szalag);

        }
    }
}
