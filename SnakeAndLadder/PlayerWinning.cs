using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class PlayerWinning
    {
        public static int START_POSITION = 0;
        public static int NO_PLAY = 0;
        public static int LADDER = 1;
        public static int SNAKE = 2;
        public static int WINNING_POSITION = 100;

        public static void PlayerWinningPosition100()
        {
            int currentPlayerPosition = 0;
            int position = 0;

            int dieCount = 0;
            Console.WriteLine("Welcome to snake ladder game");
            Console.WriteLine("Player will start from zero position");

            while (currentPlayerPosition < WINNING_POSITION)
            {
                dieCount++;
                Random random = new Random();
                int dieRolling = random.Next(0, 7);
                if (dieRolling == 0)
                {
                    dieRolling = dieRolling + 1;

                }
                Console.WriteLine("Number on die is: " + dieRolling);
                Random random1 = new Random();
                int checkOptions = random1.Next(0, 7);
                switch (checkOptions)
                {

                    case 0:
                        {
                            Console.WriteLine("There will be no play. Player will be at same position");
                        }
                        break;

                    case 1:
                        {
                            Console.WriteLine("Player will move forward");
                            position = currentPlayerPosition;
                            if (currentPlayerPosition < 100)
                            {
                                currentPlayerPosition = currentPlayerPosition + dieRolling;

                                if (currentPlayerPosition >= WINNING_POSITION)
                                {
                                    currentPlayerPosition = position;
                                }
                            }
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Player is bitten by a snake");
                            if (currentPlayerPosition > 0)
                            {
                                currentPlayerPosition = currentPlayerPosition - dieRolling;

                            }
                            else if (currentPlayerPosition <= 0)
                            {
                                currentPlayerPosition = START_POSITION;
                            }
                        }

                        break;
                }
                Console.WriteLine("Position after each die rolled: " + currentPlayerPosition);
            }
            Console.WriteLine("Numbr of times die rolled: " + dieCount);
        }


    }

}
