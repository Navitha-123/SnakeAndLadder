using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class UC3SnakeAndLadder
    {
        public static void CheckForPosition()
        {
            const int No_Play = 0;  
            const int Is_Ladder = 1;
            const int Is_Snake = 2;
            int positionofplayer = 0;

            Random random = new Random();   
            int option = random.Next(0,3);
            int diece = random.Next(0,7); 
            
            switch(option)
            {
                case No_Play:
                    Console.WriteLine("The player stays in same position");
                    break;
                case Is_Ladder:
                    positionofplayer = positionofplayer + diece;
                    Console.WriteLine("positio of player " + positionofplayer + "roll a dice" + diece);
                    break;
                case Is_Snake:
                    positionofplayer = positionofplayer - diece;
                    if(positionofplayer < 0)
                    {
                        positionofplayer=0; 
                    }
                    Console.WriteLine("positio of player " + positionofplayer + "roll a dice" + diece);
                    break;

            }
        }
    }
}
