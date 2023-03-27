using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Matrix
    {
         
        private int[,] NxN = new int[2,2];
        public Matrix() { }
        public int getN() { return NxN[2,2]; }
        public void setN() 
        {
            for (int i = 0; i < NxN.GetLength(0); i++)
            {
                for (int j = 0; j < NxN.GetLength(1); j++)
                {
                    Console.Write("{0} ", NxN[i, j]);
                }
                Console.WriteLine();
            }

        }
        

    }
}
