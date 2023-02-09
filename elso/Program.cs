using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szám:");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (szam % 3 == 0 && szam % 4 == 0 && szam % 9 == 0) 
            {
                Console.WriteLine("A szám osztható 3-mal és 4-el és 9-el is");
            }
            else if (szam % 3 == 0 && szam % 9 == 0 ) 
            {
                Console.WriteLine("A szám osztható 3-mal és 9-el");
            } 
            else if (szam % 3 == 0 && szam % 4 == 0 ) 
            {
                Console.WriteLine("A szám osztható 3-mal és 4-el");
            }
            else if (szam % 3 == 0) 
            {
                Console.WriteLine("A szám osztható 3-mal");
            }
            else if (szam%4==0)
            {
                Console.WriteLine("A szám osztható 4-el");
            }
            else if (szam%9==0)
            {
                Console.WriteLine("A szám osztható 9-el");
            }
            else
            {
                Console.WriteLine("Nem osztahtó");
            }
            Console.ReadKey();
        }
    }
}
