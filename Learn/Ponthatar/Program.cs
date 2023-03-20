using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponthatar
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine("Kérem a pontszámot: ");
            int pont = Convert.ToInt32(Console.ReadLine());
            ponthatarszamitas pontszamitas = new ponthatarszamitas();
            pontszamitas();
        }
    }
}
