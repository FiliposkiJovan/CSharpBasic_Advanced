using System;
using System.Collections.Generic;
using System.Text;

namespace Class9.Exeptions
{
    public class InvalidRatingExeption : Exception
    {
        public InvalidRatingExeption(string message) : base(message)
        {
        }
    }
}
