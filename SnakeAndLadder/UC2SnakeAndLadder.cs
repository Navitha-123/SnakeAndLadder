using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class UC2SnakeAndLadder
    {
        public static void RollTheDie()
        {
            Random random = new Random();
            int num = random.Next(0, 7);
            Console.WriteLine("The player get a number " + num);
        }
    }
}
