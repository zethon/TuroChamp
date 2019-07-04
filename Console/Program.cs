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
        Game CurrentGame = null;

        private void doPrint(List<string> args)
        {
            if (args.Count == 0)
            {
                BoardPrinter.printBoard(CurrentGame.Board);
            }
            else
            {
                switch (args[0].ToLower())
                {
                    default:
                    break;

                    case "king":
                    {
                        Console.WriteLine("\u2649");
                    }
                    break;
                }
            }
        }

        public void Run()
        {
            CurrentGame = new Game();

            bool done = false;
            while (!done)
            {
                Console.Write(">");
                string command = Console.ReadLine().Trim();

                string[] args = command.Split(' ');
                if (args.Length == 0) continue;

                List<string> argList = args.ToList<string>();
                argList.RemoveAt(0);

                switch (args[0])
                {
                    default:
                    break;

                    case "print":
                    {
                        doPrint(argList);
                    }
                    break;

                    case "exit":
                    case "quit":
                    {
                        done = true;
                    }
                    break;
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
