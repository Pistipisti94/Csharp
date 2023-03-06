using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haramszoghasab
{
    internal class Program
    {
        class Haromszog
        {
            private int a;
            private int b;
            private int c;
            private double terulet;
            private double kerulet;
            public Haromszog(int a, int b, int c, double terulet, double kerulet)
            {
                this.a = a;
                this.b = b;
                this.c = c;
                this.terulet = terulet;
                this.kerulet = kerulet;
            }
            public int getKerulet(double kerulet)
            {
                return (a + b + c) / 2;
            }
            public int getTerulet(double terulet)
            {
                return (Math.Sqrt(getKerulet()*(getKerulet()-this.a)*(getKerulet()-this.b)*(getKerulet()-this.c));
            }
            public Haromszog() { }
            public void setA(int a) { this.a = a; }
            public void setB(int b) { this.b = b; }
            public void setC(int c) { this.c = c; }
        }
        
        static void Main(string[] args)
        {


            Console.ReadKey();
        }
    }
}
