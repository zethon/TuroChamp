using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace TuroChamp
{
    public class SegmentDegreeException : Exception
    {
        public SegmentDegreeException(Int32 degree)
            : base(String.Format("Invalid segment degree '{0}'", degree))
        { }
    }

    public class InvalidSquareException : Exception
    {
        public InvalidSquareException(string error)
            : base(error)
        { }
    }

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

    public class Move
    {
        public enum Direction
        {
            Vertical,
            Horizontal,
            Diagnoal
        }

        public struct Segment
        {
            public Direction Direction;
            public Int32 Degree;
        }

        public List<Segment> Segments { get; set; } 
            = new List<Segment>();
    }

    public class Position
    {
        public Rank Rank { get; set; }
        public File File { get; set; }

        public Position(Rank rank, File file)
        {
            Rank = rank;
            File = file;
        }

        public Position(File file, Rank rank)
        {
            Rank = rank;
            File = file;
        }

        public override bool Equals(object obj)
        {
            Position other = (Position)obj;
            return (other.Rank == this.Rank) && (other.File == this.File);
        }

        public override int GetHashCode()
        {
            // since `this.Rank` and `this.File` are two different types there
            // is no way the hash codes could be equal
            return this.Rank.GetHashCode() ^ this.File.GetHashCode();
        }

        public static Position operator +(Position position, Move move)
        {
            if (move.Segments.Count == 0) return position;

            Position newposition = position;
            foreach (Move.Segment segment in move.Segments)
            {
                if (segment.Degree < -7 || segment.Degree > 7)
                {
                    throw new SegmentDegreeException(segment.Degree);
                }

                switch (segment.Direction)
                {
                    default:
                    break;

                    case Move.Direction.Vertical:
                    {
                        Int32 rankNumber = (Int32)newposition.Rank + segment.Degree;
                        if (rankNumber < 0 || rankNumber > 8)
                        {
                            throw new InvalidSquareException("Invalid square");
                        }
                        newposition.Rank = (Rank)rankNumber;
                    }
                    break;

                    case Move.Direction.Horizontal:
                    {
                        Int32 fileNumber = (Int32)newposition.File + segment.Degree;
                        if (fileNumber < 0 || fileNumber > 8)
                        {
                            throw new InvalidSquareException("Invalid square");
                        }
                        newposition.File = (File)fileNumber;
                    }
                    break;

                    case Move.Direction.Diagnoal:
                    {

                    }
                    break;  
                }
            }

            return newposition;
        }
    }

    public class Square
    {
        public File File { get; set; }
        public Rank Rank { get; set; }

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
