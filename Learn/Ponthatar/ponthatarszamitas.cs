using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponthatar
{
    internal class ponthatarszamitas
    {
        private int pont;
        public void szamitas() 
        {
            setPontAdat(pont);
        }
        private static ponthatarszamitas GetPontAdat()
        {
            
        }

        private void setPontAdat(int pont)
        {
            if (pont < 0) Console.WriteLine("Hibás adat");
            else if (pont > 0 && pont < 50) Console.WriteLine("Elégtelen");
            else if (pont >= 50 && pont < 65) Console.WriteLine("Elégséges");
            else if (pont >= 65 && pont < 80) Console.WriteLine("Közepes");
            else if (pont >= 80 && pont < 90) Console.WriteLine("Jó");
            else if (pont >= 90 && pont <= 100) Console.WriteLine("Jeles");
            else Console.WriteLine("Hibás adat!");
        }
        
    }
}
