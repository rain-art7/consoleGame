using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Character("Dravolas the conqueror", "Male", 50, 200);
            player.Stats();

            var computer = new Character("Computer", "unknown", 50, 200);
            computer.Stats();

            var challenge = new CombatSystem();

            do
            {
                if (challenge.Attack() == true)
                {
                    player.Attack(computer);
                    computer.Stats();
                }
                else
                {
                    computer.Attack(player);
                    player.Stats();
                }
            } while (player.IsAlive == true && computer.IsAlive == true);

            if(player.IsAlive == true)
            {
                Console.WriteLine("Congratulations, you won the game !");
            }else if (player.IsAlive == false)
            {
                Console.WriteLine("You lost.");
            }
            else
            {
                Console.WriteLine("Unknown error has occured.");
            }

            Console.ReadKey();
        }
    }
}