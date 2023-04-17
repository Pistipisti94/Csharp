using fajlkezeles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FilesIO
{
    internal class program
    {

        static void Main(string[] args)
        {
            FileInpOut f = new FileInpOut();
                using (StreamWriter iro = new StreamWriter(f, Encoding.UTF8, 1024, true))
                {
                    Console.WriteLine("Írj be egy adatot:");
                    iro.WriteLine(Console.ReadLine());
                    
                }

                //visszaállunk a stream elejére
                //az írás után a végén vagyunk

               

                using (StreamReader olvaso = new StreamReader(f, Encoding.UTF8, false, 1024, true))
                {
                    string sor = null;
                    while ((sor = olvaso.ReadLine()) != null)
                    {
                        Console.WriteLine(sor);
                    }
                }
            
            Console.ReadKey();
        }
    }
}
