using System;
using System.Collections.Generic;
using System.Text;

namespace TuroChamp
{
    public class SquareList : List<Square>
    {

    }

    public class Board
    {
        // board[File.
        // Square(A,1)
        // var piece = board.Square(A,1);
        // board.CanMove(Ax1, Dx2);
        // board.Move(Ax1



        public List<Square> Squares { get; private set; }

        public Board()
        {
            Squares = new List<Square>();
            foreach(Rank rank in Enum.GetValues(typeof(Rank)))
            {
                foreach(File file in Enum.GetValues(typeof(File)))
                {
                    Squares.Add(new Square(rank, file));
               }
            }
        }
    }
}
