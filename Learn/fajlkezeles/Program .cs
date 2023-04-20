using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesIO
{
    internal class Program
    {
        #region Egész fájl olvasása

        #endregion Egész fájl olvasása

        static void Main(string[] args)
        {
            FileInpOut f = new FileInpOut();

           // fileReadFull(f.getFile());

            fileReadLine(f.getFile());
            
            string[] s = { };
            fileWrite(f.getFile(), s);

            f.closeFile();

            Console.ReadKey();
        }

        #region File írása
        private static void fileWrite(FileStream file, string[] s)
        {
            using(StreamWriter sr= new StreamWriter(file))
            {
                // Dolgozunk a fájllal
                Console.WriteLine("Írja a fájlt");
                // Soronként olvas
                for (int i = 0; i < s.Length; i++)
                {
                    sr.WriteLine(s[i]);
                    Console.WriteLine(s); //Kiírás ellenőrzése
                }
            }
        }
        #endregion File írás

        #region Soronkénti olvasás
        private static void fileReadLine(FileStream file)
        {
            using (StreamReader sr = new StreamReader(file))
            {
                string[] s; 
                // Dolgozunk a fájllal
                Console.WriteLine("Soronként olvassa a fájlt");
                // Soronként olvas
                for (int i = 0; i < 20; i++)
                {
                    string s = sr.ReadLine();
                    s.Add
                    Console.WriteLine(s);
                }
                

                

            }
        }
        #endregion Soronkénti olvasás

    }
}