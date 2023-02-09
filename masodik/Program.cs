using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a hőmérsékletet: ");
            int fok = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Celsiusból Fahrenheitbe, vagy Fahrenheitből Celsiusba váltsam?(1/2)");
            int valasz = Convert.ToInt32(Console.ReadLine());
            if (valasz == 1)
            {
                Console.WriteLine("A hőmérséklet " + (fok * 9/5 + 32) + "°C");
            }
            else if (valasz == 2)
            {
                Console.WriteLine("A hőmérséklet "+((fok-32)*5/9) + "°F");
            }
           Console.ReadKey();
        }
    }
}
