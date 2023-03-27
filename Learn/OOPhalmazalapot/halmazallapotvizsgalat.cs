using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPhalmazalapot
{
    internal class halmazallapotvizsgalat
    {
        private int Halmaz;

        public halmazallapotvizsgalat() { }
        public halmazallapotvizsgalat(int Halmaz)
        {
            this.Halmaz = Halmaz;
        }
        public void setHalmaz(int Halmaz)
        {
            this.Halmaz = Halmaz;

            if (this.Halmaz < 0)
            {
                Console.WriteLine("A víz halmazállapota: Szilárd");
            }
            else if (this.Halmaz >= 0 && this.Halmaz < 100)
            {
                Console.WriteLine("A víz halmazállapota: Folyékony");
            }
            else if (this.Halmaz >= 100)
            {
                Console.WriteLine("A víz halmazállapota: Gőz");
            }
        }
        public double getHalmaz()
        {
            return this.Halmaz;
        }
    }
}
