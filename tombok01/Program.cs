using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tombok01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hossz = 10;
            int alsohatar = 10,
                felsohatar = 1000;
            int[] tomb = new int[hossz];
            Random  rand = new Random();

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rand.Next(alsohatar,felsohatar);
                
            }
            for (int i = 0; i < tomb.Length; i++)
                Console.WriteLine(tomb[i]);

            foreach (int i in tomb)
                Console.WriteLine(i);
            
            

            Console.ReadKey();

        }
    }
}
