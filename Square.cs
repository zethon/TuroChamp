using System;
using System.Collections.Generic;
using System.Text;

namespace TuroChamp
{
    class Move
    {

    }

    public enum SquareColor
    {
        Black,
        White
    }

    public class Square
    {
        enum Rank
        {
            One = 1,
            Two, Three, Four, Five, Six, Seven, Eight
        }

        enum File
        {
            A = 1,
            B, C, D, E, F, G, H
        }

        public Piece CurrentPiece { get; set; }
        public SquareColor Color { get; set; }

        public Square(SquareColor color)
        {
            this.Color = color;
        }
    }
}
