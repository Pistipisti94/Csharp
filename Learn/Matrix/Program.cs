﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix Matrixx= new Matrix();
            Matrixx.setN();
            Console.ReadKey();
        }
    }
}
