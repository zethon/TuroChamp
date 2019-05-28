﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace TuroChamp
{
    public enum SquareColor
    {
        Black,
        White
    }

    public enum Rank
    {
        One = 1,
        Two, Three, Four, Five, Six, Seven, Eight
    }

    public enum File
    {
        A = 1,
        B, C, D, E, F, G, H
    }

    public class Square
    {
        public File File { get; set; }
        public Rank Rank { get; set; }

        //public static Square operator +(Square square, Vector2 move)
        //{
        //    return new Square(Rank.One, File.A);
        //}

        public Piece CurrentPiece { get; set; }
        public SquareColor Color
        {
            get
            {
                int fileMod = ((int)this.File % 2);
                int squareMod = ((int)this.Rank + fileMod) % 2;
                return (squareMod == 0) ? SquareColor.Black : SquareColor.White;
            }
        }

        public Square(Rank rank, File file)
        {
            this.Rank = rank;
            this.File = file;
        }

        public Square(File file, Rank rank)
        {
            this.Rank = rank;
            this.File = file;
        }
    }
}