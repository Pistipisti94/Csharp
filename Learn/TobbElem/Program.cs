using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TobbElem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[100];
            int paros = 0;
            int paratlan = 0;
            bool s = false;

            Console.WriteLine("Most 100 számot kérek beírni 1-essével");
     
            
                Console.WriteLine("Szám: ");
                while (s == false)
                { 
                    for (int j = 0; s == false; j++)
                    {
                        int u = Convert.ToInt32(Console.ReadLine());
                        u = u+u; 
                        if (u >= 101) { s = true; }
                        if (u % 2 == 0)
                        {
                            paros++;
                        }
                        else { paratlan++; }
                    }
                }
            
            Console.WriteLine("{0}páros és {1} páratlan volt beírva",paros,paratlan);
            Console.ReadKey();
        }
    }
}
