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
            Console.WriteLine("Pénz: ");
            int penzek = Convert.ToInt32(Console.ReadLine());
            CimletezOOP szamol= new CimletezOOP();
            szamol.setA(penzek);


            Console.ReadKey();
        }
        
    }
}
