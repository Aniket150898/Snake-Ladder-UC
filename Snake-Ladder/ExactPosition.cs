using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{
    public class Program
    {
        public int PlayerPosition = 0;
        const int NoPlay = 0, Ladder = 1, Snake = 2, Winning = 100;
        public void ExactPosition()
        {
            while (PlayerPosition < 100)
            {
                Random diceroll = new Random();
                int dice = diceroll.Next(1, 7);
                Console.WriteLine(" Player roll the dice and the number is :" + dice);

                Random check = new Random();
                int Option = check.Next(0, 3);

                switch (Option)
                {
                    case NoPlay:
                        Console.WriteLine("No Play");
                        break;
                    case Ladder:
                        PlayerPosition += dice;
                        Console.WriteLine("You reached a Ladder : " + PlayerPosition);
                        break;
                    case Snake:
                        PlayerPosition -= dice;
                        Console.WriteLine("You got eaten by a Snake : " + PlayerPosition);
                        break;
                    default:
                        Console.WriteLine("Enter a valid input.");
                        break;

                }
                if (PlayerPosition < 0)
                {
                    PlayerPosition = 0;
                }


            }
        }

    }
}
