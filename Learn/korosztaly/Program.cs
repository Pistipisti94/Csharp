using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korosztaly
{
    internal class Program
    {
        class Kor
        {
            private int r;
            private int terulet;
            private int kerulet;
            
            public Kor( int r) 
            {
                
                this.r= r;
            }


            public int setTerulet()
            {
                this.terulet = (r * r * Math.PI);
            }
            public int setKerulet()
            {
                this.kerulet = (2 * r * Math.PI);
            }
            

            public Kor() { }
            public void setR(int r) { this.r = r; }
        }
        class Henger
        {
            private int m;
            private int terfogat;
            private int felszin;

        }
        public Henger(int m, int r) : base(r)
        {
            this.m = m;
        }
        class Henger : Kor
        {
            private int m;
            
            private double terfogat;
            private double felszin;

            public Henger() : base() { }
            
            public Henger(int r, int m) : base(r) 
            {
                this.m = m;
            }
            public void setM(int m) { this.m = m; }

            public void setKor()
            {
                base.setTerulet();
                base.setKerulet();
                
            }
            public void setTerfogat()
            {
                this.terfogat = base.getTerulet() * this.m;
            }
            public void setFelszin()
            {
            this.felszin = base.getKerulet()* this.m + 2 * base.getTerulet();

            }
            public double getTerfogat() { return this.terfogat; }
            public double getFelszin() { return this.felszin; }

        }





        static void Main(string[] args)
        {
            Kor kor = new Kor();
            kor.setR(10);
            kor.setD(10);
            Console.WriteLine("A kor területe: {0}, kerülete: {1}",kor.terulet(),kor.kerulet());
            
            Henger henger = new Henger(10,2);
            henger.setKor();
            henger.setTerfogat();
            henger.setFelszin();
        }
    }
}
