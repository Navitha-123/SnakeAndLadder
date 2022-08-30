namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("choose option 1.Position at 0 ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    SnakeAndLadderPlayer.PlayerPosition0();
                    break;
            }
        }
    }
}