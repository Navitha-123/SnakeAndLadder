using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeAndLadderPlayer
    {
        public static void PlayerPosition0()
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Player will start from zero position");
            Random random = new Random();
            int diecheck = random.Next(0,7);
            if(diecheck == 0 )
            {
                diecheck = diecheck + 1;
            }
            Console.WriteLine("Number on die is: " + diecheck);
        }
    }
}
