using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csomagoloOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CsomagolasOOP szamol = new CsomagolasOOP();

            Console.WriteLine("Mennyiség: ");
            int mennyi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Átmérő: ");
            int mero = Convert.ToInt32(Console.ReadLine());
            szamol.setSzalag(mero, mennyi);
           






            Console.ReadKey();
        }
    }
}
