using System;
using System.Collections.Generic;
using System.Text;

namespace Checkers
{
    public interface IReferee
    {
        IPlayer Winner();
        bool IsDraw();
        void Play();
    }
    public class IllegalMoveException : ApplicationException { }


    class Referee : IReferee
    {
        public bool IsDraw()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public IPlayer Winner()
        {
            throw new NotImplementedException();
        }
    }
}
