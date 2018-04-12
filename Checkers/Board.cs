using System;
using System.Collections.Generic;
using System.Text;

namespace Checkers
{
    public interface IBoard
    {
        IPiece Occupant(int position);
        IEnumerable<int> Pieces(Color color);
        void Move(IPiece piece, int destination);
        void RemoveCapturedPieces();
        void Promote(IPiece piece);
    }


    class Board : IBoard
    {
        public void Move(IPiece piece, int destination)
        {
            throw new NotImplementedException();
        }

        public IPiece Occupant(int position)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<int> Pieces(Color color)
        {
            throw new NotImplementedException();
        }

        public void Promote(IPiece piece)
        {
            throw new NotImplementedException();
        }

        public void RemoveCapturedPieces()
        {
            throw new NotImplementedException();
        }
    }
}
