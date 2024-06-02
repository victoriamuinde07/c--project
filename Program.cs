using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace dicegame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints =0;
            int enemyPoints =0;

            Random random = new Random();

            for ( int i = 0; i < 10; i++)
            {
                Console.WriteLine("number of rolled dice times:");

                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a "  + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1 ,7);
                Console.WriteLine("Enemy rolled a:"  + enemyRandomNum);

                if(playerRandomNum > enemyRandomNum){
                    playerPoints++;
                    Console.WriteLine("Player wins");
                }
                else if(playerRandomNum < enemyRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins");
                }
                Console.WriteLine("The score now is for the player" + playerPoints + ".Enemy: " + enemyPoints + ".");
                Console.WriteLine();
            } 
            if(playerPoints > enemyPoints)
            {
                Console.WriteLine("winner");
            }else if(playerPoints > enemyPoints){
                Console.WriteLine("loser");
            }
            else
            {
                Console.WriteLine("its a draw");
            }
            Console.ReadKey();
        }
    }
}
