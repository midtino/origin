using System;
using System.Collections.Generic;
using System.Text;

namespace Checkers
{
    public interface IPlayer
    {
        string Name { get; }
        (int, int) GetMove();
    }


    class Player : IPlayer
    {
        public string Name => throw new NotImplementedException();

        public (int, int) GetMove()
        {
            throw new NotImplementedException();
        }
    }
}
