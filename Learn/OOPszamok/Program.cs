using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPszamok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Most megnézzük hogy a beírt szám oszható e maradéktalanul 3-al 6-al vagy 9-el.");
            Console.WriteLine("írj be egy számot.");
            int y = Convert.ToInt32(Console.ReadLine());
            OOPbekeres oOPbekeres = new OOPbekeres(y);
            Console.ReadKey();
        }
    }
}
