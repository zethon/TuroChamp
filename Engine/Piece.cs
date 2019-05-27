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
        public PieceType pieceType { get; set; }

        public Piece(PieceType pt)
        {
            this.pieceType = pt;
        }
    }

    class Pawn : Piece
    {
        Pawn() : base(PieceType.Pawn)
        {
        }
    }

    class Rook : Piece
    {
        Rook() : base(PieceType.Rook)
        {
        }
    }

    class Knight : Piece
    {
        Knight() : base(PieceType.Knight)
        {
        }
    }

    class Bishop : Piece
    {
        Bishop() : base(PieceType.Bishop)
        {
        }
    }

    class King : Piece
    {
        King() : base(PieceType.King)
        {
        }
    }

    class Queen : Piece
    {
        Queen() : base(PieceType.Queen)
        {
        }
    }
}
