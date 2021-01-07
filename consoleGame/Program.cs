using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;
using System.Drawing;

namespace consoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = Color.Black;
            Console.BackgroundColor = Color.SlateGray;

            Console.Clear();

            Console.WriteLine(@"



██████╗ ██╗   ██╗███╗   ██╗ ██████╗ ███████╗ ██████╗ ███╗   ██╗        ██████╗ ███████╗       ██████╗  ██████╗  ██████╗ ███╗   ███╗
██╔══██╗██║   ██║████╗  ██║██╔════╝ ██╔════╝██╔═══██╗████╗  ██║       ██╔═══██╗██╔════╝       ██╔══██╗██╔═══██╗██╔═══██╗████╗ ████║
██║  ██║██║   ██║██╔██╗ ██║██║  ███╗█████╗  ██║   ██║██╔██╗ ██║       ██║   ██║█████╗         ██║  ██║██║   ██║██║   ██║██╔████╔██║
██║  ██║██║   ██║██║╚██╗██║██║   ██║██╔══╝  ██║   ██║██║╚██╗██║       ██║   ██║██╔══╝         ██║  ██║██║   ██║██║   ██║██║╚██╔╝██║
██████╔╝╚██████╔╝██║ ╚████║╚██████╔╝███████╗╚██████╔╝██║ ╚████║       ╚██████╔╝██║            ██████╔╝╚██████╔╝╚██████╔╝██║ ╚═╝ ██║
╚═════╝  ╚═════╝ ╚═╝  ╚═══╝ ╚═════╝ ╚══════╝ ╚═════╝ ╚═╝  ╚═══╝        ╚═════╝ ╚═╝            ╚═════╝  ╚═════╝  ╚═════╝ ╚═╝     ╚═╝
                                                                                                                                   



                                                                          ", Color.DarkRed);
            System.Console.WriteLine("Press any key to start the game");
            Console.ReadKey(true);

            var player = new Character("Dravolas", "Male", 50, 200);
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
                Console.WriteLine("\nCongratulations, you won the game !");
            }else if (player.IsAlive == false)
            {
                Console.WriteLine("\nYou lost.");
            }
            else
            {
                Console.WriteLine("Unknown error has occured.");
            }

            Console.ReadKey();
        }
    }
}