using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random= new Random();

            string compChoice = "";
            string playerChoice = "";

            int compScore = 0; 
            int playerScore = 0;

            bool l = true;
            do
            {
                Console.WriteLine("Akarsz még játszani? i/n");
                if (Console.ReadKey(true).KeyChar == 'n')
                    l = false;
            } while(l);
            Console.WriteLine("Mit választasz? (k/p/o)");

            switch (Console.ReadKey(true).KeyChar)
            {
                case 'k':
                    playerChoice = "kő";
                    break;
                case 'p':
                    playerChoice = "papír";
                    break;
                case 'o':
                    playerChoice = "olló";
                    break;
            }
            switch (random.Next(0,3)) 
            {
                case 0:
                    compChoice = "kő";
                    break;
                case 1:
                    compChoice = "papír";
                    break;
                case 2:
                    compChoice = "olló";
                    break;
            }
            if( (playerChoice=="kő"&&compChoice=="papír")
                ||
                    (playerChoice=="papír"&&compChoice=="olló")
                    ||
                    (playerChoice=="olló" && compChoice=="kő")    
                )
            {
                Console.WriteLine("Veszítettél! Az állás:\nSzámítógép: {0}\nJátékos:{1}", ++compScore, playerScore); 
            }
            else if(playerChoice == compChoice)
            {
                Console.WriteLine("Döntetlen! Az állás:\nSzámítógép: {0}\nJátékos:{1}", compScore, playerScore);
            }
            else
            {
                Console.WriteLine("Nyertél! Az állás:\nSzámítógép: {0}\nJátékos:{1}", compScore, ++playerScore);
            }
            Console.ReadKey();

        }
    }
}
