using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TuroChamp;

namespace ConsoleApp
{
    class BoardPrinter
    {
        private const string _topRow = "    A     B     C     D    E      F    G      H";
        private const string _rankSep = " #################################################";
        private const string _borderWalls = " #     #     #     #     #     #     #     #     #";

        static public void printBoard(Board board)
        {
            Console.WriteLine(_topRow);

            // 1 rank
            Console.WriteLine(_rankSep);
            Console.WriteLine(_borderWalls);
            Console.WriteLine(" #  R  #  N  #  B  #  K  #  Q  #  B  #  N  #  R  #");
            Console.WriteLine(_borderWalls);

            // 2 rank
            Console.WriteLine(_rankSep);
            Console.WriteLine(_borderWalls);
            Console.WriteLine(" #  P  #  P  #  P  #  P  #  P  #  P  #  P  #  P  #");
            Console.WriteLine(_borderWalls);

            // 3 rank
            Console.WriteLine(_rankSep);
            Console.WriteLine(_borderWalls);
            Console.WriteLine(_borderWalls);
            Console.WriteLine(_borderWalls);

            // 4 rank
            Console.WriteLine(_rankSep);
            Console.WriteLine(_borderWalls);
            Console.WriteLine(_borderWalls);
            Console.WriteLine(_borderWalls);

            // 5 rank
            Console.WriteLine(_rankSep);
            Console.WriteLine(_borderWalls);
            Console.WriteLine(_borderWalls);
            Console.WriteLine(_borderWalls);

            // 6 rank
            Console.WriteLine(_rankSep);
            Console.WriteLine(_borderWalls);
            Console.WriteLine(_borderWalls);
            Console.WriteLine(_borderWalls);

            // 7 rank
            Console.WriteLine(_rankSep);
            Console.WriteLine(_borderWalls);
            Console.WriteLine(" #  P  #  P  #  P  #  P  #  P  #  P  #  P  #  P  #");
            Console.WriteLine(_borderWalls);

            // 8 rank
            Console.WriteLine(_rankSep);
            Console.WriteLine(_borderWalls);
            Console.WriteLine(" #  R  #  N  #  B  #  K  #  Q  #  B  #  N  #  R  #");
            Console.WriteLine(_borderWalls);

            // bottom
            Console.WriteLine(_rankSep);
        }
    }

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
            //Square bsqoard = new Square(Color.White);
            Console.WriteLine("TuroChamp!");

            App app = new App();
            app.Run();
        }
    }
}
