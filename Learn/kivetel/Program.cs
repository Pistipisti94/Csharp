using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kivetel
{
    internal class Program
    {
        class Kivetel
        {
            public Kivetel() { }
            #region Nincs kivétel kezelés
            public void KivKezNincs()
            {
                Console.WriteLine("nincs kivételkezelve\nAdjon meg egy karaktert!");
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A beírt szám {0}", szam);
                Console.ReadKey();
            }

            #endregion
            #region Általános kivételkezelés
            public void KivKezAlt()
            {
                Console.WriteLine("\nHiba objektum nélküli kivételkezelés\nAdjon meg egy karaktert!");
                try
                {
                    int szam = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("A beírt szám {0}", szam);
                }
                catch
                {
                    throw;

                }
                Console.ReadKey();
            }

            #endregion
            #region Őshiba objektummal
            public void KivKezOs()
            {
                Console.WriteLine("\nŐs hiba objektummal kivételkezelés\nAdjon meg egy számot!");

                try
                {
                    int szam = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("A beírt szám {0}", szam);
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.ToString());
                }
            }
            #endregion
            #region Hiba objektummal
            public void KivKezObj()
            {
                Console.WriteLine("\nSaját Hiba objektummal kivételkezelés\nAdjon meg egy karaktert!");
                try
                {
                    int szam = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("A beírt szám {0}", szam);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message + e);

                }
                Console.ReadKey();
            }
            #endregion
        }
        static void Main(string[] args)
        {
            Kivetel kivetel = new Kivetel();
            //kivetel.KivKezNincs();
            //kivetel.KivKezAlt();
            //kivetel.KivKezOs();
            kivetel.KivKezObj();
        }
    }
}
