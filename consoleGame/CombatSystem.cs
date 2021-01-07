using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Console = Colorful.Console;
using System.Drawing;
using System.Threading.Tasks;

namespace consoleGame
{
    class CombatSystem
    {
        //array of sentences - update to api in the future
        string[] targetText = new string[]
        { "Hello my name is John."
        , "Our school has awesome teachers."
        , "Truth in advertising and dinosaurs with skateboards have much in common."
        , "Europe is almost like a cheese."
        , "Math is a rewarding subject."
        , "Sometimes, all you need to do is completely make an ass of yourself and laugh it off to realise that life isn't so bad after all."
        , "He barked orders at his daughters but they just stared back with amusement."
        , "The gloves protect my feet from excess work."};

        //variable with instance of random method
        Random random = new Random();
     
        public bool Attack()
        {
            //variable with random array index number
            int num = random.Next(targetText.Length);

            //show the random array index number
            Console.Write("{0}.) ", num + 1);
            //shows the value of random array index number
            Console.Write("{0}\n", targetText[num]);

            //stopwatch expcet it locks me for the duration of the timer
            
            //var time = new Stopwatch();
            //time.Measure();

            //user input
            Console.Write("here: ");
            string input = Console.ReadLine();

            // if/else comparison of user input to the sentence from array
            if (input == targetText[num])
            {
                Console.WriteLine("\nAttack was successful.\n");
                return true;
            }
            else
            {
                Console.WriteLine("\nAttack failed.\n");
                return false;
            }
        }
    }
}