using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sajatdogaize
{
    internal class Program
    {
        static int player = 0;
        static int gepp = 0;

        static void valasztas()//Főmenü metódus
        {
            string input = "";
            while (input != "1" && input != "2" && input != "3" && input != "4")
            {
                Console.WriteLine("Kő, Papír, Olló");
                Console.WriteLine();
                Console.WriteLine("Válassz: ");
                Console.WriteLine("1 Start");
                //Console.WriteLine("2 Opciók");
                //Console.WriteLine("3 ");
                Console.WriteLine("4 Kilépés");
                Console.WriteLine();


                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        start();
                        break;
                    //   case "2":
                    //       break;
                    // case "3":
                    //     Console.WriteLine();
                    //     Console.WriteLine("HÁR");
                    //     Console.WriteLine();
                    //     break;
                    case "4":
                        Console.WriteLine();
                        Console.WriteLine("Szia Lajos.");
                        Console.WriteLine();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine();
                        break;
                }
            }
        }
        static void start() //A játék kezdete metódus
        {

            string input = "";
            while (input != "1" && input != "2" && input != "3" && input != "4")
            {


                Console.WriteLine("Válassz: ");
                Console.WriteLine("1 Kő");
                Console.WriteLine("2 Papír");
                Console.WriteLine("3 Olló ");
                Console.WriteLine();

                input = Console.ReadLine();
                switch (input)
                {

                    case "1":
                        player = 1;
                        Console.Clear();
                        Console.WriteLine("A váasztásod Kő");
                        break;
                    case "2":
                        player = 2;
                        Console.Clear();
                        Console.WriteLine("A váasztásod Papír");
                        break;
                    case "3":
                        player = 3;
                        Console.Clear();
                        Console.WriteLine("A váasztásod Olló");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine();
                        break;
                }
            }
            gep();
        }
        static void gep() // A számítógép választásának metódusa
        {
            string gv = "";
            Random random = new Random();
            gepp = random.Next(1, 3);
            if (gepp == 1)
            {
                gv = "Kő";
            }
            else if (gepp == 2)
            {
                gv = "Papír";
            }
            else
            {
                gv = "Olló";
            }
            Console.WriteLine($"A gép választása {gv}");
        }

        static void vegkimenet() //A két választás utáni végkimenetel metódusa
        {
            if (player == gepp)
            {
                Console.WriteLine("Döntetlen");
            }
            else if (player == 1 && gepp == 2 || player == 2 && gepp == 3 || player == 3 && gepp == 1)
            {
                Console.WriteLine("A gép nyert");
            }
            else if (player == 2 && gepp == 1 || player == 3 && gepp == 2 || player == 1 && gepp == 3)
            {
                Console.WriteLine("Nyertél!");
            }
        }
        static void Main(string[] args)
        {
            valasztas();
            vegkimenet();
            Console.ReadKey();
        }
    }
}
