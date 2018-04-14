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


    public class Piece : IPiece
    {
        public Piece(Color c, int pos)
        {
            Status = Status.Active;
            Position = pos;
            Color = c;
        }

        public virtual Status Status { get; set; }
        public virtual Color Color { get; private set; }
        public virtual int Position { get; private set; }
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
    //public class King : Piece
    //{
    //    public King(Color c, int p) : base(c, p) { }
    //}

}
