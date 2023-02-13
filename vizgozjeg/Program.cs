using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizgozjeg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A víz hőmérséklete: ");
            int viz = Convert.ToInt32(Console.ReadLine());
            if (viz <= 0) 
            {
                Console.WriteLine("A víz szilárd halmazállapotú.");
            }
            else if(viz > 0 && viz < 100)
            {
                Console.WriteLine("A víz folyékony halmazállapotú.");
            }
            else if (viz > 100) 
            {
                Console.WriteLine("A víz gőz halmazállapotú.");
            }
            Console.ReadKey();
        }
    }
}
