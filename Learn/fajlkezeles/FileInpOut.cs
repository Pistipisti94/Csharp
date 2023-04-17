using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fajlkezeles
{
    internal class FileInpOut
    {
        //Osztályváltozók
        private string fileName;
        private FileMode fileMode;
        private FileAccess fileAcces;
        private FileStream fs;
        private StreamReader sr;
        private StreamWriter sw;


        //Konstruktor
        public FileInpOut()
        {
            setFileName(); //Fájl nevének bekérése
            setFileMode(); //Megnyitása módjának bekérése
            setFileAcces(); //Hozzáférés módjának beállítása

        }
        private void setFileName() 
        {
            Console.WriteLine("Adja meg a fájl nevét kiterjesztés nélkül");
            this.fileName = "..\\..\\" + Console.ReadLine() + ".txt";
        }


        private void setFileMode()
        {
            bool ismet;
            string s;

            Console.WriteLine("Adja meg a műveletet:");
            Console.WriteLine("     cr:  Create");          //Létrehoz egy új fájlt, ha már létezik a tartalmát kitörlni.
            Console.WriteLine("     crn: CreateNew");       //Mint előbb, de ha már létezik a fájl, akkor kivételt dob.
            Console.WriteLine("     o    Open");            //Megnyit egy fájlt ha nem létezik akkor kivételt dob.
            Console.WriteLine("     oc   OpenOrCreate");    //Mint előbb, de ha nem létezik, akkor létrehozza a fájlt üseresen.
            Console.WriteLine("     a    Append");          //Megnyit egy fájlt és automatikusan a végére áll, ha nem létezik létrehozza.
            Console.WriteLine("     t    Truncate");        //Megnyit egy létező fájlt és törli a tartalmát.

            do
            {
                ismet = false;
                s = Console.ReadLine().ToLower().Trim();
                switch (s)
                {
                    case "cr":fileMode = FileMode.Create; break;
                    case "crn":fileMode = FileMode.CreateNew; break;
                    case "o":fileMode= FileMode.Open; break;
                    case "oc":fileMode= FileMode.OpenOrCreate; break;
                    case "a":fileMode= FileMode.Append; break;
                    case "t": fileMode= FileMode.Truncate; break;
                        default:
                        Console.WriteLine("Hibás adat! Ismételje meg!");
                        ismet= true;
                        break;
                }
            } while (ismet);
        }
        private void setFileAcces()
        {
            bool ismet;
            string s;

            Console.WriteLine("Adja meg a fájl hozzáférést");
            Console.WriteLine("     r:  Olvasás");
            Console.WriteLine("     w:  Írás");
            Console.WriteLine("     rw: Olvasás és írás");

            do
            {
                ismet = false;
                s = Console.ReadLine().ToLower().Trim();

                switch (s)
                {
                    case "r":fileAcces = FileAccess.Read; break;
                    case "w":fileAcces= FileAccess.Write; break;
                    case "wr":fileAcces=FileAccess.ReadWrite; break;
                    default:
                        Console.WriteLine("Hibás adat! Ismételje meg!");
                        ismet= true;
                        break;
                }
            } while (ismet);
            
        }


        public StreamWriter getWrite()
        {
            this.fs = new FileStream(this.fileName, this.fileMode, this.fileAcces);
            this.sw = new StreamWriter(this.fs);
            return sw;
        }
        public void closeFile()
        {
            if (this.sr != null)  this.sr.Close(); 
            if (this.fs != null)  this.fs.Close(); 
        }

    }
}
