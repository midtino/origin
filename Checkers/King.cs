using System;
using System.Collections.Generic;
using System.Text;

namespace Checkers
{
    class King : IPiece
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
