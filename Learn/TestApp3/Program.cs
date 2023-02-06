using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            if (args.Length == 0)
            {
                Random r = new Random();
                number = r.Next(100);
            }
            else
            {
                number= int.Parse(args[0]);
            }
            Console.WriteLine(number * 2);

            Console.ReadKey();
        }
    }
}
