using System;

namespace TuroChamp
{
    class Game
    {
        public Board Board { get; set; }

        public Game()
        {
            Board = new Board();
        }
    }

    class App
    {
        // private Game game = null;

        public void Run()
        {
            Board board = new Board();

            bool done = false;
            while (!done)
            {
                Console.Write(">");
                string command = Console.ReadLine();
                if (command == "print")
                {
                    BoardPrinter.printBoard(board);
                }
                else if (command.ToLower() == "quit")
                {
                    done = true;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Square bsqoard = new Square(SquareColor.White);
            Console.WriteLine("TuroChamp!");

            App app = new App();
            app.Run();
        }
    }
}
