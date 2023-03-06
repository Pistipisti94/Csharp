using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace atlaghomerseklet
{
    internal class atlaghomerseklet
    {
        List<Honap> ev = new List<Honap>();

    }
    class Honap
    {
        private Random random = new Random();
        private int[] honap;

        public Honap()
        {
            honap = new int[30];
            for (int i = 0; i < honap.Length; i++)
            {
                honap[i] = random.Next(-15, 40);
            }
        }

        public int GetHo(int index) { return honap[index]; }
        public int GetMaxHo() { int Max = -15; foreach (int curHo in honap) if (curHo > Max) { Max = curHo; } return Max; }
        public int GetMinHo() { int Min = 40; foreach (int curHo in honap) if (curHo > Min) { Min = curHo; } return Min; }


    }


    
}
