using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_szamok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg egy számot");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adjon meg még egy számot");
            int b = Convert.ToInt32(Console.ReadLine());
            Random random= new Random();
            
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(random.Next(a, b));
            }





            Console.ReadKey();
        }
    }
}
