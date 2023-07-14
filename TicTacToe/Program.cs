namespace TicTacToe
{
    public class Player
    {
        public string Name;
        public string Marker;
       public Player(string name, string marker)
        {
            Name = name;
            Marker = marker;
        }
    }
    internal class Program
    {
        public static string[][] Board; 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe mane.");
            Console.WriteLine("Player 1's name: ");
            string Player1Name = Console.ReadLine();
            Player player1 = new Player(Player1Name, "X");
            Console.WriteLine(Player1Name + " Is this you?");
            Console.WriteLine("Player 2's name: ");
            string Player2Name = Console.ReadLine();
            Player player2 = new Player(Player2Name, "O");
            Console.WriteLine(player2.Name + " Ready to Rock?");
            Console.WriteLine(player1.Name + " vs " + player2.Name);
            Board = new string[][]
            {
                new string []  {"|1|", "|2|" ,"|3|" },
                new string []  {"|4|", "|5|", "|6|" },
                new string []  {"|7|", "|8|", "|9|" }
            };
            Console.WriteLine("Here's the Board");
           DisplayBoard();

            Player currentPlayer = player1;
            string winner = null;
            while (winner == null)
            {
                Console.WriteLine("It's {0}'s turn!", currentPlayer.Name);

                Console.WriteLine("Please choose a slot.");
                DisplayBoard();
                string selectedSlot = Console.ReadLine();

                if (selectedSlot == "1")
                {
                    Board[0][0] = String.Format("|{0}|",
                        currentPlayer.Marker);
                }

                if(currentPlayer == player1)
                {
                    currentPlayer =player2;
                }else if(currentPlayer == player2)
                {
                    currentPlayer = player1;
                }
            }
        }
        static void DisplayBoard()
        {
            Console.WriteLine("{0}{1}{2}", Board[0][0], Board[0][1],
                Board[0][2] );
            Console.WriteLine("{0}{1}{2}", Board[1][0], Board[1][1],
                Board[1][2]);
            Console.WriteLine("{0}{1}{2}", Board[2][0], Board[2][1],
                Board[2][2]);
        }
    }
}