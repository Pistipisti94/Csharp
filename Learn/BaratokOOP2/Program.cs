using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaratokOOP2
{
    internal class Program
    {
        private static Baratok baratok;

        static void Main(string[] args)
        {
            baratok = new Baratok();
            string[] t = { "teszt aranka", "1991.11.12", "N", "4" };

            baratok.beolvas();
            vizsga(t[0]);

            baratok.insertBarat(t);
            vizsga(t[0]);

            baratok.delete(t[0]);
            vizsga(t[0]);

            

            Console.ReadKey();
        }
        private static void vizsga(string t)
        {
            if (baratok.kereses(t))
                Console.WriteLine("Már van ilyen barátunk.");
            else
                Console.WriteLine("Nincs ilyen barátunk.");
        }
    }
}
