﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            Console.WriteLine("Add meg a testsúlyodat: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a testmagasságodat: ");
            b = float.Parse(Console.ReadLine());
            BMI T1 = new BMI();
            T1.setTT(a);
            T1.setTM(b);
            T1.setIndex();

            Console.ReadKey();
        }
    }
}
