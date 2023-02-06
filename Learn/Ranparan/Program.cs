using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runparam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 0) 
            {
                Console.WriteLine("Ezt a paramétert kaptam:{0}", args[0]);

            }
            else
            {
                Console.WriteLine("Nincs megadva paraméter");
            }
            Console.ReadKey();
        }
    }
}
