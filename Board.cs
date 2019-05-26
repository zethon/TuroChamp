using System;
using System.Collections.Generic;
using System.Text;

namespace TuroChamp
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

    class Board
    {
        List<Square> Squares { get; set; }
        //List<>
    }
}
