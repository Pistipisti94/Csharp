using PontHatOOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPponthatar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Add meg a pontodat: ");
            try
            {
                a = int.Parse(Console.ReadLine());
                ponthatar P1 = new ponthatar();
                P1.setPont(a);
                P1.setJegy();
            }
            catch
            {
                Console.WriteLine("Hibás adat!");
            }
            Console.ReadKey();
        }
    }
}
