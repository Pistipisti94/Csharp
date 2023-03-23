using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CimletezesOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CimletezOOP szamol= new CimletezOOP();

            Console.WriteLine("Pénz: ");
            int penzek = Convert.ToInt32(Console.ReadLine());
            szamol.setA(penzek);


            Console.ReadKey();
        }
        
    }
}
