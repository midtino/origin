using System;
using System.Collections.Generic;
using System.Linq;
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


    public class Board : IBoard
    {

        Piece[] white, black;
        private Piece[] PiecesWithPositions(Color c, params int[] positions)
        {
            return positions.Select(v => new Piece(c, v)).ToArray();
        }
        public Board()
        {
            white = PiecesWithPositions(Color.Black, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
            black = PiecesWithPositions(Color.White, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32);
        }

        public IEnumerable<int> Pieces(Color color)
        {
            if (color == Color.White)
            {
                return white.Select(x => x.Position);
            }
            return black.Select(x => x.Position);
        }

        public void Move(IPiece piece, int destination)
        {
            throw new NotImplementedException();
        }

        public IPiece Occupant(int position)
        {
            throw new NotImplementedException();
        }

        //public IEnumerable<int> Pieces(Color color)
        //{
        //    throw new NotImplementedException();
        //}

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
