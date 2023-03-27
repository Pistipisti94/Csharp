using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPszamok
{
    internal class OOPbekeres
    {
        private int x;
        OOPbekeres() { }
        OOPbekeres(int x) {
            this.x = x;
        }
        public int getX() { return x; }
        public void setX(int x) 
        {
            if (x % 3 == 0 || x % 6 == 0 || x % 9 == 0) { Console.WriteLine("A szám osztahó 3-mal 6-al és 9-el is."); }
            else if (x % 3 == 0 || x % 6 == 0 || x % 9 == 1) { Console.WriteLine("A szám osztahó 3-mal 6-al, de 9-el nem."); }
            else if (x % 3 == 0 || x % 6 == 1 || x % 9 == 1) { Console.WriteLine("A szám osztahó 3-mal, de 6-al és 9-el nem."); }
            else { Console.WriteLine("A szám nem osztható se 3-al se 6-al se 9-el."); }

        }
    }
}
