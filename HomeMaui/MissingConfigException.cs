﻿using System.Runtime.Serialization;

namespace HomeMaui.Services
{
    [Serializable]
    internal class MissingConfigException : Exception
    {
        public MissingConfigException()
        {
        }

        public MissingConfigException(string? message) : base(message)
        {
        }

        public MissingConfigException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MissingConfigException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}