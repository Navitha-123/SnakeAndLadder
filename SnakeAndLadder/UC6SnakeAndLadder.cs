using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class UC6SnakeAndLadder
    {
        public static void DiceCount()
        {
            int option = 0, dice = 0, diceCount = 0;
            const int No_Play = 0;
            const int Is_Ladder = 1;
            const int Is_Snake = 2;
            int positionofplayer = 0;

            while (positionofplayer < 100)
            {
                diceCount++;
                Random random = new Random();
                option = random.Next(0, 3);
                dice = random.Next(1, 7);

                switch (option)
                {
                    case Is_Ladder:
                        positionofplayer = positionofplayer + dice;
                        break;
                    case Is_Snake:
                        positionofplayer = positionofplayer - dice;
                        if (positionofplayer < 0)
                        {
                            positionofplayer = 0;
                        }
                        break;
                    default:
                        // Console.WriteLine("position stays in same position");
                        break;

                }
                if (positionofplayer > 100)
                {
                    Console.WriteLine("can't move,please roll again ... position is greate than 100 :" + positionofplayer);
                    positionofplayer = positionofplayer - dice;
                }
                Console.WriteLine("positio of player is" + positionofplayer);
            }
            Console.WriteLine("The total number of dice was rolled to win the game:" + diceCount);

        }

    }
}
