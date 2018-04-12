using System;
using System.Collections.Generic;
using System.Text;

namespace Checkers
{
    public enum Color { Black, White }
    public enum Status { Captured, Active }
    public interface IPiece
    {
        IEnumerable<int> NormalMoves(IBoard board);
        IEnumerable<int> CapturingMoves(IBoard board);
        Status Status { get; }
        Color Color { get; }
        int Position { get; }
        void Move(int destination);
    }


    class Piece : IPiece
    {
        public Status Status => throw new NotImplementedException();

        public Color Color => throw new NotImplementedException();

        public int Position => throw new NotImplementedException();

        public IEnumerable<int> CapturingMoves(IBoard board)
        {
            throw new NotImplementedException();
        }

        public void Move(int destination)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<int> NormalMoves(IBoard board)
        {
            throw new NotImplementedException();
        }
    }
}
