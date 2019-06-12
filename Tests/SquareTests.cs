using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TuroChamp;

namespace Tests
{
    [TestClass, TestCategory("Data")]
    public class SquareTests
    {
        [TestMethod]
        public void SquareColorTest()
        {
            var data = new List<Tuple<File, Rank, Color>>
            {
                Tuple.Create(File.A, Rank.One, Color.Black),
                Tuple.Create(File.A, Rank.Two, Color.White),
                Tuple.Create(File.A, Rank.Three, Color.Black),
                Tuple.Create(File.A, Rank.Four, Color.White),
                Tuple.Create(File.A, Rank.Five, Color.Black),
                Tuple.Create(File.A, Rank.Six, Color.White),
                Tuple.Create(File.A, Rank.Seven, Color.Black),
                Tuple.Create(File.A, Rank.Eight, Color.White),
                
                Tuple.Create(File.B, Rank.One, Color.White),
                Tuple.Create(File.B, Rank.Two, Color.Black),
                Tuple.Create(File.B, Rank.Three, Color.White),
                Tuple.Create(File.B, Rank.Four, Color.Black),
                Tuple.Create(File.B, Rank.Five, Color.White),
                Tuple.Create(File.B, Rank.Six, Color.Black),
                Tuple.Create(File.B, Rank.Seven, Color.White),
                Tuple.Create(File.B, Rank.Eight, Color.Black),
                
                Tuple.Create(File.C, Rank.One, Color.Black),
                Tuple.Create(File.C, Rank.Two, Color.White),
                Tuple.Create(File.C, Rank.Three, Color.Black),
                Tuple.Create(File.C, Rank.Four, Color.White),
                Tuple.Create(File.C, Rank.Five, Color.Black),
                Tuple.Create(File.C, Rank.Six, Color.White),
                Tuple.Create(File.C, Rank.Seven, Color.Black),
                Tuple.Create(File.C, Rank.Eight, Color.White),
                
                Tuple.Create(File.D, Rank.One, Color.White),
                Tuple.Create(File.D, Rank.Two, Color.Black),
                Tuple.Create(File.D, Rank.Three, Color.White),
                Tuple.Create(File.D, Rank.Four, Color.Black),
                Tuple.Create(File.D, Rank.Five, Color.White),
                Tuple.Create(File.D, Rank.Six, Color.Black),
                Tuple.Create(File.D, Rank.Seven, Color.White),
                Tuple.Create(File.D, Rank.Eight, Color.Black),
                
                Tuple.Create(File.E, Rank.One, Color.Black),
                Tuple.Create(File.E, Rank.Two, Color.White),
                Tuple.Create(File.E, Rank.Three, Color.Black),
                Tuple.Create(File.E, Rank.Four, Color.White),
                Tuple.Create(File.E, Rank.Five, Color.Black),
                Tuple.Create(File.E, Rank.Six, Color.White),
                Tuple.Create(File.E, Rank.Seven, Color.Black),
                Tuple.Create(File.E, Rank.Eight, Color.White),
                
                Tuple.Create(File.F, Rank.One, Color.White),
                Tuple.Create(File.F, Rank.Two, Color.Black),
                Tuple.Create(File.F, Rank.Three, Color.White),
                Tuple.Create(File.F, Rank.Four, Color.Black),
                Tuple.Create(File.F, Rank.Five, Color.White),
                Tuple.Create(File.F, Rank.Six, Color.Black),
                Tuple.Create(File.F, Rank.Seven, Color.White),
                Tuple.Create(File.F, Rank.Eight, Color.Black),
                
                Tuple.Create(File.G, Rank.One, Color.Black),
                Tuple.Create(File.G, Rank.Two, Color.White),
                Tuple.Create(File.G, Rank.Three, Color.Black),
                Tuple.Create(File.G, Rank.Four, Color.White),
                Tuple.Create(File.G, Rank.Five, Color.Black),
                Tuple.Create(File.G, Rank.Six, Color.White),
                Tuple.Create(File.G, Rank.Seven, Color.Black),
                Tuple.Create(File.G, Rank.Eight, Color.White),
                
                Tuple.Create(File.H, Rank.One, Color.White),
                Tuple.Create(File.H, Rank.Two, Color.Black),
                Tuple.Create(File.H, Rank.Three, Color.White),
                Tuple.Create(File.H, Rank.Four, Color.Black),
                Tuple.Create(File.H, Rank.Five, Color.White),
                Tuple.Create(File.H, Rank.Six, Color.Black),
                Tuple.Create(File.H, Rank.Seven, Color.White),
                Tuple.Create(File.H, Rank.Eight, Color.Black),
            };

            foreach (var v in data)
            {
                Square square = new Square(v.Item1, v.Item2);
                Assert.AreEqual(square.Color, v.Item3);
            }
        }

        [TestMethod]
        public void PositionAdditionTestGood()
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
                ),

                Tuple.Create
                (
                    new Position(File.A, Rank.One),
                    new Move
                    {
                        Segments =
                        {
                            new Move.Segment{ Direction = Move.Direction.Vertical, Degree = 7}
                        }
                    },
                    new Position(File.A, Rank.Eight)
                ),

                Tuple.Create
                (
                    new Position(File.A, Rank.One),
                    new Move
                    {
                        Segments =
                        {
                            new Move.Segment{ Direction = Move.Direction.Vertical, Degree = 7},
                            new Move.Segment{ Direction = Move.Direction.Horizontal, Degree = 7}
                        }
                    },
                    new Position(File.H, Rank.Eight)
                ),

                Tuple.Create
                (
                    new Position(File.A, Rank.One),
                    new Move
                    {
                        Segments =
                        {
                            new Move.Segment{ Direction = Move.Direction.Vertical, Degree = 7},
                            new Move.Segment{ Direction = Move.Direction.Horizontal, Degree = 7},
                            new Move.Segment{ Direction = Move.Direction.Vertical, Degree = -7},
                        }
                    },
                    new Position(File.H, Rank.One)
                ),

                Tuple.Create
                (
                    new Position(File.A, Rank.One),
                    new Move
                    {
                        Segments =
                        {
                            new Move.Segment{ Direction = Move.Direction.Vertical, Degree = 7},
                            new Move.Segment{ Direction = Move.Direction.Horizontal, Degree = 7},
                            new Move.Segment{ Direction = Move.Direction.Vertical, Degree = -7},
                            new Move.Segment{ Direction = Move.Direction.Horizontal, Degree = -7},
                        }
                    },
                    new Position(File.A, Rank.One)
                )
            };

            foreach (var v in data)
            {
                Position newposition = v.Item1 + v.Item2;
                Assert.AreEqual(v.Item3, newposition);
            }
        }

        [TestMethod]
        public void PositionAdditionTestBad()
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
                            new Move.Segment{ Direction = Move.Direction.Vertical, Degree = -1}
                        }
                    },
                    new Position(File.A, Rank.Two)
                )
            };

            foreach (var v in data)
            {
                Assert.ThrowsException<InvalidSquareException>(()=>(v.Item1 + v.Item2));
            }
        }

        [TestMethod]
        public void BasicPieceTest()
        {
            Board board = new Board();
            Assert.AreEqual(typeof(Pawn), board.Squares[8].Piece.GetType());
            Assert.AreEqual(Color.White, board.Squares[8].Piece.Color);
        }
    }
}
