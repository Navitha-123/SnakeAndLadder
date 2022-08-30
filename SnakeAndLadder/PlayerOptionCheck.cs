using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class PlayerOptionCheck
    {
        static int START_POSITION = 0;
        static int NO_PLAY = 0;
        static int LADDER = 1;
        static int SNAKE = 2;
        public static void SnakeAndLadderOptionCheck()
        {
            int currentPlayerPosition = 0;
            int position = 0;
            Console.WriteLine("Welcome to snake ladder game");
            Console.WriteLine("Player will start from zero position");
            Random random = new Random();
            int dieRolling = random.Next(0, 7);
            if (dieRolling == 0)
            {
                dieRolling = dieRolling + 1;
            }
            Console.WriteLine("Number on die is: " + dieRolling);
            position = currentPlayerPosition + dieRolling;
            Random randomNum = new Random();
            int checkOptions = randomNum.Next(0, 3);
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
                        if (currentPlayerPosition < 100)
                        {
                            currentPlayerPosition = position;
                        }
                    }
                    Console.WriteLine("Player is at: " + currentPlayerPosition);
                    break;
                case 2:
                    {
                        Console.WriteLine("Player is bitten by a snake");
                        if (currentPlayerPosition > 0)
                        {
                            currentPlayerPosition = position - dieRolling;
                        }
                        else if (currentPlayerPosition <= 0)
                        {
                            currentPlayerPosition = START_POSITION;
                        }
                    }
                    Console.WriteLine("Player is at: " + currentPlayerPosition);
                    break;
            }
        }
    }
}



  
