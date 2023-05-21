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
        private static BaratokScreen baratok1;
        private static BaratokPage baratok2;
        

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

            baratok1 = new BaratokScreen();
            baratok1.beolvas();
            Console.WriteLine();
            //baratok1.listazas();
            baratok2 = new BaratokPage();
            Console.WriteLine();
            baratok2.lapoz();
            
            
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
