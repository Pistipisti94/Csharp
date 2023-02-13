using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tombok02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sor = 10;
            int oszlop = 3;
            int alsohatar = 10,
                felsohatar = 1000;
            int[,] tomb = new int[sor, oszlop];
            Random rand = new Random();

            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < oszlop; j++)
                {
                    tomb[i, j] = rand.Next(alsohatar, felsohatar);
                    
                }
                

            }
            for (int i = 0; i < sor; i++)
                { 
                for (int j = 0; j < oszlop; j++)
                
                    Console.Write(tomb[i,j] + " ");
                Console.WriteLine();
                }
                

            



            Console.ReadKey();
        }
    }
}
