using System;

namespace Chiral.Exceptions
{
    /// <summary>
    /// Represents errors that occur during an invalid Key size.
    /// </summary>
    public class InvalidKeyLengthException : Exception
    {
        public InvalidKeyLengthException() : base($"A Key must be exactly {Kademlia.B} bytes") { }
    }
}
