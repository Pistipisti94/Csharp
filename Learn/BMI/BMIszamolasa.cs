using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    internal class BMIszamolasa
    {
        private int Tomeg = 0;
        private int Magassag = 0;
        private int BmI = 0;
        //Konstruktor
        public BMIszamolasa(int t,int m)
        { this.Tomeg = t;
          this.Magassag = m;
        }
        public int getBmI() { return BmI; }

        public void szamitas()
        {
            setBmI();
        }

        private void setBmI()
        {
            
        }
    }
}
