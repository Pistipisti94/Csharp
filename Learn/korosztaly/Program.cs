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
            private double terulet;
            private double kerulet;
            
            public Kor( int r) 
            {
                
                this.r= r;
            }


            public void setTerulet()
            {
                this.terulet = ((r * r) * Math.PI);
            }
            public void setKerulet()
            {
                this.kerulet = (2 * r * Math.PI);
            }
            public double getTerulet() { return this.terulet; }
            public double getKerulet() { return this.kerulet; }


            public Kor() { }
            public void setR(int r) { this.r = r; }
        }

        class Henger : Kor
        { 

            private double m;
            
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
                this.terfogat =  base.getTerulet() * this.m;
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
            Console.WriteLine("A kor területe: {0}, kerülete: {1}",kor.getTerulet(),kor.getKerulet());
            
            Henger henger = new Henger(7,9);
            henger.setKor();
            henger.setTerfogat();
            henger.setFelszin();
            Console.WriteLine("A henger térgogata: {0}, felszíne: {1}", Math.Round(henger.getTerfogat(),2),Math.Round(henger.getFelszin(),2));

            Console.ReadKey();
        }
        
    }
}
