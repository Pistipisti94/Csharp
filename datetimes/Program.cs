using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ora, perc, mp;

            Console.WriteLine("Első óra: ");
            ora = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Első perc: ");
            perc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Első másodperc: ");
            mp = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("második óra: ");
            ora = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Második perc: ");
            perc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Második másodperc: ");
            mp = Convert.ToInt32(Console.ReadLine());
            DateTime ido = Convert.ToDateTime(ora+perc+mp);
            Console.WriteLine(ido);








            Console.ReadKey();
        }
    }
}
