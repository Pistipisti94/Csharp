using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olvashiba
{
    internal class Program
    {
            public void KivKezObj()
            {
                int szam;
            Console.WriteLine("Szám:");
                while (true)
                {
                    try
                    {
                        szam = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("A beírt szám {0}", szam);
                    break;
                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Azt mondtam egy számot!");
                        
                    }
                }
            }

        static void Main(string[] args)
        {
            Program olvashibakiv = new Program();
            olvashibakiv.KivKezObj();
            Console.ReadKey();

        }
    }
}
