using System;
using System.Collections.Generic;
using System.Text;

namespace TuroChamp
{
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
        public Color Color { get; }
        public bool Moved { get; set; } = false;
        public bool Captured { get; set; } = false;

        public Piece(Color color, PieceType pt)
        {
            this.Color = color;
            this.PieceType = pt;
        }   
    }

    public class Pawn : Piece
    {
        public Pawn(Color color) 
            : base(color, PieceType.Pawn)
        {
        }
    }

    public class Rook : Piece
    {
        public Rook(Color color) 
            : base(color, PieceType.Rook)
        {
        }
    }

    public class Knight : Piece
    {
        public Knight(Color color) 
            : base(color, PieceType.Knight)
        {
        }
    }

    public class Bishop : Piece
    {
        public Bishop(Color color) 
            : base(color, PieceType.Bishop)
        {
        }
    }

    public class King : Piece
    {
        public Rook QueensideRook { get; }
        public Rook KingsideRook { get; }

        public King(Rook r1, Rook r2) 
            : base(r1.Color, PieceType.King)
        {
            QueensideRook = r1;
            KingsideRook = r2;
        }
    }

    public class Queen : Piece
    {
        public Queen(Color color) 
            : base(color, PieceType.Queen)
        {
        }
    }
}
