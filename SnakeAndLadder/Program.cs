namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose position 1.playerpostion 2.roll die 3.check number of ladder,snake,play 4.winning position 5.Exact winning position 6.Dicecount 7.play2players");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    UC1SnakeAndLadder.PlayerPosition();
                    break;
                case 2:
                    UC2SnakeAndLadder.RollTheDie();
                    break;
                case 3:
                    UC3SnakeAndLadder.CheckForPosition();
                    break ;
                case 4:
                    UC4SnakeAndLadder.WinningPosition();
                    break;
                case 5:
                    UC5SnakeAndLadder.Exactwinningposition();
                    break;
                case 6:
                    UC6SnakeAndLadder.DiceCount();
                    break;
                case 7:
                    UC7SnakeAndLadder.Playwith2Players();
                    break;
                default:
                    Console.WriteLine("choose right position");
                    break;
            }
           

        }
    }
}