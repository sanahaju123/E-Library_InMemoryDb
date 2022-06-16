﻿using System;

namespace e_library.BusinessLayer.Services.UserException
{
    [Serializable]
    public class BookNotFoundException : Exception
    {
        public BookNotFoundException()
        {
        }

        public BookNotFoundException(string message)
            : base(message)
        {
        }

        public BookNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
