using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TuroChamp;

namespace Tests
{
    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void SquareColorTest()
        {
            var data = new List<Tuple<File, Rank, SquareColor>>
            {
                Tuple.Create(File.A, Rank.One, SquareColor.Black),
                Tuple.Create(File.A, Rank.Two, SquareColor.White),
                Tuple.Create(File.A, Rank.Three, SquareColor.Black),
                Tuple.Create(File.A, Rank.Four, SquareColor.White),
                Tuple.Create(File.A, Rank.Five, SquareColor.Black),
                Tuple.Create(File.A, Rank.Six, SquareColor.White),
                Tuple.Create(File.A, Rank.Seven, SquareColor.Black),
                Tuple.Create(File.A, Rank.Eight, SquareColor.White),
                
                Tuple.Create(File.B, Rank.One, SquareColor.White),
                Tuple.Create(File.B, Rank.Two, SquareColor.Black),
                Tuple.Create(File.B, Rank.Three, SquareColor.White),
                Tuple.Create(File.B, Rank.Four, SquareColor.Black),
                Tuple.Create(File.B, Rank.Five, SquareColor.White),
                Tuple.Create(File.B, Rank.Six, SquareColor.Black),
                Tuple.Create(File.B, Rank.Seven, SquareColor.White),
                Tuple.Create(File.B, Rank.Eight, SquareColor.Black),
                
                Tuple.Create(File.C, Rank.One, SquareColor.Black),
                Tuple.Create(File.C, Rank.Two, SquareColor.White),
                Tuple.Create(File.C, Rank.Three, SquareColor.Black),
                Tuple.Create(File.C, Rank.Four, SquareColor.White),
                Tuple.Create(File.C, Rank.Five, SquareColor.Black),
                Tuple.Create(File.C, Rank.Six, SquareColor.White),
                Tuple.Create(File.C, Rank.Seven, SquareColor.Black),
                Tuple.Create(File.C, Rank.Eight, SquareColor.White),
                
                Tuple.Create(File.D, Rank.One, SquareColor.White),
                Tuple.Create(File.D, Rank.Two, SquareColor.Black),
                Tuple.Create(File.D, Rank.Three, SquareColor.White),
                Tuple.Create(File.D, Rank.Four, SquareColor.Black),
                Tuple.Create(File.D, Rank.Five, SquareColor.White),
                Tuple.Create(File.D, Rank.Six, SquareColor.Black),
                Tuple.Create(File.D, Rank.Seven, SquareColor.White),
                Tuple.Create(File.D, Rank.Eight, SquareColor.Black),
                
                Tuple.Create(File.E, Rank.One, SquareColor.Black),
                Tuple.Create(File.E, Rank.Two, SquareColor.White),
                Tuple.Create(File.E, Rank.Three, SquareColor.Black),
                Tuple.Create(File.E, Rank.Four, SquareColor.White),
                Tuple.Create(File.E, Rank.Five, SquareColor.Black),
                Tuple.Create(File.E, Rank.Six, SquareColor.White),
                Tuple.Create(File.E, Rank.Seven, SquareColor.Black),
                Tuple.Create(File.E, Rank.Eight, SquareColor.White),
                
                Tuple.Create(File.F, Rank.One, SquareColor.White),
                Tuple.Create(File.F, Rank.Two, SquareColor.Black),
                Tuple.Create(File.F, Rank.Three, SquareColor.White),
                Tuple.Create(File.F, Rank.Four, SquareColor.Black),
                Tuple.Create(File.F, Rank.Five, SquareColor.White),
                Tuple.Create(File.F, Rank.Six, SquareColor.Black),
                Tuple.Create(File.F, Rank.Seven, SquareColor.White),
                Tuple.Create(File.F, Rank.Eight, SquareColor.Black),
                
                Tuple.Create(File.G, Rank.One, SquareColor.Black),
                Tuple.Create(File.G, Rank.Two, SquareColor.White),
                Tuple.Create(File.G, Rank.Three, SquareColor.Black),
                Tuple.Create(File.G, Rank.Four, SquareColor.White),
                Tuple.Create(File.G, Rank.Five, SquareColor.Black),
                Tuple.Create(File.G, Rank.Six, SquareColor.White),
                Tuple.Create(File.G, Rank.Seven, SquareColor.Black),
                Tuple.Create(File.G, Rank.Eight, SquareColor.White),
                
                Tuple.Create(File.H, Rank.One, SquareColor.White),
                Tuple.Create(File.H, Rank.Two, SquareColor.Black),
                Tuple.Create(File.H, Rank.Three, SquareColor.White),
                Tuple.Create(File.H, Rank.Four, SquareColor.Black),
                Tuple.Create(File.H, Rank.Five, SquareColor.White),
                Tuple.Create(File.H, Rank.Six, SquareColor.Black),
                Tuple.Create(File.H, Rank.Seven, SquareColor.White),
                Tuple.Create(File.H, Rank.Eight, SquareColor.Black),
            };

            foreach (var v in data)
            {
                Square square = new Square(v.Item1, v.Item2);
                Assert.AreEqual(square.Color, v.Item3);
            }
        }

        [TestMethod]
        public void PositionAdditionTest()
        {
            var data = new List<Tuple<Position, Move, Position>>
            {
                Tuple.Create
                (
                    new Position(File.A, Rank.One),
                    new Move
                    {
                        Segments =
                        {
                            new Move.Segment{ Direction = Move.Direction.Vertical, Degree = 1}
                        }
                    },
                    new Position(File.A, Rank.Two)
                )
            };

            foreach (var v in data)
            {
                Square square = new Square(v.Item1, v.Item2);
                Assert.AreEqual(square.Color, v.Item3);
            }

            Position position = new Position(File.A, Rank.One);

            Move move = new Move();
            move.Segments.Add(new Move.Segment{ Direction = Move.Direction.Vertical, Degree = 1});

            Position newposition = position + move;
            Assert.AreEqual(new Position(File.A, Rank.Two), newposition);
        }
    }
}
