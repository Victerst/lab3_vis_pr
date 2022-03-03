using System;

namespace RomanNumber
{
    public class RomanNumberException : Exception
    {
        public RomanNumberException(string message)
          : base(message)
        {

        }
    }
}