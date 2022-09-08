using System;
using System.Collections.Generic;
using System.Text;

namespace SkeletonGame.Exceptions
{
    public class TextureException : Exception
    {
        public TextureException()
        {

        }

        public TextureException(string message)
            : base(message)
        {
        }


    }
}
