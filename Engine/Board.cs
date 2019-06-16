using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TuroChamp
{
    public class Board
    {
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

            Squares[0].Piece = new Rook(Color.White);
            Squares[1].Piece = new Knight(Color.White);
            Squares[2].Piece = new Bishop(Color.White);
            Squares[3].Piece = new Queen(Color.White);
            Squares[5].Piece = new Bishop(Color.White);
            Squares[6].Piece = new Knight(Color.White);
            Squares[7].Piece = new Rook(Color.White);

            // white king
            Squares[4].Piece = new King((Rook)(Squares[0].Piece), (Rook)(Squares[7].Piece));

            foreach (int index in Enumerable.Range(8, 8))
            {
                Squares[index].Piece = new Pawn(Color.White);
            }

            foreach (int index in Enumerable.Range(48,8))
            {
                Squares[index].Piece = new Pawn(Color.Black);
            }

            Squares[56].Piece = new Rook(Color.Black);
            Squares[57].Piece = new Knight(Color.Black);
            Squares[58].Piece = new Bishop(Color.Black);
            Squares[59].Piece = new Queen(Color.Black);
            Squares[61].Piece = new Bishop(Color.Black);
            Squares[62].Piece = new Knight(Color.Black);
            Squares[63].Piece = new Rook(Color.Black);

            // black king
            Squares[60].Piece = new King((Rook)(Squares[56].Piece), (Rook)(Squares[63].Piece));
        }
    }
}
