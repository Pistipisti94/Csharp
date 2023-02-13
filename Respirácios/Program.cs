using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Respirácios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CO2: ");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("O2: ");
            float b = Convert.ToSingle(Console.ReadLine());
            float c = a / b;
            if (a / b == 0.8)
            {
                Console.WriteLine($"Az RQ:{c}. Jó");
            }
            else if (a / b < 0.8)
            {
                Console.WriteLine($"Az RQ:{c}. A szervezet a zsírokból nyeri az energiát");
            }
            else
            {
                Console.WriteLine($"Az RQ:{c}. A szervezet a szénhidrátokból nyeri az energiát");
            }
            Console.ReadKey();
        }
    }
}
