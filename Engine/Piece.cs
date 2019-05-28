using System;
using System.Collections.Generic;
using System.Text;

namespace TuroChamp
{
    class Move
    {
        enum Direction
        {
            Vertical,
            Horizontal,
            Diagnoal
        }
    }

    public enum PieceColor
    {
        Black,
        White
    }

    public enum PieceType
    {
        Pawn,
        Rook,
        Knight,
        Bishop,
        King,
        Queen
    }

    public class Piece
    {
        public PieceType PieceType { get; }
        public PieceColor PieceColor { get; }

        public Piece(PieceColor color, PieceType pt)
        {
            this.PieceColor = color;
            this.PieceType = pt;
        }

        
    }

    class Pawn : Piece
    {
        Pawn(PieceColor color) 
            : base(color, PieceType.Pawn)
        {
        }
    }

    class Rook : Piece
    {
        Rook(PieceColor color) 
            : base(color, PieceType.Rook)
        {
        }
    }

    class Knight : Piece
    {
        Knight(PieceColor color) 
            : base(color, PieceType.Knight)
        {
        }
    }

    class Bishop : Piece
    {
        Bishop(PieceColor color) 
            : base(color, PieceType.Bishop)
        {
        }
    }

    class King : Piece
    {
        King(PieceColor color) 
            : base(color, PieceType.King)
        {
        }
    }

    class Queen : Piece
    {
        Queen(PieceColor color) 
            : base(color, PieceType.Queen)
        {
        }
    }
}
