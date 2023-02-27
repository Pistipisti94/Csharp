using Hasab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hasab

{
    class Negyszog
    {

            private int a;
            private int b;
            public Negyszog(int a, int b)
            {
                this.a = a;
                this.b = b;

            }


            public int terulet()
            {
                return (this.a * this.b);
            }
            public int kerulet()
            {
                return (2 * (this.a + this.b));
            }

            public Teglalap() { }
            public void setA(int a) { this.a = a; }
            public void setB(int b) { this.b = b; }


    }

    class Hasab : Negyszog
    {
            //Osztályváltozók
            //private int a;
            //private int b;
            private int m;
            private double terfogat;
            private double felszin;

            public Hasab() : base() { }

            public Hasab(int b, int a) : base(a, b)
            {
                this.m = m;
            }
            public void setM(int a) { this.m = m; }

        public void setNegyszog()
        {
        base.setKerulet();
        base.setTerulet();
        }
        public void setTerfogat()
        {
            this.terfogat = base.getTerulet() * this.m;
        }
        public void setFelszin
        {
            this.felszin = base.getKerulet() * this.m + 2 * base.getTerulet();

        }
            public double getTerfogat() { return this.terfogat; }
            public double getFelszin() { return this.felszin; }
    }





    internal class Program
    {
        enum nyomtat { oldal, kerter, osszes}
        static void Main(string[] args)
        {
        Negyszog n1= new Negyszog();
        }
    }
}
