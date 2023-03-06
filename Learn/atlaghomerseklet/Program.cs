using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atlaghomerseklet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. példa
            
            List<Honap> ev = new List<Honap>();
            for (int i = 0;i < 12; i++)
            {
                ev.Add(new Honap());
            }

            #endregion

            Console.ReadKey();
        }
    }
}
