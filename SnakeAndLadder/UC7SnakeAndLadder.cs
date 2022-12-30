using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class UC7SnakeAndLadder
    {
        public const int Is_Ladder = 1;
        public const int Is_Snake = 2;
        public const int Is_Player1 = 1;
        public const int Is_Player2 = 2;

        public static void Playwith2Players()
        {
            int player = 1;
            int positionofplayer1 = 0;
            int positionofplayer2 = 0;
            int dierollcount = 0;
            while(positionofplayer1<100 && positionofplayer2<100)
            {
                dierollcount++;
                Random random = new Random();
                int dice = random.Next(1, 7);
                int option = random.Next(0,3);

                switch (option)
                {
                    case Is_Ladder:
                        Console.WriteLine("The player {player} rolled a die " + dice);
                        Console.WriteLine("yeah! player{player},its ladder , you move ahead");
                        if (player == Is_Player1)
                        {
                            positionofplayer1 += dice;
                        }
                        else
                        {
                            positionofplayer2 += dice;
                        }
                        break;
                    case Is_Snake:

                        Console.WriteLine("The player {player} rolled a die " + dice);
                        Console.WriteLine("oops! player{player},its ladder , you are going down");
                        if (player == Is_Player2)
                        {
                            positionofplayer2 -= dice;
                            if (positionofplayer2 < 0)
                            {
                                positionofplayer2 = 0;

                            }
                            else
                            {
                                positionofplayer1 -= dice;
                                if (positionofplayer1 < 0)
                                {
                                    positionofplayer1 = 0;
                                }

                            }

                        }
                        break;

                    default:
                        Console.WriteLine("player{player} u can't move");
                        break;
                }
                        if(positionofplayer1 > 100 || positionofplayer2 > 100)
                        {
                            Console.WriteLine("player{player} cannot move .... roll again");
                            if (player == Is_Player1)
                                positionofplayer1 -= dice;
                            else
                                positionofplayer2 -= dice;
                        }
                        Console.WriteLine("position of player1 : \t" +positionofplayer1);
                        Console.WriteLine("positin of player2 : \t" +positionofplayer2);

                        if(option == Is_Ladder)
                        {
                            Console.WriteLine("congrats! it's an ladder,player{player}, got one more chance to roll dice");

                        }
                        else if(player == Is_Player1)
                        {
                            Console.WriteLine("second player turn");
                            player = 2;
                        }
                        else
                        {
                            Console.WriteLine("first player turn");
                            player = 1;
                        }

            }
                Console.WriteLine("The total number of time die was rolled to win is :" +dierollcount);
                if(positionofplayer1 == 100)
                {
                    Console.WriteLine("player1 wins");
                }
                else
                {
                    Console.WriteLine("player2 wins");
                }
          
        }
    }
}
